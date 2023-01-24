using Chinook.Domain.Common;
using System;
using System.Collections.Generic;

namespace Chinook.Domain.Entities
{
    public partial class Artist: BaseAuditableEntity
    {
        public Artist()
        {
            Albums = new HashSet<Album>();
        }
        public string? Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
