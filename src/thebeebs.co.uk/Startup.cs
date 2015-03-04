using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace thebeebs.co.uk
{
    public class Startup
    {public void ConfigureServices(IServiceCollection services)
        {
			services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
			app.UseMvc(routes => routes.MapRoute(
				"default",
				"",
				new { controller = "Home", action = "Index"}
				).MapRoute("postname",
				"{postname}",
				new { controller = "Home", action = "Page" })				
				);
        }
    }
}
