namespace demandas_urgentes.Whatsapp
{
    class MensagemAudio : Mensagem
    {
        public int Duracao { get; set; }

        public MensagemAudio(
            Contatinho destinatario,
            string horaEnvio,
            string conteudo) : base(destinatario, horaEnvio, conteudo)
        {
            this.CalculaDuracao();
        }

        public override string ToString()
        {
            return this.Destinatario.Nome + "\nPlay: " + this.Duracao + " " + this.Conteudo + " " + this.HoraEnvio;
        }

        private void CalculaDuracao()
        {
            // Deveria calcular a duração pelo conteudo
            this.Duracao = 60;
        }
    }
}
