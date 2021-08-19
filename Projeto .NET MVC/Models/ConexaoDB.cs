using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Projeto.NET_MVC.Models
{
    public partial class ConexaoDB : DbContext
    {
        public ConexaoDB()
            : base("name=ConexaoDB")
        {
        }

        public virtual DbSet<Aluguel> Aluguels { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Aluguels)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.Id_customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .HasMany(e => e.Aluguels)
                .WithRequired(e => e.Movie)
                .HasForeignKey(e => e.Id_movie)
                .WillCascadeOnDelete(false);
        }
    }
}
