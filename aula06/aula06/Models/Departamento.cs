using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace aula06.Models
{
    public class Departamento
    {
        [Key]
        public int IdDepartamento { get; set; }

        public string Descricao { get; set; }

        public ICollection<Curso> Cursos { get; set; }
    }
}