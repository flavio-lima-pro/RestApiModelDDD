using Microsoft.EntityFrameworkCore;
using RestApiModelDDD.Domain.Entities;
using System;
using System.Linq;

namespace RestApiModelDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DateOfRegistration") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DateOfRegistration").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DateOfRegistration").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
