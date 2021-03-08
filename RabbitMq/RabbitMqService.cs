using Microsoft.Extensions.Options;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.RabbitMQ;

namespace X.RabbitMq
{
	public class RabbitMqService : ITransientDependency
	{
		protected RabbitMqOption RabbitMqOptions { get; }
		protected IRabbitMqMessageConsumerFactory MessageConsumerFactory { get; }
		protected IRabbitMqMessageConsumer Consumer { get; private set; }
		protected static object Lock { get; } = new object();

		public RabbitMqService(
			IOptions<RabbitMqOption> options,
			IRabbitMqMessageConsumerFactory messageConsumerFactory
			)
		{
			MessageConsumerFactory = messageConsumerFactory;
			RabbitMqOptions = options.Value;
		}

		public Task ConsumeAsync(string queueName, string routingKey, string exchangeName, Func<IModel, BasicDeliverEventArgs, Task> callback)
		{
			var exchange = RabbitMqOptions.Exchanges.Single(o => o.ExchangeName == exchangeName);

				Consumer = MessageConsumerFactory.Create(
					new ExchangeDeclareConfiguration(exchange.ExchangeName, type: exchange.ExchangeType, durable: true),
					new QueueDeclareConfiguration(queueName, durable: true, exclusive: false, autoDelete: false),
					exchange.ConnectionName
				);

			Consumer.BindAsync(routingKey);

			Consumer.OnMessageReceived(callback);

			return Task.CompletedTask;
		}	
	}
}
