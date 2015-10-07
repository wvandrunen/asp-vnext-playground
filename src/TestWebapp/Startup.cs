using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;

namespace TestWebapp
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
			services.AddLogging();
		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
		{
			app.UseRuntimeInfoPage("/runtime");
			loggerFactory.AddConsole(LogLevel.Verbose);	
			app.UseMvcWithDefaultRoute();
		}

		

	}
}
