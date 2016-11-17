using System;
using System.Collections.Generic;

namespace KDBookkeeper.Models
{
    public partial class ResourceSource
    {
        public ResourceSource()
        {
            Monster = new HashSet<Monster>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Monster> Monster { get; set; }
    }
}
