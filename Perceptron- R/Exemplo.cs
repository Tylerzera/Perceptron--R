namespace RedeNeuralSimples
{
    public class Exemplo
    {
        public Exemplo(double caracteristica1, double caracteristica2, int classeEsperada)
        {
            Caracteristica1 = caracteristica1;
            Caracteristica2 = caracteristica2;
            ClasseEsperada = classeEsperada;
        }

        public double Caracteristica1 { get; private set; }
        public double Caracteristica2 { get; private set; }
        public int ClasseEsperada { get; private set; }
    }
}