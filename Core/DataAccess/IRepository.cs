using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;


namespace Core.DataAccess;

public interface IRepository<TEntity,TentityId>:IQuery<TEntity>
    where TEntity : Entity<TentityId>
{
    TEntity? Get(
        Expression<Func<TEntity,bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity,object>>? include=null,
        bool withDeleted =false,
        bool enableTracking=true
        );
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);
    bool Any(
        Expression<Func<TEntity,bool>> predicate,
        bool withDeleted=false,
        bool enableTracking=true
        );
    ICollection<TEntity> DeleteRange(ICollection<TEntity> entity, bool permanent = false);
    ICollection<TEntity> AddRange(ICollection<TEntity> entities);
    ICollection<TEntity> UpdateRange(ICollection<TEntity> entities);
    GetAllModel<TEntity> GetAll(
        Expression<Func<TEntity,bool>> predicate,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? include=null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        bool withDeleted=false,
        bool enableTracking=true
        );
}

