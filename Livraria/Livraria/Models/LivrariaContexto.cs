using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Models
{
    public class LivrariaContexto : DbContext
    {
        public LivrariaContexto(DbContextOptions<LivrariaContexto> options) : base(options) { }

        public DbSet<Livro> Livro { get; set; }
        public DbSet<Editora> Editora { get; set; }
    }
}
