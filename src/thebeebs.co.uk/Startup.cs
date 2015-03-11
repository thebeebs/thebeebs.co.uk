﻿using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;
using thebeebs.co.uk.Model;

namespace thebeebs.co.uk
{
    public class Startup
    {public void ConfigureServices(IServiceCollection services)
        {

			
			services.AddMvc();
			services.AddTransient<IPageService, PageServiceTableStorage>();
		}

        public void Configure(IApplicationBuilder app)
        {
			// Add static files to the request pipeline.
			app.UseStaticFiles();

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
