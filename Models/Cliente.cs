using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capillum.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        
        [StringLength(60, ErrorMessage = "Nome deve conter até 60 caracteres")]
        [Required]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataNascimento { get; set; }

        [StringLength(11, ErrorMessage = "CPF deve conter até 11 dígitos")]
        [Required]
        public string CPF { get; set; }
        public char Sexo { get; set; }

        [StringLength(40, ErrorMessage = "Rua deve conter até 40 caracteres")]
        [Required]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [Required]
        public int Numero { get; set; }

        [StringLength(40, ErrorMessage = "Bairro deve conter até 40 caracteres")]
        [Required]
        public string Bairro { get; set; }

        [StringLength(40, ErrorMessage = "Cidade deve conter até 40 caracteres")]
        [Required]
        public string Cidade { get; set; }

        [StringLength(40, ErrorMessage = "Estado deve conter até 40 caracteres")]
        [Required]
        public string Estado { get; set; }
        public string CEP { get; set; }
    }
}