using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class Cliente
    {
        private int codigo;
        private string nome;
        private string cpf;

        public Cliente()
        {

        }

        public Cliente(int codigo, string nome, string cpf)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
        }

        public int GetCodigo()
        {
            return codigo;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCpf()
        {
            return this.cpf;
        }

        public bool SetCodigo(int codigo)
        {
            this.codigo = codigo;
            return true;
        }

        public bool SetNome(string nome)
        {
            if (!nome.Contains(" "))
                return false;

            this.nome = nome;
            return true;
        }

        public bool SetCpf(string cpf)
        {
            if (cpf.Length != 11)
                return false;

            this.cpf = cpf;
            return true;
        }

        public override string ToString()
        {
            return "Codigo: " + GetCodigo() + "\tNome: " + GetNome() + "\tCPF: " + GetCpf();
        }
    }
}
