using Cash.Domain.Common.Caching;
using Cash.Domain.Common.Quering;
using Cash.Domain.Entity;
using Cash.Persistance.Caching.Broker;
using Cash.Persistance.DataContext;
using Cash.Persistance.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cash.Persistance.Repositories;
public class UserRepository(IdentityDbContext dbContext, ICacheBroker cacheBroker) : EntityRepositoryBase<User, IdentityDbContext>(
    dbContext,
    cacheBroker,
    new CacheEntryOptions()
), IUserRepository
{
  

    ValueTask<User> IUserRepository.CreateAsync(User user, bool saveChanges, CancellationToken cancellationToken)
    {
        return base.CreateAsync(user, saveChanges, cancellationToken);
    }

    ValueTask<User?> IUserRepository.DeleteByIdAsync(Guid userId, bool saveChanges, CancellationToken cancellationToken)
    {
        return base.DeleteByIdAsync(userId, saveChanges, cancellationToken);
    }

    IQueryable<User> IUserRepository.Get(Expression<Func<User, bool>>? predicate, bool asNoTracking)
    {
        return base.Get(predicate, asNoTracking);
    }

    ValueTask<IList<User>> IUserRepository.GetAsync(QuerySpecification<User> querySpecification, bool asNoTracking, CancellationToken cancellationToken)
    {
        return base.GetAsync(querySpecification, asNoTracking, cancellationToken);
    }

    ValueTask<User?> IUserRepository.GetByIdAsync(Guid userId, bool asNoTracking, CancellationToken cancellationToken)
    {
        return base.GetByIdAsync(userId, asNoTracking, cancellationToken);
    }

    ValueTask<User> IUserRepository.UpdateAsync(User user, bool saveChanges, CancellationToken cancellationToken)
    {
        return base.UpdateAsync(user, saveChanges, cancellationToken);
    }
}
