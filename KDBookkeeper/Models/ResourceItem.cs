using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class ResourceItem
    {
        public ResourceItem()
        {
            SettlementResource = new HashSet<SettlementResource>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Instances { get; set; }
        public int Source { get; set; }

        public virtual ICollection<SettlementResource> SettlementResource { get; set; }
    }
}
