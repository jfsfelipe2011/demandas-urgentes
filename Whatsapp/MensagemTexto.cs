namespace demandas_urgentes.Whatsapp
{
    class MensagemTexto : Mensagem
    {
        public int NumeroCaracters { get; set; }

        public MensagemTexto(
            Contatinho destinatario,
            string horaEnvio,
            string conteudo) : base(destinatario, horaEnvio, conteudo)
        {
            this.calculaNumeroCaracteres();
        }

        public override string ToString()
        {
            return this.Destinatario.Nome + "\n" + this.Conteudo + " " + this.HoraEnvio;
        }

        private void calculaNumeroCaracteres()
        {
            this.NumeroCaracters = this.Conteudo.Length;
        }
    }
}
