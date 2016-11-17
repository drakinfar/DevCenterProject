using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class PrincipleModifier
    {
        public int Id { get; set; }
        public int PrincipleId { get; set; }
        public int Modifier { get; set; }
        public string ModifiedAttribute { get; set; }
        public int AppliesTo { get; set; }

        public virtual AppliesKeyword AppliesToNavigation { get; set; }
        public virtual Principle Principle { get; set; }
    }
}
