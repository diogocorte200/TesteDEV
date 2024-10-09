using Teste.Infra.Context;
using Teste.Infra.Entity;
using Teste.Infra.Repositories.Interfaces;

namespace Teste.Infra.Repositories
{
    public class LogradouroRepository : RepositoryGeneric<Logradouro>, ILogradouroRepository
    {
        private ClientContext _appContext => (ClientContext)_context;

        public LogradouroRepository(ClientContext context) : base(context)
        { }



    }
}
