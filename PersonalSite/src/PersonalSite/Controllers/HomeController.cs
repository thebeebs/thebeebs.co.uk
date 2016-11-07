using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure;
using Newtonsoft.Json;
using PersonalSite.ViewModels;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Blob;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache memoryCache;

        public HomeController(IMemoryCache memoryCache) {
            this.memoryCache = memoryCache;
        }

        public async Task<IActionResult> Index()
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
            return View(deserializedProduct);
        }

        public IActionResult Page(string page)
        {
            var p = memoryCache.Get(page);
            if (p == null)
            {
                p = Services.Content.FetchPage(page);
                memoryCache.Set(page, p);
            }
            return View(p);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Category()
        {
            var overview = Services.Content.FetchOverview();
            foreach (var cat in overview.Categories)
            {
            }
            return View(overview);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
