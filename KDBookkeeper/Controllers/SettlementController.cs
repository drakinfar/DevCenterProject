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
			//todo: check for null settlement
			var settlement = _context.Settlement.FirstOrDefault(c => c.Id == Id);

			return settlement;
		}

		[HttpGet("[action]")]
		public IEnumerable<Settlement> GetSettlementNames()
		{
			return _context.Settlement.Where(c=> c.Active);
		}
	}
}
