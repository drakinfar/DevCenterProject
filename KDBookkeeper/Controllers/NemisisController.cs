using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KDBookkeeper.Models;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class NemisisController : Controller
	{
		KingdomDeathContext _context;

		public NemisisController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// gets list of nemisis for the settlement
		/// </summary>settlement id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetNemisisList(int id)
		{
			return _context.SettlementNemisis.Where(c => c.SettlementId == id).Select(c => c.Monster.Name);
		}
	}
}
