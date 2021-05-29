using System;

namespace Exercicio02
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
        public ulong Codigo { set; get; }
        public string Descricao { set; get; }
        public decimal Preco { set; get; }
        public bool Ativo { set; get; }
    }
}
