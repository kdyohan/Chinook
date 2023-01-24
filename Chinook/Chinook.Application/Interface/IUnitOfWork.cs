using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Application.Interface
{
    internal interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
