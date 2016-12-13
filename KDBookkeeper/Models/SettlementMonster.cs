using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
	public partial class SettlementMonster
	{

		public SettlementMonster()
		{
			SettlementHuntHistories = new HashSet<SettlementHuntHistory>();
		}

		public int SettlementId { get; set; }
		public int MonsterId { get; set; }
		public int MonsterLevel { get; set; }
		public int Id { get; set; }

		public virtual Monster Monster { get; set; }
		public virtual Settlement Settlement { get; set; }

		public virtual ICollection<SettlementHuntHistory> SettlementHuntHistories { get; set; }
	}
}
