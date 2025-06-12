using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File: Mensageria.cs
namespace meuConsoleApp1.Resources
{
    public class Mensageria
    {
        public string? Nome { get; set; }
        public string? Mensagem { get; set; }

        public Mensageria(string nome, string mensagem)
        {
            Nome = nome;
            Mensagem = mensagem;
        }

        public override string ToString()
        {
            return $"{Nome}: {Mensagem}";
        }

        // metodo para enviar mensagem 
        public bool EnviarMensagem()
        {
            // Simula o envio de uma mensagem
            Console.WriteLine($"Enviando mensagem: {Mensagem} para {Nome}");
            return true; // Retorna verdadeiro se a mensagem foi enviada com sucesso
        }
    }

}
