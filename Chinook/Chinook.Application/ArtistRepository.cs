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
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(ChinookContext context) : base(context)
        {

        }

        public override async Task<bool> DeleteEntity(long id)
        {
            var artistExist = await _DbSet.Where(u => u.Id == id).FirstOrDefaultAsync();
            if (artistExist == null) return false;

            _DbSet.Remove(artistExist);

            return true;

        }

        public override async Task<bool> UpdateEntity(Artist entity)
        {
            var artistExist = await _DbSet.Where(u => u.Id == entity.Id).FirstOrDefaultAsync();
            if (artistExist != null)
            {

                artistExist.Name = entity.Name;
                artistExist.LastModified = entity.LastModified;
                artistExist.LastModifiedBy = entity.LastModifiedBy;
                return true;
            }
            return false;

        }
    }
}
