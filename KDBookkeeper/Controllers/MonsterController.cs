using KDBookkeeper.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Controllers
{
	[Route("api/[controller]")]
	public class MonsterController
	{
		KingdomDeathContext _context;

		public MonsterController(KingdomDeathContext context)
		{
			_context = context;
		}


	}
}
