using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeNeuralSimples
{
    public class RedePerceptron
    {
        public ConjuntoPesos Pesos { get; private set; }

        public double SaidaAtual { get; private set; }

        public double TaxaAprendizado { get; private set; }

        public RedePerceptron(double taxaAprendizado, double pesoInicial1, double pesoInicial2)
        {
            SaidaAtual = 0.0;
            TaxaAprendizado = taxaAprendizado;
            Pesos = new ConjuntoPesos(pesoInicial1, pesoInicial2);
        }

        public void Treinar(List<Exemplo> exemplos, int epocasMaximas)
        {
            for (int epoca = 0; epoca < epocasMaximas; epoca++)
            {
                foreach (var exemplo in exemplos)
                {
                    SaidaAtual = exemplo.Caracteristica1 * Pesos.Peso1
                        + exemplo.Caracteristica2 * Pesos.Peso2;
                    if (DeterminarClasse(SaidaAtual) != exemplo.ClasseEsperada)
                    {
                        double erro = exemplo.ClasseEsperada - DeterminarClasse(SaidaAtual);
                        AtualizarPesos(erro, exemplo);
                    }
                }
            }
        }

        private int DeterminarClasse(double saida)
        {
            return saida >= 0 ? 1 : 0;
        }

        private void AtualizarPesos(double erro, Exemplo exemplo)
        {
            double novoPeso1 = Pesos.Peso1 + TaxaAprendizado * erro * exemplo.Caracteristica1;
            double novoPeso2 = Pesos.Peso2 + TaxaAprendizado * erro * exemplo.Caracteristica2;
            Pesos.Definir(novoPeso1, novoPeso2);
        }

        public int Classificar(double valor1, double valor2)
        {
            double saidaCalculada = valor1 * Pesos.Peso1 + valor2 * Pesos.Peso2;
            return DeterminarClasse(saidaCalculada);
        }
    }
}

