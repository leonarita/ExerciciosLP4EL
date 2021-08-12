using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> lista = new List<string>();
            Stack<String> pilha = new Stack<string>();
            Queue<string> fila = new Queue<string>();

            lista.Add("banana");
            lista.Add("abacaxi");
            lista.Add("maçã");
            lista.Add("mamão");
            lista.Add("pera");
            lista.Add("laranja");
            lista.RemoveAt(2);
            lista.Insert(lista.Count, "uva");
            lista.Remove("mamão");
            lista.Sort();

            foreach (string l in lista)
                pilha.Push(l);
            pilha.Pop();

            while (pilha.Count > 0)
            {
                fila.Enqueue(pilha.Peek());
                pilha.Pop();
            }

            while (fila.Count > 0)
            {
                Console.Write(fila.Peek() + ", ");
                fila.Dequeue();
            }

            Console.ReadKey();
        }
    }
}
