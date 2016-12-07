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
			_context = context;
		}

		/// <summary>
		/// gets the next event for the indicated latern year and settlement ID
		/// </summary>
		/// <param name="year">Lantern Year to pull</param>
		/// <param name="id">Settlement Id</param>
		/// <returns>Next latern year based on the year and the settlement game type</returns>
		public LanternEvent getEvent(int year, int id)
		{
			var gameTypeId = _context.Settlement.Where(c => c.Id == id).Select(c => c.GameTypeId).FirstOrDefault();

			var lanternEvent = _context.GameEvents.Where(c => c.GameTypeId == gameTypeId && c.LaternYear == year).Select(c => c.LaternEvent).FirstOrDefault();

			if (lanternEvent == null)//we need a random event
				lanternEvent = getRandomEvent(gameTypeId);

			return lanternEvent;
		}

		private LanternEvent getRandomEvent(int gameTypeId)
		{
			return _context.GameEvents
				.Where(c => c.GameTypeId == gameTypeId && c.IsRandom)
				.OrderBy(c => Guid.NewGuid()) //sort by random
				.Select(c=> c.LaternEvent) 
				.FirstOrDefault();
		}
	}
}
