using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Opcao;
            string[] Textos = new string[] { "Calcular área do Retângulo", "Calcular área do Círculo" };

            Console.WriteLine("\t\t\t========== SISTEMA ==========");

            do
            {
                Menu(Textos);
                Opcao = uint.Parse(Console.ReadLine());

                if (Opcao == 1)
                {
                    Console.WriteLine("\t\t\t\t====== RETÂNGULO ======");

                    Console.Write("\t\t\t\t\tInsira a cor do Retângulo: ");
                    string Cor = Console.ReadLine();

                    Console.Write("\t\t\t\t\tInsira a base do Retângulo: ");
                    double Base = double.Parse(Console.ReadLine());

                    Console.Write("\t\t\t\t\tInsira a altura do Retângulo: ");
                    double Altura = double.Parse(Console.ReadLine());

                    new Retangulo(Cor, Base, Altura);
                }
                else if (Opcao == 2)
                {
                    Console.WriteLine("\t\t\t\t====== CÍRCULO ======");

                    Console.Write("\t\t\t\t\tInsira a cor do Círculo: ");
                    string Cor = Console.ReadLine();

                    Console.Write("\t\t\t\t\tInsira o raio do Círculo: ");
                    double Raio = double.Parse(Console.ReadLine());

                    new Circulo(Cor, Raio);
                }
                else if (Opcao == 0)
                {
                    Console.WriteLine("\t\t\t\t====== ATÉ A PRÓXIMA ======");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t====== OPÇÃO INVÁLIDA... ======");
                    continue;
                }
            }
            while (Opcao != 0);
        }

        public static void Menu(string[] Textos)
        {
            Console.WriteLine("\n\nConsidere as opções abaixo: ");

            for (int i = 0; i < Textos.Length; i++)
                Console.WriteLine("\t" + (i + 1) + "-" + Textos[i]);

            Console.WriteLine("\t0-Sair");
            Console.Write("\n\nInsira a opção desejada: ");
        }
    }
}
