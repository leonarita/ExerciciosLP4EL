using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o preço do produto (R$): ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Insira o valor do desconto (em %): ");
            double porcentagemDesconto = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            double valorComDesconto = (valor - (valor * (porcentagemDesconto / 100)));

            Console.WriteLine("O valor do produto com desconto é R$ " + valorComDesconto);
            Console.ReadKey();
        }
    }
}
