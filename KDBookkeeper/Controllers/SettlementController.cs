using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KDBookkeeper.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class SettlementController : Controller
	{
		KingdomDeathContext _context;

		public SettlementController(KingdomDeathContext context)
		{
			_context = context;
		}

		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("[action]")]
		public Settlement GetSettlement(int Id)
		{
			//todo: these includes are kind of a nightmare look into breaking up into other calls if needs be.
			var settlement = _context.Settlement
				.Include(c => c.SettlementLocation)
				.Include(c=> c.SettlementInnovation)
				.Include(c=> c.SettlementMileStones)
				.Include(c=> c.SettlementPrinciple)
				.Include(c=>c.SettlementNemisis)
				.Include(c=>c.SettlementQuarries)
				.Include(c=>c.SettlementResource)
				.FirstOrDefault(c => c.Id == Id);

			return settlement;
		}

		[HttpGet("[action]")]
		public IEnumerable<string> GetSettlementNames()
		{
			//todo: add a active flag to the database and only return settlements that are active.
			return _context.Settlement.Select(c => c.Name);
		}
	}
}
