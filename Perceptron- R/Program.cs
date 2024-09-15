using System;
using System.Collections.Generic;
using RedeNeuralSimples;

class Programa
{
    static void Main(string[] args)
    {
        double taxaAprendizado = 0.7;
        double pesoInicial1 = 0.6;
        double pesoInicial2 = 0.2;

        // Lista de exemplos extraídos da planilha
        List<Exemplo> exemplos = new List<Exemplo>
        {
            new Exemplo(113, 6.8, 0),  // Maçã
            new Exemplo(122, 4.7, 1),  // Laranja
            new Exemplo(107, 5.2, 0),  // Maçã
            new Exemplo(98, 3.6, 0),   // Maçã
            new Exemplo(115, 2.9, 1),  // Laranja
            new Exemplo(120, 4.2, 1)   // Laranja
        };

        // Inicialização do perceptron com pesos iniciais e taxa de aprendizado
        RedePerceptron rede = new RedePerceptron(taxaAprendizado, pesoInicial1, pesoInicial2);

        // Início do treinamento do modelo
        rede.Treinar(exemplos, 5000);

        Console.WriteLine("Pesos após o treinamento:");
        Console.WriteLine($"Peso 1: {rede.Pesos.Peso1:F4}");
        Console.WriteLine($"Peso 2: {rede.Pesos.Peso2:F4}");

        // Classificação dos exemplos
        Console.WriteLine("\nClassificação das amostras:");
        foreach (var exemplo in exemplos)
        {
            var resultado = rede.Classificar(exemplo.Caracteristica1, exemplo.Caracteristica2);
            Console.WriteLine($"Exemplo ({exemplo.Caracteristica1}, {exemplo.Caracteristica2}): " +
                (resultado == 1 ? "Maçã" : "Laranja"));
        }
    }
}
