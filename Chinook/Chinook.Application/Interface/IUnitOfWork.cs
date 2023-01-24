using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Application.Interface
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
        IAlbumRepository AlbumRepository { get; }
        IArtistRepository ArtistRepository { get; }

    }
}
