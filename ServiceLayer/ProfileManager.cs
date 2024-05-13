using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProfileManager : IManager<Profile, int>
    {
        ProfileContext _context;
        public ProfileManager(ProjectDbContext context)
        {
            _context = new ProfileContext(context);
        }
        public async Task CreateAsync(Profile item)
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

        public async Task<List<Profile>> ReadAllAsync()
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

        public async Task<Profile> ReadAsync(int key)
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
        public async Task<Profile> ReadAsync(string egn)
        {
            try
            {
                return await _context.ReadAsync(egn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(Profile item)
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
    }
}
