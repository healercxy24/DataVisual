using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DataVisual.Data
{
    public class FD004Service
    {
        private readonly FDDataContext _context;

        public FD004Service(FDDataContext context)
        {
            _context = context;
        }

        public async Task<List<FD4RUL>> GetFD4RUL()
        {
            return await _context.FD4RULs.ToListAsync();
        }

        public async Task<FD4RUL> GetSingleFD4RUL(int? Id)
        {
            return await _context.FD4RULs.FirstOrDefaultAsync(h => h.EngineID == Id);
        }

        public async Task<List<FD4TEST>> GetFD4TEST()
        {
            return await _context.FD4TESTs.ToListAsync();
        }

        public async Task<List<FD4TEST>> GetSingleFD4TEST(int? Id)
        {
            var result = _context.FD4TESTs.Where(h => h.EngineID == Id);
            var fd4tests = await result.ToListAsync();
            return fd4tests;
        }

        public async Task<List<FD4TRAIN>> GetFD4TRAIN()
        {
            return await _context.FD4TRAINs.ToListAsync();
        }

        public async Task<List<FD4TRAIN>> GetSingleFD4TRAIN(int? Id)
        {
            var result = _context.FD4TRAINs.Where(h => h.EngineID == Id);
            var fd4trains = await result.ToListAsync();
            return fd4trains;
        }
    }
}
