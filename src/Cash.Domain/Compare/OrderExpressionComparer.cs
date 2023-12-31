﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cash.Domain.Compare;
public class OrderExpressionComparer<TSource> : IComparer<(Expression<Func<TSource, object>> KeySelector, bool IsAscending)>
{
    public int Compare(
        (Expression<Func<TSource, object>> KeySelector, bool IsAscending) x,
        (Expression<Func<TSource, object>> KeySelector, bool IsAscending) y
    )
    {
        // TODO : Consider the case where we have same key selector but different order
        if (ReferenceEquals(x.KeySelector, y.KeySelector)) return 0;
        if (ReferenceEquals(null, y.KeySelector)) return 1;
        if (ReferenceEquals(null, x.KeySelector)) return -1;

        var keySelectorComparison = string.Compare(x.KeySelector.ToString(), y.KeySelector.ToString(), StringComparison.Ordinal);
        return keySelectorComparison != 0 ? keySelectorComparison : Comparer<bool>.Default.Compare(x.IsAscending, y.IsAscending);
    }
}

