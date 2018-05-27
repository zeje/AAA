using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AAA.EntityFramework.Repositories
{
    public abstract class AAARepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AAADbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AAARepositoryBase(IDbContextProvider<AAADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AAARepositoryBase<TEntity> : AAARepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AAARepositoryBase(IDbContextProvider<AAADbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
