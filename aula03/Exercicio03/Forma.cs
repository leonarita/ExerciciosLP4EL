using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    public interface IForma
    {
        public string Cor { set; get; }

        public abstract double CalcularArea();

        public void ConfigurarCor(string Cor);
    }

}
