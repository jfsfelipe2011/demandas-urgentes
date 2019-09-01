using System;
using System.Collections.Generic;

namespace demandas_urgentes.Banco
{
    class PessoaJuridica : Pessoa
    {
        public List<PessoaFisica> Socios { get; set; }
        public int CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public int InscricaoEstadual { get; set; }
        public DateTime DataAbertura { get; set; }
        public int Idade { get; private set; }
        public double Faturamento { get; private set; }

        public PessoaJuridica(
            int id,
            string endereco,
            string telefone,
            string email,
            List<PessoaFisica> socios,
            string CNPJ,
            string razaoSocial,
            string nomeFantasia,
            int inscricaoEstadual,
            DateTime dataAbertura) : base(id, endereco, telefone, email)
        {
            this.Socios            = socios;
            this.RazaoSocial       = razaoSocial;
            this.NomeFantasia      = nomeFantasia;
            this.InscricaoEstadual = inscricaoEstadual;
            this.DataAbertura      = dataAbertura;

            this.Idade = this.CalculaIdade();

            // Como não tinha nenhuma regra para calculo de faturamento, coloquei um valor qualquer
            this.Faturamento = 10000.00;
            this.Rendimento  = this.Faturamento;
        }

        public override int CalculaIdade()
        {
            DateTime hoje = DateTime.Now;

            return hoje.Year - this.DataAbertura.Year;
        }
    }
}