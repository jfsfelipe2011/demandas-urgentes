using System;
using System.Collections.Generic;
using demandas_urgentes.Banco;
using demandas_urgentes.FormasGeometricas;
using demandas_urgentes.Whatsapp;

namespace demandas_urgentes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso das classes de Formas Geometricas
            Quadrado quadrado = new Quadrado(5, "vermelho");
            Console.WriteLine(quadrado.Area());
            
            Triangulo triangulo = new Triangulo(10, 5, "azul");
            Console.WriteLine(triangulo.Area());

            Circulo circulo = new Circulo(2, "verde");
            Console.WriteLine(circulo.Area());

            // Uso das classes de Whatsapp
            Contatinho contatinho1 = new Contatinho("Maria", "51 99892838");
            Contatinho contatinho2 = new Contatinho("Helio", "51 99553721");
            Contatinho contatinho3 = new Contatinho("Mara", "51 99553666");

            WhatsappCore whatsapp = new WhatsappCore();

            whatsapp.AdicionaContato(contatinho1);
            whatsapp.AdicionaContato(contatinho2);
            whatsapp.AdicionaContato(contatinho3);

            whatsapp.AdicionaMensagens(new MensagemTexto(contatinho1, "00:18", "Oi sumido!!"));
            whatsapp.AdicionaMensagens(new MensagemFoto(contatinho1, "00:30", "nudes.jpg"));
            whatsapp.AdicionaMensagens(new MensagemAudio(contatinho1, "07:00", "Desculpa, estava bêbado ontem."));

            Console.WriteLine(whatsapp.ListarContatos());
            Console.WriteLine(whatsapp.ListarMensagens("Maria"));

            // Uso das classes de Banco
            PessoaFisica pessoaFisica1 = new PessoaFisica(
                1,
                "Avenida Brasil, 1200",
                "51 98764320",
                "hermes@email.com",
                "Hermes",
                "Dos Santos",
                "25416278932",
                "98723451687",
                new DateTime(1989, 07, 18)
            );

            PessoaFisica pessoaFisica2 = new PessoaFisica(
                2,
                "Avenida Borges de Medeiros, 320",
                "51 98224325",
                "luiz@email.com",
                "Luiz",
                "Ferreira",
                "15226274936",
                "98732451333",
                new DateTime(1945, 02, 11)
            );

            PessoaFisica pessoaFisica3 = new PessoaFisica(
                3,
                "Avenida Magalhães, 320",
                "51 92364120",
                "luisa@email.com",
                "Luisa",
                "Da Silva",
                "25423478112",
                "12323444687",
                new DateTime(1999, 12, 05)
            );

            PessoaFisica pessoaFisica4 = new PessoaFisica(
                4,
                "Avenida Valência, 2000",
                "51 98774122",
                "maicon@email.com",
                "Maicon",
                "Figueira",
                "25226233932",
                "98124451587",
                new DateTime(2007, 01, 01)
            );

            List<PessoaFisica> pessoas = new List<PessoaFisica>();
            pessoas.Add(pessoaFisica1);
            pessoas.Add(pessoaFisica2);

            PessoaJuridica pessoaJuridica = new PessoaJuridica(
                5,
                "Avenida Cristovão Colombo, 2233",
                "51 92887022",
                "empresa@email.com",
                pessoas,
                "230122578000129",
                "Empresa Ltda",
                "Empresa Super Boa",
                000929200,
                new DateTime(2015, 11, 20)
            );

            ContaPoupanca contaPoupanca = new ContaPoupanca(
                pessoaFisica1,
                1,
                1
            );

            ContaSalario contaSalario = new ContaSalario(
                pessoaFisica4,
                2,
                1
            );

            ContaPoupanca contaPoupanca1 = new ContaPoupanca(
                pessoaFisica4,
                3,
                1
            );

            ContaCorrente contaCorrente = new ContaCorrente(
                pessoaFisica3,
                4,
                1
            );

            ContaCorrente contaCorrente1 = new ContaCorrente(
                pessoaJuridica,
                5,
                1
            );

            try {
                contaPoupanca.Depositar(1000.00);
                contaPoupanca.Sacar(500.00);
                contaPoupanca.Transferir(contaSalario, 200.00);

                Console.WriteLine(contaPoupanca.ConsultarSaldo());

                contaSalario.Sacar(100);
                contaSalario.Transferir(contaPoupanca1, 50);

                Console.WriteLine(contaSalario.ConsultarSaldo());

                contaCorrente.Sacar(1000);
                contaCorrente.Pagar("23790.50400 41990.901179 31008.109204 1 80020000020000");
                contaCorrente.Emprestimo(3000);

                Console.WriteLine(contaCorrente.ConsultarSaldo());
                Console.WriteLine(contaCorrente.Limite);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
