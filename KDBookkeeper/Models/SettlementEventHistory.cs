using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
    public class SettlementEventHistory
    {
		public int Id { get; set; }

		public int LanternEventId { get; set; }

		public int SettlementId { get; set; }

		public int LanternYear { get; set; }

		public virtual LanternEvent LanternEvent { get; set; }

		public virtual Settlement Settlement { get; set; }

	}
}
