using System.Collections.Generic;

namespace demandas_urgentes.Whatsapp
{
    class WhatsappCore
    {
        public List<Contatinho> Contatos;

        public WhatsappCore()
        {
            this.Contatos  = new List<Contatinho>();
        }

        public void AdicionaContato(Contatinho contato)
        {
            this.Contatos.Add(contato);
        }

        public void RemoveContrato(Contatinho contato)
        {
            this.Contatos.Remove(contato);
        }

        public string ListarContatos()
        {
            if (this.Contatos.Count == 0) {
                return "Nenhum contato adicionado";
            }

            return this.MontaListaDeContatos();
        }

        private string MontaListaDeContatos()
        {
            string resultado = "Contatos\n\n";

            foreach (Contatinho contato in this.Contatos)
            {
                resultado += contato.Nome + " " + contato.Celular + "\n";
            }

            return resultado;
        }

        public void AdicionaMensagens(Mensagem mensagem)
        {
            Contatinho contatinho = mensagem.Destinatario;
            contatinho.AdicionaMensagem(mensagem);
        }

        public string ListarMensagens(string nome)
        {
            Contatinho contatinho = this.Contatos.Find(
                delegate (Contatinho contato)
                {
                    return contato.Nome == nome;
                }
            );

            if (contatinho != null) 
            {
                return this.MontaListaDeMensagens(contatinho);
            }

            return "Contato não encontrado!";
        }

        private string MontaListaDeMensagens(Contatinho contatinho)
        {
            if (contatinho.Mensagens.Count == 0)
            {
                return "Não existem mensagens desse contato";
            }

            string resultado = "";

            resultado += "Mensagens de " + contatinho.Nome + "\n\n";

            foreach (Mensagem mensagem in contatinho.Mensagens)
            {
                resultado += mensagem.ToString() + "\n";
            }

            return resultado;
        }
    }
}
