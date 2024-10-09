using Teste.Infra.Context;
using Teste.Infra.Repository;

namespace Teste.Infra.UnitofWork
{
    public interface IUnitofWork : IDisposable
    {

        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IRepositoryAsync<TEntity> GetRepositoryAsync<TEntity>() where TEntity : class;

        ClientContext Context { get; }
        int Save();
        Task<int> SaveAsync();
    }

}
