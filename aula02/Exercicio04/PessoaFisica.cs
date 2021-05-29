using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class PessoaFisica : Cliente
    {
        private string Nome;
        private string Cpf;

        public PessoaFisica()
        {

        }

        public PessoaFisica(int Codigo, string Endereco, string Telefone, string Nome, string Cpf)
        {            
            base.SetCodigo(Codigo);
            base.SetEndereco(Endereco);
            base.SetTelefone(Telefone);

            this.Nome = Nome;
            this.Cpf = Cpf;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        protected string GetCpf()
        {
            return this.Cpf;
        }

        protected void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        protected void SetCpf(string Cpf)
        {
            this.Cpf = Cpf;
        }

        public override string ToString()
        {
            return "Codigo: " + GetCodigo() + "\tEndereço: " + GetEndereco() + "\tTelefone: " + GetTelefone() + "\tNome: " + Nome + "\tCPF: " + Cpf;
        }
    }
}
