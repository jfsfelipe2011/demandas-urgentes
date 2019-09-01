namespace demandas_urgentes.Banco
{
    abstract class Pessoa
    {
        public int NumeroDePessoas { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public double Rendimento { get; set; }

        public Pessoa(int id, string endereco, string telefone, string email)
        {
            this.Id       = id;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email    = email;

            this.IncrementaNumeroDePessoas();
        }

        private void IncrementaNumeroDePessoas()
        {
            if (this.NumeroDePessoas == 0)
            {
                this.NumeroDePessoas = 1;
            }
            else
            {
                this.NumeroDePessoas++;
            }
        }

        public abstract int CalculaIdade();

        public virtual string TransformaIdadeEmFaixaEtaria(int idade)
        {
            if (idade <= 11)
            {
                return "criança";
            }
            else if (idade <= 21)
            {
                return "jovem";
            }
            else if (idade <= 59)
            {
                return "adulto";
            }

            return "idoso";
        }
    }
}
