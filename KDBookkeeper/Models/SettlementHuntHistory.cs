using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	public class SettlementHuntHistory
	{
		public SettlementHuntHistory()
		{
			SurvivorHuntHistories = new HashSet<SurvivorHuntHistory>();
		}

		public int Id { get; set; }

		public int SettlementId { get; set; }

		public int SettlementMonsterId { get; set; }

		public int LanternYear { get; set; }

		public virtual Settlement  Settlement { get; set; }

		public virtual SettlementMonster SettlementMonster { get; set; }

		public virtual ICollection<SurvivorHuntHistory> SurvivorHuntHistories { get; set; }
	}
}
