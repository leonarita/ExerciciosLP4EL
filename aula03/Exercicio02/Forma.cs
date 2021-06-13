using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    public abstract class Forma
    {
        public string Cor { set; get; }

        public abstract double CalcularArea();

        public virtual void ConfigurarCor(string Cor)
        {
            this.Cor = Cor;
        }
    }

}
