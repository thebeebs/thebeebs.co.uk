using System;

namespace thebeebs.co.uk.Model
{
	public interface IPageService
	{
		Page GetBySlug(string slug);
	}
}