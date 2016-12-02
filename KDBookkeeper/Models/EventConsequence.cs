using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Models
{
	public class EventConsequence
	{
		public int EventConsequenceId { get; set; }

		public int LanternEventId { get; set; }

		public virtual LanternEvent LanternEvent { get; set; }

		public int ConsequenceType { get; set; } //the type of consequence i.e quarry, nemisis, etc

		public int ConsequenceObjectId { get; set; } //the id of the consequence to help look up.
	}
}
