using System;
using System.Collections.Generic;

namespace Exercicio02
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, decimal> dictionary = new Dictionary<string, decimal>();
            int opcao = 0;

            do
            {
                Cadastrar(dictionary);

                Console.Write("\tInsira 1 se desejar continuar ou 0 se deseja parar: ");
                opcao = int.Parse(Console.ReadLine());
            }
            while (opcao == 1);
            
            Atualizar(dictionary);
            Remover(dictionary);

            VerificarExistenciaChave(dictionary);
            VerificarExistenciaValor(dictionary);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static void Cadastrar(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n=== CADASTRO ===");

            Console.Write("\tInsira o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("\tInsira o salário do funcionario: ");
            decimal salario = decimal.Parse(Console.ReadLine());

            dictionary.Add(nome, salario);
            Console.Write("\t\t" + nome + " cadastrado com salário de R$ " + salario);
            ListagemDados(dictionary);
        }

        public static void Atualizar(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n=== ALTERAÇÃO ===");

            Console.Write("\tInsira o nome do funcionario a ser atualizado: ");
            string nomeParaAtualizar = Console.ReadLine();

            Console.Write("\tInsira o novo salário do funcionario " + nomeParaAtualizar + ": ");
            decimal novoSalario = decimal.Parse(Console.ReadLine());

            dictionary[nomeParaAtualizar] = novoSalario;

            Console.Write("\t\t" + nomeParaAtualizar + " atualizado com salário de R$ " + novoSalario);
            ListagemDados(dictionary);
        }

        public static void Remover(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n=== REMOÇÃO ===");

            Console.Write("\tInsira o nome do funcionario: ");
            string nomeParaRemover = Console.ReadLine();

            bool response = dictionary.Remove(nomeParaRemover);

            Console.Write("\t\t" + nomeParaRemover + (response ? " removido com sucesso" : " não encontrado para ser removido"));
            ListagemDados(dictionary);
        }

        public static void VerificarExistenciaChave(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n=== VERIFICAR EXISTÊNCIA DE FUNCIONARIO ===");

            Console.Write("\tInsira o nome do funcionario: ");
            string nomeParaBuscar = Console.ReadLine();

            if (dictionary.ContainsKey(nomeParaBuscar))
                Console.Write("\t\t" + nomeParaBuscar + " encontrado!");
            else
                Console.Write("\t\t" + nomeParaBuscar + " não encontrado!");

            ListagemDados(dictionary);
        }

        public static void VerificarExistenciaValor(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n=== VERIFICAR EXISTÊNCIA DE FUNCIONARIO ===");

            Console.Write("\tInsira o nome do funcionario: ");
            decimal salarioParaBuscar = decimal.Parse(Console.ReadLine());

            if (dictionary.ContainsValue(salarioParaBuscar))
                Console.Write("\t\tValor encontrado!");
            else
                Console.Write("\t\tValor não encontrado!");
        }

        public static void ListagemDados(Dictionary<string, decimal> dictionary)
        {
            Console.WriteLine("\n\n\t\t\t=== LISTAGEM ===");

            foreach(KeyValuePair<string, decimal> values in dictionary)
            {
                Console.WriteLine("\t\t\t\t" + values.Key + " - R$ " + values.Value);
            }
            Console.WriteLine("\n\n");
        }
    }
}
