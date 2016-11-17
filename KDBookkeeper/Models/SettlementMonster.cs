using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class SettlementMonster
    {
        public int SettlementId { get; set; }
        public int MonsterId { get; set; }
        public int MonsterLevel { get; set; }
        public int Id { get; set; }

        public virtual Monster Monster { get; set; }
        public virtual Settlement MonsterNavigation { get; set; }
    }
}
