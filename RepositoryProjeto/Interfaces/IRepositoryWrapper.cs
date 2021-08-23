using System.Threading.Tasks;

namespace RepositoryProjeto.Interfaces
{
    public interface IRepositoryWrapper
    {
        void Dispose();
        ICustomerRepository CustomerRepository { get; }
        IMovieRepository MovieRepository { get; }
        IAluguelRepository AluguelRepository { get; }
    }
}
