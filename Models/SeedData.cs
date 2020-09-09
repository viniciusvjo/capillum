using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Capillum.Data;
using System;
using System.Linq;

namespace Capillum.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CapillumContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CapillumContext>>()))
            {
                // Look for any movies.
                if (context.Servico.Any())
                {
                    return;   // DB has been seeded
                }

                context.Servico.AddRange(
                    new Servico
                    {
                        Descricao = "Corte Feminino",
                        TempoMedio = 30,
                        PrecoMedio = 35.00M
                    },

                    new Servico
                    {
                        Descricao = "Corte Masculino",
                        TempoMedio = 15,
                        PrecoMedio = 15.50M
                    },

                    new Servico
                    {
                        Descricao = "Plástico de Fios",
                        TempoMedio = 120,
                        PrecoMedio = 100.00M
                    },

                    new Servico
                    {
                        Descricao = "Mechas",
                        TempoMedio = 90,
                        PrecoMedio = 60.00M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}