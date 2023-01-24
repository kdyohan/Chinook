using Chinook.Domain.Common;
using System;
using System.Collections.Generic;

namespace Chinook.Domain.Entities
{
    public partial class Playlist: BaseAuditableEntity
    {
        public Playlist()
        {
            Tracks = new HashSet<Track>();
        }

        public long PlaylistId { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
        public virtual ICollection<UserPlaylist> UserPlaylists { get; set; }

    }
}
