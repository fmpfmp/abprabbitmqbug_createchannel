using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using X.RabbitMq;

namespace WorkerService2
{
    [DependsOn(typeof(RabbitMqModule))]
	[DependsOn(typeof(AbpAspNetCoreMvcModule))]
	public class SampleModule : AbpModule
	{
		public override void ConfigureServices(ServiceConfigurationContext context)
		{
			context.Services.AddHostedService<HostedService1>();
			context.Services.AddHostedService<HostedService2>();
			context.Services.AddHostedService<HostedService3>();
			context.Services.AddHostedService<HostedService4>();
			context.Services.AddHostedService<HostedService5>();
			context.Services.AddHostedService<HostedService6>();
			context.Services.AddHostedService<HostedService7>();
			context.Services.AddHostedService<HostedService8>();
			context.Services.AddHostedService<HostedService9>();
			context.Services.AddHostedService<HostedService0>();
		}

		public override void OnApplicationInitialization(ApplicationInitializationContext context)
		{
			
		}
	}
}
