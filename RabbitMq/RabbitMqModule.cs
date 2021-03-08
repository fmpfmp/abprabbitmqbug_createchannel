using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;
using Volo.Abp.RabbitMQ;

namespace X.RabbitMq
{
	[DependsOn(typeof(AbpRabbitMqModule))]
	public class RabbitMqModule : AbpModule
	{
		public override void ConfigureServices(ServiceConfigurationContext context)
		{
			var configuration = context.Services.GetConfiguration();

			Configure<RabbitMqOption>(configuration.GetSection("RabbitMQ"));
		}
	}
}
