using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capillum.Models
{
    public class Servico
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Tempo Médio")]
        public int TempoMedio { get; set; }
        
        [Display(Name = "Preço Médio")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecoMedio { get; set; }
    }
}