using System.Collections.Generic;

namespace demandas_urgentes.Whatsapp
{
    class Contatinho
    {
        public string Nome { get; set; }
        public string Celular { get; set; }

        public List<Mensagem> Mensagens { get; }

        public Contatinho(string nome, string celular)
        {
            this.Nome      = nome;
            this.Celular   = celular;
            this.Mensagens = new List<Mensagem>();
        }

        public void AdicionaMensagem(Mensagem mensagem)
        {
            this.Mensagens.Add(mensagem);
        }
    }
}
