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
}