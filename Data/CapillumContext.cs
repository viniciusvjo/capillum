using Microsoft.EntityFrameworkCore;
using Capillum.Models;

namespace Capillum.Data
{
    public partial class CapillumContext : DbContext
    {
        public CapillumContext()
        {
        }

        public CapillumContext(DbContextOptions<CapillumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Servico> Servico { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Agenda> Agenda { get; set; }
    }
}
