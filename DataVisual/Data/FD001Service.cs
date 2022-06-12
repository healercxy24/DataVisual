using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DataVisual.Data
{
    public class FD001Service
    {
        private readonly FDDataContext _context;

        public FD001Service(FDDataContext context)
        {
            _context = context;
        }

        public async Task<List<FD1RUL>> GetFD1RUL()
        {
            return await _context.FD1RULs.ToListAsync();
        }

        public async Task<FD1RUL> GetSingleFD1RUL(int? Id)
        {
            return await _context.FD1RULs.FirstOrDefaultAsync(h => h.EngineID == Id);
        }
    }
}