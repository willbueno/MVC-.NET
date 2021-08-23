using RepositoryProjeto.Connection;
using RepositoryProjeto.Entities;
using RepositoryProjeto.Interfaces;

namespace RepositoryProjeto.Repositories
{
    public class AluguelRepository : RepositoryBase<Aluguel>, IAluguelRepository
    {
        public AluguelRepository(ConexaoDB context) : base(context) { }
    }
}
