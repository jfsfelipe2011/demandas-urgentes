namespace demandas_urgentes.FormasGeometricas
{
    class Triangulo : Figura
    {
        public double BaseTriangulo { get; set; }
        public double Altura { get; set; }

        public Triangulo(double baseTriangulo, double altura, string cor): base(cor) {
            this.BaseTriangulo = baseTriangulo;
            this.Altura        = altura;
        }

        public override double Area()
        {
            return (this.BaseTriangulo * this.Altura) / 2;
        }
    }
}
