using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	/// <summary>
	/// Used to pass data in for creation of new settlements
	/// </summary>
	public class SettlementData
	{
		public int Death { get; set; }

		public int Population { get; set; }

		public int GameTypeId { get; set; }

		public string Name { get; set; }


	}
}
