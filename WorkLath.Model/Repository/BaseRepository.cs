using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkLath.Model.Contexts;
using Microsoft.EntityFrameworkCore;

namespace WorkLath.Service.Repository
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> Query();
        Task<TEntity> Get(int id);
        Task<TEntity> Add(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Delete(int id);
    }
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBase
    {
        protected readonly IDbContext _context;
        protected readonly DbSet<TEntity> _set;
        public BaseRepository(IDbContext context)
        {
            _context = context;
            _set = context.Set<TEntity>();
        }
        public IQueryable<TEntity> Query()
        {
            return _set.AsQueryable();
        }
        public async Task<TEntity> Add(TEntity entity)
        {
            var result = await _set.AddAsync(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
        public async Task<TEntity> Delete(int id)
        {
            var entity = await Get(id);

            var result = _set.Remove(entity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }
        public async Task<TEntity> Get(int id)
        {
            var entity = await _set.Where(x => x.Id == id).FirstOrDefaultAsync();
            return entity;
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
