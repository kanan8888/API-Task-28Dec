using CURD.Core.Entityes.Base;
using CURD.DAL.Context;
using CURD.DAL.Repositories.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Repositories.Implementations.Generic;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
{
    readonly CURD_DbContext _context;
    public Repository(CURD_DbContext context)
    {
        _context = context;
    }

    public DbSet<TEntity> Table => _context.Set<TEntity>();

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        await Table.AddAsync(entity);
        return entity;
    }
    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await Table.AsNoTracking().FirstOrDefaultAsync(x => x.Id==id && !x.IsDeleted);
    }
    public IQueryable<TEntity> GetAll(params string[] includes)
    {
        var query = Table.Where(x => !x.IsDeleted);

        if (includes!=null) 
        {
            foreach (var include in includes) 
            {
                query=query.Include(include);
            }
        }
        
        return query;
    }   
    public async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null)
    {
        return expression==null ? Table : Table.Where(expression);
      //return expression==null ? Table.Where(x => !x.IsDeleted) : Table.Where(expression).Where(x => !x.IsDeleted);
    }
    public Task<bool> IsExist(Expression<Func<TEntity, bool>> expression)
    {
        return Table.AnyAsync(expression);
    }
    public void Update(TEntity entity)
    {
        Table.Update(entity);
    }
    public void Delete(TEntity entity)
    {
        entity.IsDeleted=true;
    }
    public void Restore(TEntity entity)
    {
        entity.IsDeleted = false;
    }
    public void SoftDelete(TEntity entity)
    {
        Table.Remove(entity);
    }
    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }

}
