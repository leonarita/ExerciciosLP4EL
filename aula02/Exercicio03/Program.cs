using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Insira o código: ");
            produto.Codigo = ulong.Parse(Console.ReadLine());

            Console.Write("Insira a descrição: ");
            produto.Descricao = Console.ReadLine();

            Console.Write("Insira o preço: ");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.Write("Insira se está ativo (S/N): ");
            produto.Ativo = Console.ReadLine().ToUpper().Contains("S") ? true : false;

            Console.WriteLine("\n\n\tO produto " + produto.Descricao + ", cujo código é " + produto.Codigo + ", custa R$ "
                + produto.Preco + " e " + (produto.Ativo ? "" : "não ") + "está ativo");

            Console.ReadKey();
        }
    }

    class Produto
    {
        private ulong codigo;
        private string descricao;
        private decimal preco;
        private bool ativo;

        public Produto(ulong Codigo = 0, string Descricao = "", decimal? Preco = 0, bool Ativo = false)
        {
            this.codigo = Codigo;
            this.descricao = Descricao;
            this.preco = Preco.Value;
            this.ativo = Ativo;
        }

        ~Produto()
        {
            Console.WriteLine("\n\nProduto destruído");
        }

        public ulong Codigo 
        { 
            get => codigo; 
            set
            {
                if(value != 0)
                {
                    codigo = value;
                }
            }
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }

        public decimal Preco
        {
            get => preco;
            set
            {
                if (value != 0)
                {
                    preco = value;
                }
            }
        }

        public bool Ativo
        {
            get => ativo;
            set => ativo = value;
        }
    }
}
