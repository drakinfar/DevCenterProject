using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class GameEvent
    {
        public int LaternEventId { get; set; }
        public int GameTypeId { get; set; }
        public int LaternYear { get; set; }
        public bool IsRandom { get; set; }
        public int Id { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual LanternEvent LaternEvent { get; set; }
    }
}
