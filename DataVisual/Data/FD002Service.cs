using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DataVisual.Data
{
    public class FD002Service
    {
        private readonly FDDataContext _context;

        public FD002Service(FDDataContext context)
        {
            _context = context;
        }

        public async Task<List<FD2RUL>> GetFD2RUL()
        {
            return await _context.FD2RULs.ToListAsync();
        }

        public async Task<FD2RUL> GetSingleFD2RUL(int? Id)
        {
            return await _context.FD2RULs.FirstOrDefaultAsync(h => h.EngineID == Id);
        }

        public async Task<List<FD2TEST>> GetFD2TEST()
        {
            return await _context.FD2TESTs.ToListAsync();
        }

        public async Task<List<FD2TEST>> GetSingleFD2TEST(int? Id)
        {
            var result = _context.FD2TESTs.Where(h => h.EngineID == Id);
            var fd2tests = await result.ToListAsync();
            return fd2tests;
        }

        public async Task<List<FD2TRAIN>> GetFD2TRAIN()
        {
            return await _context.FD2TRAINs.ToListAsync();
        }

        public async Task<List<FD2TRAIN>> GetSingleFD2TRAIN(int? Id)
        {
            var result = _context.FD2TRAINs.Where(h => h.EngineID == Id);
            var fd2trains = await result.ToListAsync();
            return fd2trains;
        }
    }
}
