namespace demandas_urgentes.FormasGeometricas
{
    class Quadrado : Figura
    {
        public double Lado { get; set; }

        public Quadrado(double lado, string cor): base(cor) {
            this.Lado = lado;
        }

        public override double Area()
        {
            return this.Lado * this.Lado;
        }
    }
}
