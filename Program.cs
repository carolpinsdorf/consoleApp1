// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using meuConsoleApp1.Resources;
using meuConsoleApp1.Services;


MensageriaSMS sms = new MensageriaSMS();
sms.EnviarMensagem("Mensagem de teste via SMS");

Mensageria msg = new Mensageria("João", "Olá, João! Esta é uma mensagem de teste.");