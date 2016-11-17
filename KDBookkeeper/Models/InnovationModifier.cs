using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class InnovationModifier
    {
        public int Id { get; set; }
        public int InnovationId { get; set; }
        public int Modifier { get; set; }
        public string ModifiedItem { get; set; }
        public int AppliesTo { get; set; }

        public virtual AppliesKeyword AppliesToNavigation { get; set; }
        public virtual Innovation Innovation { get; set; }
    }
}
