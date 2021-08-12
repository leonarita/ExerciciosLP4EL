using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aula06.Models
{
    public class Curso
    {
        [Key]
        public int IdCurso { get; set; }

        public string Descricao { get; set; }

        public int IdDepartamento { get; set; }

        [ForeignKey("IdDepartamento")]
        public Departamento Departamento { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}