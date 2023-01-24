using Chinook.Domain.Common;
using System;
using System.Collections.Generic;

namespace Chinook.Domain.Entities
{
    public partial class Genre: BaseAuditableEntity
    {
        public Genre()
        {
            Tracks = new HashSet<Track>();
        }

        public long GenreId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
