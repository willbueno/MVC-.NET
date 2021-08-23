using RepositoryProjeto.Connection;
using RepositoryProjeto.Interfaces;
using System;

namespace RepositoryProjeto.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper, IDisposable
    {
        private readonly ConexaoDB _context;
        private IMovieRepository _movieRepository;
        private IAluguelRepository _aluguelRepository;
        private ICustomerRepository _customerRepository;

        public RepositoryWrapper()
        {
            _context = new ConexaoDB();
        }

        public RepositoryWrapper(ConexaoDB context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IMovieRepository MovieRepository
        {
            get
            {
                if (_movieRepository == null)
                {
                    _movieRepository = new MovieRepository(_context);
                }

                return _movieRepository;
            }
        }

        public IAluguelRepository AluguelRepository
        {
            get
            {
                if (_aluguelRepository == null)
                {
                    _aluguelRepository = new AluguelRepository(_context);
                }

                return _aluguelRepository;
            }
        }

        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(_context);
                }

                return _customerRepository;
            }
        }
    }
}
