using Chinook.Domain.Common;
using System;
using System.Collections.Generic;

namespace Chinook.Domain.Entities
{
    public partial class MediaType: BaseAuditableEntity
    {
        public MediaType()
        {
            Tracks = new HashSet<Track>();
        }

        public long MediaTypeId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
