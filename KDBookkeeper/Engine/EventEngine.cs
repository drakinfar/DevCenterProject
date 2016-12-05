using KDBookkeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Engine
{
	/// <summary>
	/// Engine for completing events for settlements. This should take care of each latern year event and the consequences there of.
	/// Its will have branching as dictated by the consequence rows that each event will have.
	/// </summary>
	public class EventEngine
	{
		KingdomDeathContext _context;
		public EventEngine(KingdomDeathContext context)
		{
			this._context = context;
		}
	}
}
