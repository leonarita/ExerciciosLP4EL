using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Inicio
    {
        static string[] TiposClientesTextos = new string[] { "Pessoa Física", "Pessoa Jurídica" };

        static void Main(string[] args)
        {
            uint Opcao;

            string[] Textos = new string[] { "Inserir Cliente", "Remover", "Consultar clientes" };

            Console.WriteLine("\t\t\t========== SISTEMA ==========");

            do
            {
                Menu(Textos);
                Opcao = uint.Parse(Console.ReadLine());

                if ((uint)Options.INVALIDO == Opcao)
                {
                    Console.WriteLine("\t\t\t\t====== ATÉ A PRÓXIMA ======");
                    Console.ReadKey();
                    break;
                }
                else if(Opcao > 3 || Opcao < 0)
                {
                    Console.WriteLine("\t\t\t\t====== OPÇÃO INVÁLIDA... ======");
                    continue;
                }
                else
                    DirecionamentoOperacoesSistema(Opcao);
            }
            while (Opcao != 0);
        }

        public static void DirecionamentoOperacoesSistema(uint Opcao)
        {
            if((uint) Options.CADASTRAR == Opcao)
            {
                Console.WriteLine("\t\t\t\t====== CADASTRO ======");

                Menu(TiposClientesTextos);
                TipoCliente TipoCliente = (TipoCliente) uint.Parse(Console.ReadLine());

                OperacoesSistema.AdicionarCliente(TipoCliente);
            }
            else if((uint) Options.REMOVER == Opcao)
            {
                Console.WriteLine("\t\t\t\t====== REMOÇÃO ======");

                Menu(TiposClientesTextos);
                TipoCliente TipoCliente = (TipoCliente)uint.Parse(Console.ReadLine());

                Console.Write("\tInforme o código do cliente a ser exluído: ");
                int Codigo = int.Parse(Console.ReadLine());

                OperacoesSistema.RemoverCliente(Codigo, TipoCliente);
            }
            else if((uint) Options.LISTAR == Opcao)
            {
                Console.WriteLine("\t\t\t\t====== LISTAGEM ======");
                OperacoesSistema.ListarClientes();
            }
            else
            {
                Console.WriteLine("\t\t\t\t====== OPÇÃO INVÁLIDA... ======");
            }
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
