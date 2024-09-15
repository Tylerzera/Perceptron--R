using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralSimples
{
    public class ConjuntoPesos
    {
        public ConjuntoPesos(double pesoInicial1, double pesoInicial2)
        {
            Peso1 = pesoInicial1;
            Peso2 = pesoInicial2;
        }

        public double Peso1 { get; private set; }
        public double Peso2 { get; private set; }

        public void Definir(double novoPeso1, double novoPeso2)
        {
            Peso1 = novoPeso1;
            Peso2 = novoPeso2;
        }
    }
}