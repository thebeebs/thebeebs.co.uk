using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PersonalSite.ViewModels;
using PersonalSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Newtonsoft.Json;

namespace PersonalSite
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();            
            services.AddMemoryCache();              

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, IMemoryCache memoryCache)
        {
            var overview = Services.Content.FetchOverview();
            var setting = "DefaultEndpointsProtocol=https;AccountName=thebeebscontent;AccountKey=NVBFmW8BQX06usXJShkf8J6rXs+DL4gfslWWm+a5iujjdNsuCclxhK/Rmw3yfCOK2tUfflo/XrRBEcn385kTFw=="; //CloudConfigurationManager.GetSetting("thebeebscontent_AzureStorageConnectionString");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(setting);
            string output = JsonConvert.SerializeObject(overview);

            // Create the blob client.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            // Retrieve a reference to a container.
            CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");

            // Create the container if it doesn't already exist.
            container.CreateIfNotExists();

            CloudBlockBlob blockBlob = container.GetBlockBlobReference("myblob");
            blockBlob.UploadText(output);

            ContentOverview deserializedProduct = JsonConvert.DeserializeObject<ContentOverview>(output);

            memoryCache.CreateEntry("Overview").Value = deserializedProduct;

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute("home", "",
                    defaults: new { controller = "Home", action = "Index" });
                routes.MapRoute("pages", "{page:required}",
                    defaults: new { controller = "Home", action = "Page" });
                routes.MapRoute("category", "category/{*article}",
              defaults: new
              {
                  controller = "Home",
                  action = "Category"
              });
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
