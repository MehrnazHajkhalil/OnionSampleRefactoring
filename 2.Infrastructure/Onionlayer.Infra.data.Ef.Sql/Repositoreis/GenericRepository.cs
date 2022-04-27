

using Microsoft.EntityFrameworkCore;
using OnionSample.Infra.data.Ef.Sql.Contexts;
using OnionSample.Core.ApplicationServiceContract.Contracts.Repositoreis;
using OnionSample.Core.Domain.BaseEntities;

namespace OnionSample.Infra.data.Ef.Sql.Repositoreis
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region Consructor

       
        private CourseStoreDbContext _context;
        private DbSet<TEntity> dbSet;

        public GenericRepository(CourseStoreDbContext context)
        {
            this._context = context;
            this.dbSet = this._context.Set<TEntity>();
        }
        #endregion

        public async Task AddEntity(TEntity entity)
        {
      
           await dbSet.AddAsync(entity);
        }

      
        public IQueryable<TEntity> GetTentitiesQuery()
        {
            return dbSet.AsQueryable();
        }

     

        public void RemoveEntity(TEntity entity)
        {
          
            UpdateEntity(entity);
        }

        public async Task RemoveEntity(int entityId)
        {
            var entity = await GetTentityById(entityId);
            RemoveEntity(entity);
        }

        public async Task SaveChanges()
        {
           await  _context.SaveChangesAsync();
        }

        public void UpdateEntity(TEntity entity)
        {
            dbSet.Update(entity);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<TEntity> GetTentityById(int entityId)
        {
            return await dbSet.SingleOrDefaultAsync(e => e.Id == entityId);
        }
       
    }
}
