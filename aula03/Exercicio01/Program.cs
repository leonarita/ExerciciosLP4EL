using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Opcao;
            Pesquisa Pesquisa = new Pesquisa();
            string[] Textos = new string[] { "Informar texto", "Buscar string", "Buscar string no início", "Buscar string no fim" };

            Console.WriteLine("\t\t\t========== SISTEMA ==========");

            do
            {
                Menu(Textos);
                Opcao = uint.Parse(Console.ReadLine());

                if(Opcao == 1)
                {
                    Pesquisa.Text = SolicitarTextoUsuario("Insira uma string a ser inserido: ");
                }
                else if (Opcao == 2)
                {
                    Pesquisa = new Pesquisa();
                    bool Result = Pesquisa.BuscarString(SolicitarTextoUsuario("Insira uma string a ser pesquisada no texto: "));
                    VerificarResultado(Result, Opcao);
                }
                else if (Opcao == 3)
                {
                    Pesquisa = new PesquisaInicio();
                    bool Result = Pesquisa.BuscarString(SolicitarTextoUsuario("Insira uma string a ser pesquisada no início do texto: "));
                    VerificarResultado(Result, Opcao);
                }
                else if (Opcao == 4)
                {
                    Pesquisa = new PesquisaFim();
                    bool Result = Pesquisa.BuscarString(SolicitarTextoUsuario("Insira uma string a ser pesquisada no fim do texto: "));
                    VerificarResultado(Result, Opcao);
                }
                else if(Opcao == 0)
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

        public static string SolicitarTextoUsuario(string Text)
        {
            Console.Write("\t\t\t\t" + Text);
            return Console.ReadLine();
        }

        public static void VerificarResultado(bool Result, uint Opcao)
        {
            Console.WriteLine("\t\t\t\t\tTexto " + (Result == true ? "" : "não ") + "encontrado " + (Opcao == 3 ? "no inicio" : (Opcao == 4 ? "no fim" : "")));
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
