namespace demandas_urgentes.Banco
{
    abstract class Conta
    {
        public Pessoa Titular { get; set; }
        public long Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; set; }
        public double TaxaSaque { get; set; }

        public Conta(Pessoa titular, long numero, int agencia)
        {
            this.Titular = titular;
            Numero       = numero;
            Agencia      = agencia;
            Saldo        = 0;
        }

        public virtual double ConsultarSaldo()
        {
            return this.Saldo;
        }

        public abstract void Sacar(double valor);
        public abstract void Transferir(Conta conta, double valor);
    }
}