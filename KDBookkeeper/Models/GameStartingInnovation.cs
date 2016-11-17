using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class GameStartingInnovation
    {
        public int GameTypeId { get; set; }
        public int InnovationId { get; set; }
        public int Id { get; set; }

        public virtual GameType GameType { get; set; }
        public virtual Innovation Innovation { get; set; }
    }
}
