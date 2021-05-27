using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("A média do aluno é " + ((nota1 + nota2)/2));
            Console.ReadKey();
        }
    }
}
