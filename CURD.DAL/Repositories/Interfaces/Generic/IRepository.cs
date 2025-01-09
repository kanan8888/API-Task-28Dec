using CURD.Core.Entityes.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL.Repositories.Interfaces.Generic;
public interface IRepository<TEntity> where TEntity : BaseEntity, new()
{
    public DbSet<TEntity> Table { get; }

    public Task<TEntity> CreateAsync(TEntity entity);
    public Task<TEntity> GetByIdAsync(int id);
    public IQueryable<TEntity> GetAll(params string[] includes);
    public Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> expression = null);
    public Task<bool> IsExist(Expression<Func<TEntity, bool>> expression);
    public void Update(TEntity entity);
    public void Delete(TEntity entity);
    public void Restore(TEntity entity);
    public void SoftDelete(TEntity entity); 
    public Task<int> SaveChangesAsync();

}
