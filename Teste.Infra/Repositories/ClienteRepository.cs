using Teste.Infra.Context;
using Teste.Infra.Entity;
using Teste.Infra.Repositories.Interfaces;

namespace Teste.Infra.Repositories
{
    public class ClienteRepository : RepositoryGeneric<Cliente>, IClienteRepository
    {
        private ClientContext _appContext => (ClientContext)_context;

        public ClienteRepository(ClientContext context) : base(context)
        { }



    }
}
