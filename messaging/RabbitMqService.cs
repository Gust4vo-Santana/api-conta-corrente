using System;
using System.Text;
using RabbitMQ.Client;

namespace api_conta_corrente.Messaging {
    public class RabbitMQService : IDisposable {
        private readonly IConnection _connection;
        private readonly IModel _channel;

        private readonly ConnectionFactory _factory = new() { HostName = "rabbitmq" };

        public RabbitMQService() {
            try {
                _connection = _factory.CreateConnection();
                _channel = _connection.CreateModel();
            }
            catch (Exception ex) {
                Console.WriteLine($"Failed to create RabbitMQ connection: {ex.Message}");
                throw;
            }
        }

        public void Publish(string queueName, string message) {
            try {
                _channel.QueueDeclare(queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);

                var body = Encoding.UTF8.GetBytes(message);

                _channel.BasicPublish(exchange: "", routingKey: queueName, basicProperties: null, body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }
            catch (Exception ex) {
                Console.WriteLine($"Failed to publish message: {ex.Message}");
                throw;
            }
        }

        public void Dispose() {
            _channel?.Close();
            _connection?.Close();
        }
    }
}
