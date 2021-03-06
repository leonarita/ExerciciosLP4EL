using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class Retangulo : Forma, ICalcularArea
    {
        public double Altura { set; get; }
        public double Base { set; get; }

        public Retangulo(string Cor, double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;

            double Area = CalcularArea();
            ConfigurarCor(Cor);

            Console.WriteLine("\t\t\t\t\t\tRetângulo " + Cor + " tem " + Area + " metros quadrados");
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
