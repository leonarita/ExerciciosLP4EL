using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class Funcionario
    {
        [Key]
        public int IdAssunto { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { set; get; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [StringLength(11, ErrorMessage = "O CPF deve ter exatamente 11 caracteres")]
        public string Cpf { set; get; }

        [Required(ErrorMessage = "O campo Salário é obrigatório")]
        [Range(1000, 5000, ErrorMessage = "O salário deve ser entre R$ 1.000,00 e R$ 5.000,00")]
        public decimal Salario { set; get; }

        public string Observacao { set; get; }
    }
}