using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
	public partial class Settlement
	{
		public Settlement()
		{
			SettlementInnovation = new HashSet<SettlementInnovation>();
			SettlementLocation = new HashSet<SettlementLocation>();
			SettlementMileStones = new HashSet<SettlementMileStones>();
			SettlementMonster = new HashSet<SettlementMonster>();
			SettlementNemisis = new HashSet<SettlementNemisis>();
			SettlementPrinciple = new HashSet<SettlementPrinciple>();
			SettlementQuarries = new HashSet<SettlementQuarries>();
			SettlementResource = new HashSet<SettlementResource>();
			Survivor = new HashSet<Survivor>();
		}

		public int Id { get; set; }
		public int SurvivalLimit { get; set; }
		public string Name { get; set; }
		public int DeathCount { get; set; }
		public int LanternYear { get; set; }
		public int Population { get; set; }
		public int LostSettlements { get; set; }
		public bool Active { get; set; }
		public int GameTypeId { get; set; }

		public GameType GameType { get; set; }

		public virtual ICollection<SettlementInnovation> SettlementInnovation { get; set; }
		public virtual ICollection<SettlementLocation> SettlementLocation { get; set; }
		public virtual ICollection<SettlementMileStones> SettlementMileStones { get; set; }
		public virtual ICollection<SettlementMonster> SettlementMonster { get; set; }
		public virtual ICollection<SettlementNemisis> SettlementNemisis { get; set; }
		public virtual ICollection<SettlementPrinciple> SettlementPrinciple { get; set; }
		public virtual ICollection<SettlementQuarries> SettlementQuarries { get; set; }
		public virtual ICollection<SettlementResource> SettlementResource { get; set; }
		public virtual ICollection<Survivor> Survivor { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}