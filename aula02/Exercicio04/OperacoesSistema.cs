using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class OperacoesSistema
    {

        private static PessoaFisica[] PessoasFisicas = new PessoaFisica[10];
        private static PessoaJuridica[] PessoasJuridicas = new PessoaJuridica[10];

        public static int IndexPF = 0, IndexPJ = 0;

        public static void AdicionarCliente(TipoCliente TipoCliente)
        {

            switch (TipoCliente)
            {
                case TipoCliente.PESSOA_FISICA:

                    if(IndexPF == 10)
                    {
                        Console.WriteLine("\n\n\tBanco de Dados lotado lotado!");
                        return;
                    }

                    PessoasFisicas[IndexPF] = (PessoaFisica) CriarCliente(TipoCliente);
                    IndexPF++;
                    Console.WriteLine("\n\n\tCadastrado com sucesso!");
                    break;

                case TipoCliente.PESSOA_JURIDICA:

                    if (IndexPJ == 10)
                    {
                        Console.WriteLine("\n\n\tBanco de Dados lotado lotado!");
                        return;
                    }

                    PessoasJuridicas[IndexPJ] = (PessoaJuridica) CriarCliente(TipoCliente);
                    IndexPJ++;
                    Console.WriteLine("\n\n\tCadastrado com sucesso!");
                    break;

                default:
                    Console.WriteLine("\t\tOpção Inválida...");
                    break;
            }
        }

        public static void RemoverCliente(int Codigo, TipoCliente TipoCliente)
        {
            switch (TipoCliente)
            {
                case TipoCliente.PESSOA_FISICA:
                    IndexPF = RemoverPessoa(Codigo, IndexPF, PessoasFisicas);
                    break;

                case TipoCliente.PESSOA_JURIDICA:
                    IndexPJ = RemoverPessoa(Codigo, IndexPJ, PessoasJuridicas);
                    break;

                default:
                    Console.WriteLine("\t\tOpção Inválida...");
                    break;
            }

        }

        public static void ListarClientes()
        {
            Console.WriteLine("\t\t\t\t\t==== PESSOAS FÍSICAS ====");

            foreach (PessoaFisica PessoaFisica in PessoasFisicas)
            {
                if (PessoaFisica is null)
                    break;

                Console.WriteLine("\t\t\t\t" + PessoaFisica.ToString());
            }

            Console.WriteLine("\t\t\t\t\t==== PESSOAS JURÍDICAS ====");

            foreach(PessoaJuridica PessoaJuridica in PessoasJuridicas)
            {
                if (PessoaJuridica is null)
                    break;

                Console.WriteLine("\t\t\t\t" + PessoaJuridica.ToString());
            }
        }

        private static int RemoverPessoa(int Codigo, int Index, Cliente[] Clientes)
        {
            for (int i = 0; i < Index; i++)
            {
                if (Clientes[i].GetCodigo() == Codigo)
                {
                    Clientes[i] = null;

                    for (int j = i; j < IndexPF - 1; j++)
                    {
                        Clientes[j] = Clientes[j + 1];
                    }

                    Clientes[Index - 1] = null;
                    Console.WriteLine("\n\n\tDeletado com sucesso!");
                    return Index - 1;
                }
            }

            Console.WriteLine("\n\n\tUsuário não encontrado!");
            return Index;
        }

        private static Cliente CriarCliente(TipoCliente TipoCliente)
        {
            Console.Write("\t\t\t\tInsira o Código: ");
            int Codigo = int.Parse(Console.ReadLine());

            Console.Write("\t\t\t\tInsira o Telefone: ");
            string Telefone = Console.ReadLine();

            Console.Write("\t\t\t\tInsira o Endereço: ");
            string Endereco = Console.ReadLine();

            switch (TipoCliente)
            {
                case TipoCliente.PESSOA_FISICA:
                    Console.Write("\t\t\t\tInsira o Nome: ");
                    string Nome = Console.ReadLine();

                    Console.Write("\t\t\t\tInsira o CPF: ");
                    string CPF = Console.ReadLine();

                    return new PessoaFisica(Codigo, Endereco, Telefone, Nome, CPF);

                case TipoCliente.PESSOA_JURIDICA:
                    Console.Write("\t\t\t\tInsira o Razão Social: ");
                    string RazaoSocial = Console.ReadLine();

                    Console.Write("\t\t\t\tInsira o CNPJ: ");
                    string CNPJ = Console.ReadLine();

                    return new PessoaJuridica(Codigo, Endereco, Telefone, RazaoSocial, CNPJ);

                default:
                    Console.WriteLine("\t\tOpção Inválida...");
                    break;
            }

            return null;
        }

    }
}
