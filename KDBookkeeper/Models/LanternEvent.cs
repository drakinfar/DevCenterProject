using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
	public partial class LanternEvent
	{
		public LanternEvent()
		{
			GameEvents = new HashSet<GameEvents>();
			SettlementMileStones = new HashSet<SettlementMileStones>();
			EventConsequences = new HashSet<EventConsequence>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int LaternYear { get; set; }
		public string Expansion { get; set; }
		public bool IsRandom { get; set; }

		public virtual ICollection<GameEvents> GameEvents { get; set; }
		public virtual ICollection<SettlementMileStones> SettlementMileStones { get; set; }
		public virtual ICollection<EventConsequence> EventConsequences { get; set; }
	}
}
