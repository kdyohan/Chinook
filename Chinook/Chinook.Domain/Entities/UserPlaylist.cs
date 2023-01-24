using Chinook.Domain.Common;

namespace Chinook.Domain.Entities;

public class UserPlaylist: BaseAuditableEntity
{
    public string UserId { get; set; }
    public long PlaylistId { get; set; }
    public ChinookUser User { get; set; }
    public Playlist Playlist { get; set; }
}
