using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;
using SharedConfiguration;

namespace thebeebs.co.uk.Model
{
	public class HardCodedPageService : IPageService
	{
		public HardCodedPageService()
		{
		}

		public Page GetBySlug(string slug) {
			return new Page { Title = "slug" };
		}
	}

	public class PageServiceTableStorage : IPageService
	{
		public PageServiceTableStorage()
		{
		}

		public Page GetBySlug(string slug)
		{
			var creds = new StorageCredentials(AzureConfiguration.StorageName, AzureConfiguration.StorageKey);
			CloudStorageAccount storageAccount = new CloudStorageAccount(creds, true);

			TableOperation retrieveOperation = TableOperation.Retrieve<BlogEntity>("Blog", slug);

			// Create the table client.
			CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

			CloudTable table = tableClient.GetTableReference("content");

			var retrievedResult = table.ExecuteAsync(retrieveOperation);

			// Print the phone number of the result.
			if (retrievedResult.Result != null)
				return new Page {
					Title = ((BlogEntity)retrievedResult.Result.Result).RowKey,
					Content = ((BlogEntity)retrievedResult.Result.Result).Content
				};
			else
				return new Page { Title = "slug" };


		}
	}


		public class BlogEntity : TableEntity
		{
			public BlogEntity(string type, string slug)
			{
				this.PartitionKey = type;
				this.RowKey = slug;
			}

			public BlogEntity() { }

			public string Date { get; set; }

			public string Content { get; set; }
		}

}