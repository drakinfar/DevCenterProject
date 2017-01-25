using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
	public partial class LanternEvent
	{
		public LanternEvent()
		{
			GameEvents = new HashSet<GameEvent>();
			SettlementMileStones = new HashSet<SettlementMileStone>();
			EventConsequences = new HashSet<EventConsequence>();
			EventCharts = new HashSet<EventChart>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int LaternYear { get; set; }
		public string Expansion { get; set; }
		public bool IsRandom { get; set; }

		public virtual ICollection<GameEvent> GameEvents { get; set; }
		public virtual ICollection<SettlementMileStone> SettlementMileStones { get; set; }
		public virtual ICollection<EventConsequence> EventConsequences { get; set; }
		public virtual ICollection<EventChart> EventCharts { get; set; }
	}
}
