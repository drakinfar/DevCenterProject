using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class QuarryController : Controller
	{
		KingdomDeathContext _context;

		public QuarryController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// get list of quarries availiable to the settlement
		/// </summary>
		/// <param name="id">settlement id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetQuarryList(int id)
		{
			return _context.SettlementQuarries.Where(c => c.SettlementId == id).Select(c => c.Monster.Name);
		}
	}

}
