using DesafioAPI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DesafioAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Fabricacao") != null || entry.Entity.GetType().GetProperty("Validade") != null))
            {
                if (entry.Entity.GetType().GetProperty("Fabricacao") != null)
                {

                }
                else
                {
                }
            }
            return base.SaveChanges();
        }
    }
}
