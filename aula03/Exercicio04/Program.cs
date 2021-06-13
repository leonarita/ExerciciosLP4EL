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

            try
            {
                Console.Write("Insira a descrição: ");
                string Descricao = Console.ReadLine();

                if (Descricao.Length < 3)
                    throw new Exception("Descrição inválida");

                produto.Descricao = Descricao;
            }
            catch(Exception e)
            {
                Console.WriteLine("\t" + e.Message);
                return;
            }

            try
            {
                Console.Write("Insira o preço: ");
                produto.Preco = decimal.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Número inválido");
                produto.Preco = 0;
            }
            catch
            {
                Console.WriteLine("Erro inesperado");
                produto.Preco = 0;
            }
            finally
            {
                Console.WriteLine("\tPreço é R$ " + produto.Preco);
            }

            try
            {
                Console.Write("Insira se está ativo (S/N): ");
                string Ativo = Console.ReadLine().ToUpper();

                produto.Ativo = Ativo == "S" ? true : (Ativo == "N" ? false : throw new Exception("Valor inválido"));
            }
            catch(Exception e)
            {
                Console.WriteLine("\tERRO: " + e.Message);
            }

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
