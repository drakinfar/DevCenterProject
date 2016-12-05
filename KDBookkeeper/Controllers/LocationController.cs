using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class LocationController : Controller
	{
		KingdomDeathContext _context;

		public LocationController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// gets list of locations owned by settlement
		/// </summary>
		/// <param name="Id">Settlement Id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetLocationList(int Id)
		{
			return _context.SettlementLocation.Where(c => c.SettlementId == Id).Select(c => c.Location.Name);
		}

	}
}
