using System;

namespace demandas_urgentes.Banco
{
    class ContaCorrente : Conta, Depositavel
    {
        public string Tipo { get; private set; }
        public double Limite { get; private set; }
        public double TaxaDoLimite { get; private set; }

        public ContaCorrente(
            Pessoa titular,
            long numero,
            int agencia) : base(titular, numero, agencia)
        {
            this.GerarTipoDeConta();
            this.CalcularLimite();
            this.GerarTaxaDoLimite();
        }

        private void GerarTipoDeConta()
        {
            if (Titular.Rendimento > 5000)
            {
                this.Tipo = "especial";
            }
            else
            {
                this.Tipo = "simples";
            }
        }

        private void CalcularLimite()
        {
            if (Tipo.Equals("especial"))
            {
                this.Limite = Titular.Rendimento * 2.5;
            }
            else
            {
                this.Limite = Titular.Rendimento * 1.5;
            }
        }

        private void GerarTaxaDoLimite()
        {
            if (Tipo.Equals("especial"))
            {
                this.TaxaDoLimite = 2;
            }
            else
            {
                this.TaxaDoLimite = 5;
            }
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (this.Saldo - valor < 0)
            {
                double valorMaisTaxa = valor + ((valor * this.TaxaDoLimite) / 100);

                if (this.Limite - valorMaisTaxa < 0)
                {
                    throw new System.Exception("Você não tem fundos suficientes para esse saque!");
                }

                valor = valorMaisTaxa;
            }

            this.Saldo  -= valor;
        }

        public override void Transferir(Conta conta, double valor)
        {
            if (this.Saldo - valor < 0)
            {
                double valorMaisTaxa = valor + ((valor * this.TaxaDoLimite) / 100);

                if (this.Limite - valorMaisTaxa < 0)
                {
                    throw new System.Exception("Você não tem fundos suficientes para essa transferência!");
                }

                valor = valorMaisTaxa;
            }

            this.Saldo  -= valor;
            conta.Saldo += valor;
        }

        public void Pagar(string codigoBarras)
        {
            double valor = Double.Parse(codigoBarras.Substring(44));

            this.Saldo -= valor / 100;
        }

        public void Emprestimo(double valor)
        {
            // Como não tem nenhuma regra para o emprestimo, está liberado para qualquer coisa.
            this.Saldo += valor;
        }
    }
}