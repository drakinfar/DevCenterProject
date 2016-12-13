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
		public int HuntYear { get; internal set; }
		public int MonsterId { get; internal set; }
		public int MonsterLevel { get; internal set; }
		public int SettlementId { get; internal set; }
		public IEnumerable<SurvivorData> Survivors { get; internal set; }
	}
}
