

using OnionSample.Core.Domain.BaseEntities;

namespace OnionSample.Core.ApplicationServiceContract.Contracts.Repositoreis
{
   public interface IGenericRepository<Tentity>:IDisposable where Tentity : BaseEntity
    {
        IQueryable<Tentity> GetTentitiesQuery();
        Task<Tentity> GetTentityById(int entityId);
        Task AddEntity(Tentity entity);
        void UpdateEntity(Tentity entity);
        void RemoveEntity(Tentity entity);
        Task RemoveEntity(int entityId);
        Task SaveChanges(); 

    }

}
