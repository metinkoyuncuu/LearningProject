

using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System.Threading;

namespace Core.DataAccess.EntityFramework;

public class EfEntityRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>
    , IRepository<TEntity, TEntityId>
    where TEntity : Entity<TEntityId> where TContext : DbContext
{
    protected readonly TContext Context;

    public EfEntityRepositoryBase(TContext context)
    {
        Context = context;
    }

    public IQueryable<TEntity> Query() => Context.Set<TEntity>();
    public TEntity? Get(Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false, 
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = Query();
        if (enableTracking is false)
            queryable = queryable.AsNoTracking();
        if (include is not null)
            queryable = include(queryable);
        if(withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        return queryable.FirstOrDefault(predicate);
    }

    public async Task<TEntity?> GetAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false, bool enableTracking = true, 
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        if (enableTracking is false)
            queryable = queryable.AsNoTracking();
        if(include is not null)
            queryable = include(queryable);
        if( withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        return await queryable.FirstOrDefaultAsync(predicate, cancellationToken);
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        entity.CreatedDate = DateTime.UtcNow;
        await Context.AddAsync(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public TEntity Add(TEntity entity)
    {
        entity.CreatedDate = DateTime.UtcNow;
        Context.Add(entity);
        Context.SaveChanges();
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        entity.UpdatedDate = DateTime.UtcNow;
        Context.Update(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        entity.UpdatedDate = DateTime.UtcNow;
        Context.Update(entity);
        Context.SaveChanges();
        return entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        entity.DeletedDate= DateTime.UtcNow;
        Context.Remove(entity);
        await Context.SaveChangesAsync();
        return entity;
    }

    public TEntity Delete(TEntity entity)
    {
        entity.DeletedDate = DateTime.UtcNow;
        Context.Remove(entity);
        Context.SaveChanges();
        return entity;
    }

    public async Task<bool> AnyAsync(
        Expression<Func<TEntity, bool>> predicate, 
        bool withDeleted = false, 
        bool enableTracking = true, 
        CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        if (enableTracking is not false)
            queryable = queryable.AsNoTracking();
        if (withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        if (predicate is not null)
            queryable = queryable.Where(predicate);
        return await queryable.AnyAsync(cancellationToken);
    }

    public bool Any(
        Expression<Func<TEntity, bool>> predicate,
        bool withDeleted = false,
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = Query();
        if (enableTracking is not false)
            queryable = queryable.AsNoTracking();
        if (withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        if (predicate is not null)
            queryable = queryable.Where(predicate);
        return  queryable.Any();
    }

    public async Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false)
    {
        foreach (TEntity entity in entities)
            entity.DeletedDate = DateTime.UtcNow;
        Context.RemoveRange(entities);
        await Context.SaveChangesAsync();
        return entities;
    }

    public async Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities)
    {
        foreach(TEntity entity in entities)
            entity.CreatedDate = DateTime.UtcNow;
        await Context.AddRangeAsync(entities);
        await Context.SaveChangesAsync();
        return entities;
    }

    public async Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities)
    {
        foreach (TEntity entity in entities)
            entity.UpdatedDate = DateTime.UtcNow;
        Context.UpdateRange(entities);
        await Context.SaveChangesAsync();
        return entities;
    }

    public ICollection<TEntity> DeleteRange(ICollection<TEntity> entities, bool permanent = false)
    {
        foreach (TEntity entity in entities)
            entity.DeletedDate = DateTime.UtcNow;
        Context.RemoveRange(entities);
        Context.SaveChanges();
        return entities;
    }

    public ICollection<TEntity> AddRange(ICollection<TEntity> entities)
    {
        foreach (TEntity entity in entities)
            entity.CreatedDate = DateTime.UtcNow;
        Context.AddRange(entities);
        Context.SaveChanges();
        return entities;
    }

    public ICollection<TEntity> UpdateRange(ICollection<TEntity> entities)
    {
        foreach (TEntity entity in entities)
            entity.UpdatedDate = DateTime.UtcNow;
        Context.UpdateRange(entities);
        Context.SaveChanges();
        return entities;
    }

    public GetAllModel<TEntity> GetAll(
        Expression<Func<TEntity, bool>> predicate, 
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        bool withDeleted = false,
        bool enableTracking = true)
    {
        IQueryable<TEntity> queryable = Query();

        if (enableTracking is false)
            queryable = queryable.AsNoTracking();
        if (include is not null)
            queryable = include(queryable);
        if (withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        if (orderBy is not null)
            queryable = orderBy(queryable);
        if (predicate is not null)
            queryable = queryable.Where(predicate);
        
        return new GetAllModel<TEntity> { Items = queryable.ToList(),Count = queryable.Count() };
       
    }

    public async Task<GetAllModel<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
    {
        IQueryable<TEntity> queryable = Query();
        
        if (enableTracking is false)
            queryable = queryable.AsNoTracking();
        if (include is not null)
            queryable = include(queryable);
        if (withDeleted is true)
            queryable = queryable.IgnoreQueryFilters();
        if (orderBy is not null)
            queryable = orderBy(queryable);
        if (predicate is not null)
            queryable = queryable.Where(predicate);
        GetAllModel<TEntity> getAllModel = new()
        {
            Items = await queryable.ToListAsync(cancellationToken),
            Count = queryable.Count()
        };
        return getAllModel;
    }
}
