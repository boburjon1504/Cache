using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash.Domain.Common.Caching;
public abstract class CacheModel
{
    public abstract string CacheKey { get; }
}
