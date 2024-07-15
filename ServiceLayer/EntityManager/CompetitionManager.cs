using BusinessLayer;
using DataLayer;
using DataLayer.EntityContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CompetitionManager : IManager<Competition, int>
    {
        CompetitionContext _context;
        public CompetitionManager(ProjectDbContext context)
        {
            _context = new CompetitionContext(context);
        }
        public async Task CreateAsync(Competition item)
        {
            try
            {
                await _context.CreateAsync(item);
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

        public async Task<List<Competition>> ReadAllAsync()
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

        public async Task<Competition> ReadAsync(int key)
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

        public async Task UpdateAsync(Competition item)
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
        public async Task UpdateAsync(Competition item, Profile ID, int p)
        {
            try
            {
                await _context.UpdateAsync(item, ID, p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
