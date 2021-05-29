using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Cliente
    {
        private int Codigo;
        private string Endereco;
        private string Telefone;

        public Cliente(int? Codigo = 0, string Endereco = "", string Telefone = "")
        {
            this.Codigo = Codigo ?? 0;
            this.Endereco = Endereco;
            this.Telefone = Telefone;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        protected string GetEndereco()
        {
            return Endereco;
        }

        protected string GetTelefone()
        {
            return Telefone;
        }

        protected void SetCodigo(int Codigo)
        {
            this.Codigo = Codigo;
        }

        protected void SetEndereco(string Endereco)
        {
            this.Endereco = Endereco;
        }

        protected void SetTelefone(string Telefone)
        {
            this.Telefone = Telefone;
        }
    }
}
