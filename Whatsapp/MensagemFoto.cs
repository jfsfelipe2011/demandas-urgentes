namespace demandas_urgentes.Whatsapp
{
    class MensagemFoto : Mensagem
    {
        public int TamanhoFoto { get; set; }

        public MensagemFoto(
            Contatinho destinatario,
            string horaEnvio,
            string conteudo) : base(destinatario, horaEnvio, conteudo)
        {
            this.CalculaTamanhoFoto();
        }

        public override string ToString()
        {
            return this.Destinatario.Nome + "\nFoto: " + this.Conteudo + " " + this.HoraEnvio;
        }

        private void CalculaTamanhoFoto()
        {
            // Deveria calcular o tamanho da foto pelo conteudo
            this.TamanhoFoto = 120;
        }
    }
}
