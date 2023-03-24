using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ProfileContext : IDB<Profile, int>
    {
        private ProjectDbContext context;
        public ProfileContext(ProjectDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Profile item)
        {
            try
            {
                context.Profiles.Add(item);
                await context.SaveChangesAsync();
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
                Profile profiledb = await context.Profiles.FindAsync(key);

                context.Profiles.Remove(profiledb);
                await context.SaveChangesAsync();
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
                return await context.Profiles.ToListAsync();
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
                return await context.Profiles.FindAsync(key);

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
                Profile profileFromDB = await ReadAsync(item.ID);

                context.Entry(profileFromDB).CurrentValues.SetValues(item);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
