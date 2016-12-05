using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class PrincipleController : Controller
	{
		KingdomDeathContext _context;

		public PrincipleController(KingdomDeathContext context)
		{
			_context = context;
		}

		/// <summary>
		/// gets the list of prinicples that the settlement has
		/// </summary>
		/// <param name="id">settlment Id</param>
		/// <returns></returns>
		[HttpGet("[action]")]
		public IEnumerable<string> GetPrincipleList(int id)
		{
			return _context.SettlementPrinciple.Where(c => c.SettlementId == id).Select(c => c.Principle.Name);
		}

	}
}
