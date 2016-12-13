using KDBookkeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Engine
{
	public class SettlementPhase
	{

		//Need to implement the following steps
		/*
		1. Survivors return. 
			a. surrvivors heal everything but permanent injury (on hold until survivor build out)
			b. Add names of the returning survivors (first lantern year only)
		 
		2. Gain Endeavors. outside of the bookkeeper but may want to generate or display the rule
			a. Each returning survivor generates 1 endeavor point. These are not recorded as they are lost if not used.
		3. Settlement Event.
			a. generate settlement event. First day for the first year
			b. each subsequent play a random event by drawing from the random event deck.
		4. Update the death Count
			a. this is a function of the losses from the event and survivors who do not return from the hunt.
		5. Update the Timeline.
			a. update the lantern year
			b. trigger story events
			c. check milestones. aka death count above 0 fires the death principle event.
		6. Develop
			a. send endeavors to build, craft, innovate, join activities.
			b. check milestones. aka first birth triggers the new life principle
		7. prepare departing survivors
		8. record resources
		9. clean up

		 
		 */

		KingdomDeathContext _context;
		public SettlementPhase(KingdomDeathContext context)
		{
			_context = context;
		}

		public void ReturnSurvivors(SurvivorHuntData returned)
		{
			//a.surrvivors heal everything but permanent injury (on hold until survivor build out)
			//b.Add names of the returning survivors (first lantern year only)
			//record the hunt and who was on it
			//add the settlementmonster
			var settlementId = returned.SettlementId;


			var settlementMonster = new SettlementMonster()
			{
				MonsterId = returned.MonsterId,
				MonsterLevel = returned.MonsterLevel,
				SettlementId = settlementId
			};

			_context.SettlementMonster.Add(settlementMonster);

			//add settlement hunt

			var settlementHuntHistory = new SettlementHuntHistory()
			{
				LanternYear = returned.HuntYear,
				SettlementId = settlementId,
				SettlementMonster = settlementMonster,

			};

			_context.SettlementHuntHistory.Add(settlementHuntHistory);

			//add hunt participants

			foreach (var survivor in returned.Survivors)
			{
				_context.SurvivorHuntHistory.Add(new Models.SurvivorHuntHistory()
				{
					SettlementHuntHistory = settlementHuntHistory,
					Survived = survivor.Survived,
					SurvivorId = survivor.SurvivorId
				});

				if (returned.HuntYear == 0)//first day hunt need to add the hunter names
					_context.Survivor.Add(new Survivor()
					{
						Age = 1,
						Alive = survivor.Survived,
						Name = survivor.Name,
						SettlementId = settlementId
					});
				else //need to age the survivor
				{
					var aSurvivor = _context.Survivor.FirstOrDefault(c => c.Id == survivor.SurvivorId);
					if (aSurvivor != null)
					{
						aSurvivor.Age += 1;
						aSurvivor.Alive = survivor.Survived;
					}
						
				}
			}

			_context.SaveChanges();
		}


		/// <summary>
		/// gets the next event for the indicated latern year and settlement ID
		/// </summary>
		/// <param name="year">Lantern Year to pull</param>
		/// <param name="id">Settlement Id</param>
		/// <returns>Next latern year based on the year and the settlement game type</returns>
		public LanternEvent GenerateSettlementEvent(int year, int Id)
		{
			var gameTypeId = _context.Settlement.Where(c => c.Id == Id).Select(c => c.GameTypeId).FirstOrDefault();

			LanternEvent lanternEvent = null;

			if (year == 1) //we fire the first day event
				lanternEvent = _context.LanternEvent.First(c => c.Name == "First Day");//todo: this may change for different game types check for that
			else//we need a random event
				lanternEvent = getRandomEvent(gameTypeId);

			return lanternEvent;
		}

		private LanternEvent getRandomEvent(int gameTypeId)
		{
			return _context.GameEvents
				.Where(c => c.GameTypeId == gameTypeId && c.IsRandom)
				.OrderBy(c => Guid.NewGuid()) //sort by random
				.Select(c => c.LaternEvent)
				.FirstOrDefault();
		}


	}
}
