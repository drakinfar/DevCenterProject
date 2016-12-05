using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class InnovationController : Controller
	{
		KingdomDeathContext _context;

		public InnovationController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// Returns list of innovations owned by the settlement
		/// </summary>
		/// <param name="id">Settlement Id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetInnovationList(int id)
		{
			return _context.SettlementInnovation.Where(c => c.SettlementId == id).Select(c => c.Innovaton.Name);

		}
	}
}
