using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace aula06.Models
{
    public class UniversidadeContexto : DbContext
    {
        public UniversidadeContexto() : base("name=UniversidadeContexto") { }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Professor> Professores { get; set; }
    }
}