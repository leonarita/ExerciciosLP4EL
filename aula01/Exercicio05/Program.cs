using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a distância (km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Insira o preço do combustível (R$): ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Insira o consumo do combustível (km/h): ");
            double consumo = double.Parse(Console.ReadLine());

            double litro = distancia / consumo;
            double precoFinal = litro * preco;

            Console.WriteLine("\n");
            Console.WriteLine("A viagem vai custar R$ " + precoFinal);
            Console.ReadKey();
        }
    }
}
