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

        public async Task<bool> CreateFD1RUL(FD1RUL rul)
        {
            await _context.FD1RULs.AddAsync(rul);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateFD1RUL(FD1RUL rul)
        {
            _context.FD1RULs.Update(rul);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteFD1RUL(FD1RUL rul)
        {
            _context.FD1RULs.Remove(rul);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<FD1TEST>> GetFD1TEST()
        {
            return await _context.FD1TESTs.ToListAsync();
        }

        public async Task<List<FD1TEST>> GetSingleFD1TEST(int? Id)
        {
            var result = _context.FD1TESTs.Where(h => h.EngineID == Id);
            var fd1tests = await result.ToListAsync();
            return fd1tests;
        }

        public async Task<List<FD1TRAIN>> GetFD1TRAIN()
        {
            return await _context.FD1TRAINs.ToListAsync();
        }

        public async Task<List<FD1TRAIN>> GetSingleFD1TRAIN(int? Id)
        {
            var result = _context.FD1TRAINs.Where(h => h.EngineID == Id);
            var fd1trains = await result.ToListAsync();
            return fd1trains;
        }
    }
}