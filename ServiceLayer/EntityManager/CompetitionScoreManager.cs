using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using DataLayer.EntityContext;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.EntityManager
{
    public class CompetitionScoreManager : IManager<CompetitionScore, int>
    {
        CompetitionScoreContext _context;

        public CompetitionScoreManager(ProjectDbContext context)
        {
            _context = new CompetitionScoreContext(context);
        }

        public async Task CreateAsync(CompetitionScore item)
        {
            try
            {
                await _context.CreateAsync(item);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<CompetitionScore> ReadAsync(int key)
        {
            try
            {
                return await _context.ReadAsync(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CompetitionScore>> ReadAllAsync()
        {
            try
            {
                return await _context.ReadAllAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(CompetitionScore item)
        {
            try
            {
                await _context.UpdateAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(int key)
        {
            try
            {
                await _context.DeleteAsync(key);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
