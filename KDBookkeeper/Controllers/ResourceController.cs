using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class ResourceController : Controller
	{
		KingdomDeathContext _context;

		public ResourceController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// gets list of resources that the settlement has
		/// </summary>
		/// <param name="id">settlement Id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<ResourceItem> GetResourceList(int id)
		{
			return _context.SettlementResource.Where(c => c.SettlementId == id)
				.Select(c => new ResourceItem()
				{
					Name = c.Resource.Name,
					Quantity = c.Quantity
				});
		}

		public class ResourceItem
		{
			public int Quantity { get; set; }

			public string Name { get; set; }
		}
	}
}
