using System;

namespace RequestRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string opt;
            Fanoutmessages fanoutmessages = new Fanoutmessages();
            do
            {
                Console.WriteLine("\n\nEnviar mensagem?");
                opt = Console.ReadLine();
                if ((opt == "Sim") || (opt == "sim"))
                    fanoutmessages.SendMessage();
                else
                    Environment.Exit(0);
            } while (true);
            
            Console.ReadLine();
        }
    }
}