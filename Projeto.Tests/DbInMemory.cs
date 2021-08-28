using RepositoryProjeto.Connection;
using RepositoryProjeto.Entities;
using System.Data.SQLite;

namespace Projeto.Tests
{
    public class DbInMemory
    {
        private readonly ConexaoDB _context;
        public ConexaoDB GetContext() => _context;

        public DbInMemory()
        {
            /*
            var connection = new SQLiteConnection("Data Source=InMemorySample;Mode=Memory;Cache=Shared");
            connection.Open();
            _context = new ConexaoDB(connection);
             */

            var connectionString = "data source=WILLIAM\\SQLEXPRESS;initial catalog=projeto;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework";
            _context = new ConexaoDB(connectionString);

            //InsertFakeData();
        }

        private void InsertFakeData(bool insertData = true)
        {
            _context.Database.CreateIfNotExists();
            _context.Customers.Add(
                new Customer
                {
                    Id = 1,
                    Nome = "Nome1"
                });
            _context.SaveChanges();
            /*
             */
        }

    }
}