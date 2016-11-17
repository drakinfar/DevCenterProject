using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class Monster
    {
        public Monster()
        {
            SettlementMonster = new HashSet<SettlementMonster>();
            SettlementNemisis = new HashSet<SettlementNemisis>();
            SettlementQuarries = new HashSet<SettlementQuarries>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Nemisis { get; set; }
        public int? ResourceDeck { get; set; }

        public virtual ICollection<SettlementMonster> SettlementMonster { get; set; }
        public virtual ICollection<SettlementNemisis> SettlementNemisis { get; set; }
        public virtual ICollection<SettlementQuarries> SettlementQuarries { get; set; }
        public virtual ResourceSource ResourceDeckNavigation { get; set; }
    }
}
