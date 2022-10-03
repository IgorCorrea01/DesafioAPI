using DesafioAPI.Domain.Entity;
using Microsoft.EntityFrameworkCore;

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
    }
}
