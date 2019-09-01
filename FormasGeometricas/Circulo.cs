using System;

namespace demandas_urgentes.FormasGeometricas
{
    class Circulo : Figura
    {
        public const double Pi = 3.14;

        public double Raio { get; set; }

        public Circulo(double raio, string cor): base(cor) {
            this.Raio = raio;
        }

        public override double Area()
        {
            return Circulo.Pi * Math.Pow(this.Raio, 2);
        }
    }
}
