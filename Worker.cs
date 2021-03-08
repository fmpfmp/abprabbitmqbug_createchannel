using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Volo.Abp;
using X.RabbitMq;

namespace WorkerService2
{
	#region HostedService1
	public class HostedService1 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService1(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue1", "key1", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService2
	public class HostedService2 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService2(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue2", "key2", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService3
	public class HostedService3 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService3(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue3", "key3", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService4
	public class HostedService4 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService4(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue4", "key4", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService5
	public class HostedService5 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService5(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue5", "key5", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService6
	public class HostedService6 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService6(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue6", "key6", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService7
	public class HostedService7 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService7(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue7", "key7", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService8
	public class HostedService8 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService8(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue8", "key8", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService9
	public class HostedService9 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService9(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue9", "key9", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion


	#region HostedService0
	public class HostedService0 : IHostedService
	{
		private readonly IAbpApplicationWithExternalServiceProvider application;
		private readonly RabbitMqService rabbitMqService;

		public HostedService0(IAbpApplicationWithExternalServiceProvider application, RabbitMqService rabbitMqService)
		{
			this.application = application;
			this.rabbitMqService = rabbitMqService;
		}

		public async Task StartAsync(CancellationToken cancellationToken)
		{
			await rabbitMqService.ConsumeAsync("queue0", "key0", "exchangeName1", ConsumeTestAsync);
		}

		private Task ConsumeTestAsync(IModel channel, BasicDeliverEventArgs ea)
		{
			Console.WriteLine(DateTime.Now.ToString());

			return Task.CompletedTask;
		}


		public Task StopAsync(CancellationToken cancellationToken)
		{

			application.Shutdown();

			return Task.CompletedTask;
		}
	}
	#endregion
}
