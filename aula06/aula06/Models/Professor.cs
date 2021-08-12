using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aula06.Models
{
    public class Professor
    {
        [Key]
        public int IdProfessor { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}