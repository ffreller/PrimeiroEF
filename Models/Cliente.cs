using System;
using System.ComponentModel.DataAnnotations;

namespace PrimeiroEF.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50,ErrorMessage="O nome náo pode conter mais que 50 caracteres")]
        public string nome { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        [Range(1,100)]
        public int idade { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime datacadastro { get; set; }

    }
}