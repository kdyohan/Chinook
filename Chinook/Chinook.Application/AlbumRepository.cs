using Chinook.Application.Interface;
using Chinook.Core;
using Chinook.Domain.Entities;
using Chinook.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Application
{
    public class AlbumRepository: GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(ChinookContext context) : base(context)
        {

        }

        public override async Task<bool> DeleteEntity(long id)
        {
            var albumExist = await _DbSet.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (albumExist == null) return false;

            _DbSet.Remove(albumExist);

            return true;

        }

        public override async Task<bool> UpdateEntity(Album entity)
        {
            var albumExist = await _DbSet.Where(u => u.Id == entity.Id).FirstOrDefaultAsync();
            if (albumExist != null)
            {

                albumExist.Title = entity.Title;
                albumExist.ArtistId = entity.ArtistId;
                albumExist.LastModified = entity.LastModified;
                albumExist.LastModifiedBy = entity.LastModifiedBy;
                return true;
            }
            return false;

        }
    }
}
