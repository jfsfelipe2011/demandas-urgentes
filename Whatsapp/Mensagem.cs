namespace demandas_urgentes.Whatsapp
{
    abstract class Mensagem
    {
        public Contatinho Destinatario { get; set;}
        public string HoraEnvio { get; set; }
        public string Conteudo { get; set; }
    
        public Mensagem(Contatinho destinatario, string horaEnvio, string conteudo)
        {
            this.Destinatario = destinatario;
            this.HoraEnvio    = horaEnvio;
            this.Conteudo     = conteudo;
        }
    }
}
