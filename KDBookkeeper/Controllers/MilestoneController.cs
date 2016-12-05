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
	public class MilestoneController : Controller
	{
		KingdomDeathContext _context;

		public MilestoneController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// gets a list of milestones for the indicationed settlement
		/// </summary>
		/// <param name="id">settlement id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetMilestoneList(int id)
		{
			return _context.SettlementMileStones.Where(c => c.SettlementId == id).Select(c => c.Name);
		}

	}
}
