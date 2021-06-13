using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    class Circulo : Forma, ICalcularArea
    {
        public double Raio { set; get; }

        public Circulo(string Cor, double Raio)
        {
            this.Raio = Raio;

            double Area = CalcularArea();
            ConfigurarCor(Cor);

            Console.WriteLine("\t\t\t\t\t\tCírculo " + Cor + " tem " + Area + " metros quadrados");
        }

        public double CalcularArea()
        {
            return 3.14 * Raio * Raio;
        }
    }
}
