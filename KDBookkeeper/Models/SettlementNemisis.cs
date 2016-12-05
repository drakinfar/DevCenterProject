using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
	public partial class SettlementNemisis
	{
		public int SettlementId { get; set; }
		public int MonsterId { get; set; }
		public int Id { get; set; }
		public int NemisisLevel { get; set; }

		public virtual Monster Monster { get; set; }
		public virtual Settlement Settlement { get; set; }
	}
}
