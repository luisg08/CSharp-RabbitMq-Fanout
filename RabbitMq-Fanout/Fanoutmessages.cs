using System;
using RabbitMQ.Client;
using System.Text;

namespace RequestRabbitMQ
{
    public class Fanoutmessages
    {
        /*private const string UName = "guest";
        private const string PWD = "guest";
        private const string HName = "localhost";*/

        public void SendMessage()
        {
            //Main entry point to the RabbitMQ .NET AMQP client
            var connectionFactory = new ConnectionFactory();

            connectionFactory.Uri = new Uri("amqps://");
            connectionFactory.AutomaticRecoveryEnabled = true;

            var connection = connectionFactory.CreateConnection();
            var model = connection.CreateModel();
            var properties = model.CreateBasicProperties();

            properties.Persistent = false;
            byte[] messagebuffer = Encoding.Default.GetBytes("Mensagem para exchange do tipo Fanout");

            model.BasicPublish("fanout.exchange", "", properties, messagebuffer);
            Console.WriteLine("\nRabbitMq Fanout.");
            Console.WriteLine("Mensagem enviada para todas as filas");
        }
    }
}
