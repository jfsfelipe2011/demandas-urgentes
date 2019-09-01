using System;

namespace demandas_urgentes.Banco
{
    class PessoaFisica : Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public int Idade { get; private set; }
        public string FaixaEtaria { get; private set; }
        public double Renda { get; private set;}

        public PessoaFisica(
            int id,
            string endereco,
            string telefone,
            string email,
            string nome,
            string sobrenome,
            string RG,
            string CPF,
            DateTime dataNasc) : base(id, endereco, telefone, email)
        {
            this.Nome      = nome;
            this.Sobrenome = sobrenome;
            this.RG        = RG;
            this.CPF       = CPF;
            this.DataNasc  = dataNasc;

            this.Idade       = this.CalculaIdade();
            this.FaixaEtaria = this.TransformaIdadeEmFaixaEtaria(this.Idade);

            // Como não tinha nenhuma regra para calculo de renda, coloquei um valor qualquer
            this.Renda      = 2000.00;
            this.Rendimento = this.Renda;
        }

        public override int CalculaIdade()
        {
            DateTime hoje = DateTime.Now;

            return hoje.Year - this.DataNasc.Year;
        }
    }
}