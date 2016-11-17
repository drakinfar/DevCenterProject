using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class AppliesKeyword
    {
        public AppliesKeyword()
        {
            InnovationModifier = new HashSet<InnovationModifier>();
            PrincipleModifier = new HashSet<PrincipleModifier>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<InnovationModifier> InnovationModifier { get; set; }
        public virtual ICollection<PrincipleModifier> PrincipleModifier { get; set; }
    }
}
