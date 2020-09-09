using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capillum.Models
{
    public class Agenda
    {
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Serviço")]
        public int IdServico { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        
        [Display(Name = "Horário")]
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime Horario { get; set; }
    }
}