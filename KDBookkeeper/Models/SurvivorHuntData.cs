using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	/// <summary>
	/// Used to send hunt history data around.
	/// </summary>
	public class SurvivorHuntData
	{
		public int huntYear { get;  set; }
		public int monsterId { get;  set; }
		public int monsterLevel { get;  set; }
		public int settlementId { get;  set; }
		public IEnumerable<SurvivorData> survivors { get;  set; }
	}
}
