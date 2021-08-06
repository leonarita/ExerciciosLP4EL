using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Inicio
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static int id = 1;

        static void Main(string[] args)
        {
            string[] textos = new string[] { "Inserir Cliente", "Alterar Cliente", "Excluir Cliente", "Consultar clientes" };
            uint opcao;

            Console.WriteLine("\t\t\t========== SISTEMA ==========");

            do
            {
                Menu(textos);
                opcao = uint.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("\t\t\t\t====== ATÉ A PRÓXIMA ======");
                    Console.ReadKey();
                    break;
                }
                else if (opcao > 4 || opcao < 0)
                {
                    Console.WriteLine("\t\t\t\t====== OPÇÃO INVÁLIDA... ======");
                    continue;
                }
                else
                {
                    DirecionamentoOperacoesSistema(opcao);
                }
            }
            while (opcao != 0);
        }

        public static void DirecionamentoOperacoesSistema(uint opcao)
        {
            if (opcao == 1)
            {
                Console.WriteLine("\t\t\t\t====== CADASTRO ======");

                Cliente cliente = new Cliente();
                bool salvar = true;

                Console.Write("\t\t\t\t\tInsira o Nome: ");
                salvar = salvar && cliente.SetNome(Console.ReadLine());

                Console.Write("\t\t\t\t\tInsira o CPF: ");
                salvar = salvar && cliente.SetCpf(Console.ReadLine());

                if(salvar)
                {
                    cliente.SetCodigo(id);
                    clientes.Add(cliente);
                    id++;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t\t\tDados inválidos, não foi possível cadastrar...");
                }
            }
            if (opcao == 2)
            {
                Console.WriteLine("\t\t\t\t====== ALTERAÇÃO ======");
                int codigoParaRemover = 0;

                Console.Write("\t\t\t\t\tInsira o código para atualizar o respectivo usuário: ");
                int codigo = int.Parse(Console.ReadLine());

                for (int i = 0; i < clientes.Count; i++)
                {
                    if (codigo == clientes[i].GetCodigo())
                    {
                        codigoParaRemover = i;
                    }
                }

                if (codigoParaRemover != 0)
                {
                    Cliente cliente = clientes[codigoParaRemover];
                    clientes.RemoveAt(codigoParaRemover);

                    Console.Write("\t\t\t\t\tInsira o Nome: ");
                    cliente.SetNome(Console.ReadLine());

                    Console.Write("\t\t\t\t\tInsira o CPF: ");
                    cliente.SetCpf(Console.ReadLine());

                    clientes.Insert(codigoParaRemover, cliente);
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\t\t\t\t====== EXCLUSÃO ======");
                int codigoParaRemover = 0;

                Console.Write("\t\t\t\t\tInsira o código para remover o respectivo usuário: ");
                int codigoSelecionadoPeloUsuarioParaRemover = int.Parse(Console.ReadLine());

                for (int i = 0; i < clientes.Count; i++)
                {
                    if (codigoSelecionadoPeloUsuarioParaRemover == clientes[i].GetCodigo())
                    {
                        codigoParaRemover = i;
                    }
                }

                if(codigoParaRemover != 0)
                {
                    clientes.RemoveAt(codigoParaRemover);
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("\t\t\t\t====== LISTAGEM ======");

                foreach (Cliente cliente in clientes)
                {
                    if (cliente is null)
                        break;

                    Console.WriteLine("\t\t\t\t\t" + cliente.ToString());
                }
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
