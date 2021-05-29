using System;

namespace Exercicio01
{
    class Inicio
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.Write("Insira o código: ");
            produto.SetCodigo(ulong.Parse(Console.ReadLine()));

            Console.Write("Insira a descrição: ");
            produto.SetDescricao(Console.ReadLine());

            Console.Write("Insira o preço: ");
            produto.SetPreco(decimal.Parse(Console.ReadLine()));

            Console.Write("Insira se está ativo (S/N): ");
            produto.SetAtivo(Console.ReadLine().ToUpper().Contains("S") ? true : false);

            Console.WriteLine("\n\n\tO produto " + produto.GetDescricao() + ", cujo código é " + produto.GetCodigo() + ", custa R$ " 
                + produto.GetPreco() + " e " + (produto.EstaAtivo() ? "" : "não ") + "está ativo");

            Console.ReadKey();
        }
    }

    class Produto
    {
        private ulong Codigo;
        private string Descricao;
        private decimal Preco;
        private bool Ativo;

        public ulong GetCodigo()
        {
            return this.Codigo;
        }

        public string GetDescricao()
        {
            return this.Descricao;
        }

        public decimal GetPreco()
        {
            return this.Preco;
        }

        public bool EstaAtivo()
        {
            return this.Ativo;
        }

        public void SetCodigo(ulong Codigo)
        {
            this.Codigo = Codigo;
        }

        public void SetDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }

        public void SetPreco(decimal Preco)
        {
            this.Preco = Preco;
        }

        public void SetAtivo(bool Ativo)
        {
            this.Ativo = Ativo;
        }

        public void ToogleAtivo()
        {
            this.Ativo = !this.Ativo;
        }
    }
}
