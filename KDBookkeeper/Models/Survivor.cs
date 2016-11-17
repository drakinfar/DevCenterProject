using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class Survivor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Alive { get; set; }
        public int SettlementId { get; set; }

        public virtual Settlement Settlement { get; set; }
    }
}
