using RepositoryProjeto.Connection;
using RepositoryProjeto.Entities;
using RepositoryProjeto.Interfaces;

namespace RepositoryProjeto.Repositories
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(ConexaoDB context) : base(context) { }
    }
}
