using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	public class EventChart
	{
		public int Id { get; set; }
		public int LanternEventId { get; set; }
		public string DieRoll { get; set; }
		public string ChartTable { get; set; }

		public LanternEvent LanternEvent { get; set; }

	}
}
