using System;
using System.Collections.Generic;

namespace Capillum.Models
{
    public partial class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int TempoMedio { get; set; }
        public double PrecoMedio { get; set; }
    }
}
