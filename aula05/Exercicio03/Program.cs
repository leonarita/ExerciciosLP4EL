using System;
using System.Collections.Generic;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet1 = new HashSet<string>();
            HashSet<string> hashSet2 = new HashSet<string>();
            int opcao = 0;

            Console.WriteLine("\n\n=== CADASTRO - HASHSET 1 ===");

            do
            {
                opcao = Cadastrar(hashSet1);
                ListagemDados(hashSet1, "HASHSET 1");
            }
            while (opcao == 1);

            Console.WriteLine("\n\n=== CADASTRO - HASHSET 2 ===");

            do
            {
                opcao = Cadastrar(hashSet2);
                ListagemDados(hashSet2, "HASHSET 2");
            }
            while (opcao == 1);

            EncontrarProdutosEmComum(Clonar(hashSet1), hashSet2);
            JuntarProdutos(Clonar(hashSet1), hashSet2);
            SubtrairConjunto(Clonar(hashSet1), hashSet2);

            VerSeCOonjunto1EstaContidoNoConjunto2(hashSet1, hashSet2);
            VerSeCOonjunto1ContemConjunto2(hashSet1, hashSet2);

            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        public static int Cadastrar(HashSet<string> hashSet)
        {
            Console.Write("\tInsira o nome do produto: ");
            string nome = Console.ReadLine();

            hashSet.Add(nome);

            Console.Write("\tInsira 1 se desejar continuar ou 0 se deseja parar: ");
            return int.Parse(Console.ReadLine());
        }

        public static void Remover(HashSet<string> hashSet)
        {
            Console.WriteLine("\n\n=== REMOÇÃO ===");

            Console.Write("\tInsira o nome do produto para remover: ");
            string nomeParaRemover = Console.ReadLine();

            bool response = hashSet.Remove(nomeParaRemover);
            Console.Write("\t\t" + nomeParaRemover + (response ? " removido com sucesso" : " não encontrado para ser removido"));

            ListagemDados(hashSet, "HASHSET 1");
        }

        public static void EncontrarProdutosEmComum(HashSet<string> hashSet1, HashSet<string> hashSet2)
        {
            Console.WriteLine("\n\n=== PRODUTOS EM COMUM ===");

            Console.Write("\t");

            hashSet1.IntersectWith(hashSet2);

            foreach (string value in hashSet1)
            {
                Console.Write(value + ", ");
            }
        }

        public static void JuntarProdutos(HashSet<string> hashSet1, HashSet<string> hashSet2)
        {
            Console.WriteLine("\n\n=== JUNTAR PRODUTOS ===");

            Console.Write("\t");

            hashSet1.UnionWith(hashSet2);

            foreach (string value in hashSet1)
            {
                Console.Write(value + ", ");
            }
        }

        public static void SubtrairConjunto(HashSet<string> hashSet1, HashSet<string> hashSet2)
        {
            Console.WriteLine("\n\n=== SUBTRAIR CONJUNTO ===");

            Console.Write("\t");

            hashSet1.ExceptWith(hashSet2);

            foreach (string value in hashSet1)
            {
                Console.Write(value + ", ");
            }
        }

        public static void VerSeCOonjunto1EstaContidoNoConjunto2(HashSet<string> hashSet1, HashSet<string> hashSet2)
        {
            Console.Write("\n\n\tConjunto 1 " + (hashSet1.IsSubsetOf(hashSet2) ? "" : " não") + " está contido no conjunto 2");
        }

        public static void VerSeCOonjunto1ContemConjunto2(HashSet<string> hashSet1, HashSet<string> hashSet2)
        {
            Console.Write("\n\n\tConjunto 1 " + (hashSet1.IsSupersetOf(hashSet2) ? "" : " não") + " contem no conjunto 2");
        }

        public static HashSet<string> Clonar(HashSet<string> hashSet)
        {
            HashSet<string> newHashSet = new HashSet<string>();

            foreach (string value in hashSet)
            {
                newHashSet.Add(value);
            }

            return newHashSet;
        }

        public static void ListagemDados(HashSet<string> hashSet, string text)
        {
            Console.WriteLine("\n\n\t\t\t=== LISTAGEM " + text + " ===");

            foreach (string value in hashSet)
            {
                Console.WriteLine("\t\t\t\t" + value);
            }
            Console.WriteLine("\n\n");
        }
    }
}
