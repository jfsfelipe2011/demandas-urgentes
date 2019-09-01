namespace demandas_urgentes.FormasGeometricas
{
    abstract class Figura
    {
        public string Cor { get; set; }

        public Figura() {}

        public Figura(string cor) 
        {
            this.Cor = cor;
        }

        public abstract double Area();
    }
}
