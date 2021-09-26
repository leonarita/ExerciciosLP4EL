using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Editora
    {
        public long? EditoraId { get; set; }
        public string Nome { get; set; }
        public string Site { get; set; }

        public virtual ICollection<Livro> Livro { get; set; }
    }
}
