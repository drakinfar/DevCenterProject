using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class InnovationWords
    {
        public int Id { get; set; }
        public int InnovationId { get; set; }
        public string Keyword { get; set; }

        public virtual Innovation Innovation { get; set; }
    }
}
