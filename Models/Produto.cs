using System;
using System.ComponentModel.DataAnnotations;

namespace Capillum.Models
{
    public class Produto
    {
        public int Id { get; set; }
        
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        
        [Display(Name = "Valor Unitário")]
        public decimal ValorUnitario { get; set; }
        
        [Display(Name = "Indicação")]
        public string Indicacao { get; set; }
    }
}