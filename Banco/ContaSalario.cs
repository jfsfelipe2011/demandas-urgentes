namespace demandas_urgentes.Banco
{
    class ContaSalario : Conta
    {
        public ContaSalario(
            Pessoa titular,
            long numero,
            int agencia) : base(titular, numero, agencia)
        {
            this.TaxaSaque = 0;
        }

        public override void Sacar(double valor)
        {
            if (this.Saldo - valor < 0)
            {
                throw new System.Exception("Você não tem fundos suficientes para esse saque!");
            }

            this.Saldo -= valor;
        }

        public override void Transferir(Conta conta, double valor)
        {
            if (conta.Titular.Id != this.Titular.Id)
            {
                throw new System.Exception("A conta informada não é do mesmo titular!");
            }

            if (this.Saldo - valor < 0)
            {
                throw new System.Exception("Você não tem fundos suficientes para essa transferência!");
            }

            this.Saldo  -= valor;
            conta.Saldo += valor;
        }
    }
}