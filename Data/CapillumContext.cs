using Microsoft.EntityFrameworkCore;
using Capillum.Models;

namespace Capillum.Data
{
    public class CapillumContext : DbContext
    {
        public CapillumContext (DbContextOptions<CapillumContext> options)
            : base(options)
        {
        }

        public DbSet<Servico> Servico { get; set; }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Capillum.Models.Agenda> Agenda { get; set; }
    }
}