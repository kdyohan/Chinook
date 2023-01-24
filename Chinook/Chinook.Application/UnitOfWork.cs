using Chinook.Application.Interface;
using Chinook.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Application
{
    public class UnitOfWork:IUnitOfWork,IDisposable
    {
        protected ChinookContext _context { get; set; }
        public UnitOfWork(ChinookContext context)
        {
            _context = context;         

        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
