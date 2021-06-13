using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    public abstract class Forma
    {
        public string Cor { set; get; }


        public virtual void ConfigurarCor(string Cor)
        {
            this.Cor = Cor;
        }
    }

    public interface ICalcularArea
    {
        public double CalcularArea();
    }

}
