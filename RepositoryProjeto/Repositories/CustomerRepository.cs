using RepositoryProjeto.Connection;
using RepositoryProjeto.Entities;
using RepositoryProjeto.Interfaces;

namespace RepositoryProjeto.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(ConexaoDB context) : base(context) { }
    }
}
