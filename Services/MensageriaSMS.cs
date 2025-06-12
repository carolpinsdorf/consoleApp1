using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meuConsoleApp1.Services
{
    public class MensageriaSMS
    {
         // metodo para enviar mensagem 
        public bool EnviarMensagem(string texto)
        {
            // Simula o envio de uma mensagem
            Console.WriteLine($"Enviando mensagem: " + texto);
            return true; // Retorna verdadeiro se a mensagem foi enviada com sucesso
        }
    }
}