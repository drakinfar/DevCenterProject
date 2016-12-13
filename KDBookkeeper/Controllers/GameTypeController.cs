using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class GameTypeController
	{
		KingdomDeathContext _context;

		public GameTypeController(KingdomDeathContext context)
		{
			_context = context;
		}

		[HttpGet("[action]")]
		public IEnumerable<GameTypeData> GetGameTypes()
		{
			return _context.GameType.Select(c =>
				new GameTypeData()
				{
					Id = c.Id,
					Name = c.Name
				});
		}
	}
}
