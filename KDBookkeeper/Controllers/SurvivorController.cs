using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class SurvivorController : Controller
	{

		KingdomDeathContext _context;

		public SurvivorController(KingdomDeathContext context)
		{
			_context = context;
		}

		[HttpGet("[action]")]
		public IEnumerable<SurvivorData> GetAvailableSurvivors(int Id)
		{
			var a= _context.Survivor.Where(c => c.Alive && c.SettlementId == Id).Select(c => new SurvivorData()
			{
				Name = c.Name,
				SurvivorId = c.Id,
				Survived = true
			});
			return a;
		}
	}
}
