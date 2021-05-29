using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class PessoaJuridica : Cliente
    {
		private string RazaoSocial;
		private string Cnpj;

		public PessoaJuridica()
        {

        }

		public PessoaJuridica(int Codigo, string Endereco, string Telefone, string RazaoSocial, string Cnpj)
		{
			base.SetCodigo(Codigo);
			base.SetEndereco(Endereco);
			base.SetTelefone(Telefone);

			this.RazaoSocial = RazaoSocial;
			this.Cnpj = Cnpj;
		}

		public string GetRazaoSocial()
		{
			return this.RazaoSocial;
		}

		public void SetRazaoSocial(string RazaoSocial)
		{
			this.RazaoSocial = RazaoSocial;
		}

		public string GetCnpj()
		{
			return this.Cnpj;
		}

		public void SetCnpj(string Cnpj)
		{
			this.Cnpj = Cnpj;
		}

		public override string ToString()
		{
			return "Codigo: " + GetCodigo() + "\tEndereço: " + GetEndereco() + "\tTelefone: " + GetTelefone() + "\tRazão Social: " + RazaoSocial + "\tCNPJ: " + Cnpj;
		}
	}
}
