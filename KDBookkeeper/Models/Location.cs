using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class Location
    {
        public Location()
        {
            SettlementLocation = new HashSet<SettlementLocation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SettlementLocation> SettlementLocation { get; set; }
    }
}
