using Chinook.Core.Interface;
using Chinook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Application.Interface
{
    public interface IArtistRepository : IGenericRepository<Artist>
    {
    }
}
