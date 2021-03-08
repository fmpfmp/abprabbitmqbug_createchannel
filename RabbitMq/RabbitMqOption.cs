using System.Collections.Generic;
using Volo.Abp.RabbitMQ;

namespace X.RabbitMq
{
	public class RabbitMqOption
	{
		public RabbitMqConnections Connections { get; }

		public List<RabbitMqExchange> Exchanges { get; set; }
	}

	public class RabbitMqExchange
	{
		public string ConnectionName { get; set; }

		public string ExchangeName { get; set; }

		public string ExchangeType { get; set; }
	}
}
