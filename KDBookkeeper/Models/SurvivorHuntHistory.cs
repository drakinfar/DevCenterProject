using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	public class SurvivorHuntHistory
	{
		public int Id { get; set; }

		public int SurvivorId { get; set; }

		public int SettlementHuntHistoryId { get; set; }

		public bool Survived { get; set; }

		public virtual Survivor  Survivor { get; set; }

		public virtual SettlementHuntHistory SettlementHuntHistory { get; set; }

	}
}
