using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DataVisual.Data
{
    public class FD003Service
    {
        private readonly FDDataContext _context;

        public FD003Service(FDDataContext context)
        {
            _context = context;
        }

        public async Task<List<FD3RUL>> GetFD3RUL()
        {
            return await _context.FD3RULs.ToListAsync();
        }

        public async Task<FD3RUL> GetSingleFD3RUL(int? Id)
        {
            return await _context.FD3RULs.FirstOrDefaultAsync(h => h.EngineID == Id);
        }

        public async Task<List<FD3TEST>> GetFD3TEST()
        {
            return await _context.FD3TESTs.ToListAsync();
        }

        public async Task<List<FD3TEST>> GetSingleFD3TEST(int? Id)
        {
            var result = _context.FD3TESTs.Where(h => h.EngineID == Id);
            var fd3tests = await result.ToListAsync();
            return fd3tests;
        }

        public async Task<List<FD3TRAIN>> GetFD3TRAIN()
        {
            return await _context.FD3TRAINs.ToListAsync();
        }

        public async Task<List<FD3TRAIN>> GetSingleFD3TRAIN(int? Id)
        {
            var result = _context.FD3TRAINs.Where(h => h.EngineID == Id);
            var fd3trains = await result.ToListAsync();
            return fd3trains;
        }
    }
}
