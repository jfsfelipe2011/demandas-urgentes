namespace demandas_urgentes.Banco
{
    class ContaPoupanca : Conta, Depositavel
    {
        public ContaPoupanca(
            Pessoa titular,
            long numero,
            int agencia) : base(titular, numero, agencia)
        {
            this.TaxaSaque = 1.20;
        }

        public override void Sacar(double valor)
        {
            double valorComTaxa = valor + this.TaxaSaque;

            if (this.Saldo - valorComTaxa < 0)
            {
                throw new System.Exception("Você não tem fundos suficientes para esse saque!");
            }

            this.Saldo -= valorComTaxa;
        }

        public override void Transferir(Conta conta, double valor)
        {
            if (this.Saldo - valor < 0)
            {
                throw new System.Exception("Você não tem fundos suficientes para essa transferência!");
            }

            this.Saldo  -= valor;
            conta.Saldo += valor;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
    }
}