using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Livro
    {
        public long? LivroId { get; set; }
        public string Titulo { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }

        public long? EditoraId { get; set; }
        public Editora Editora { get; set; }
    }
}
