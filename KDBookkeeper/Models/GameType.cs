using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class GameType
    {
        public GameType()
        {
            GameEvents = new HashSet<GameEvents>();
            GameStartingInnovation = new HashSet<GameStartingInnovation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GameEvents> GameEvents { get; set; }
        public virtual ICollection<GameStartingInnovation> GameStartingInnovation { get; set; }
    }
}
