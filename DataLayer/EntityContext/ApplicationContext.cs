using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.EntityContext
{
    public class ApplicationContext : IDB<Application, int>
    {
        private ProjectDbContext context;
        public ApplicationContext(ProjectDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Application item)
        {
            try
            {
                context.Applications.Add(item);
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
                Application Applicationdb = await context.Applications.FindAsync(key);

                context.Applications.Remove(Applicationdb);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Application>> ReadAllAsync()
        {
            try
            {
                return await context.Applications.ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Application> ReadAsync(int key)
        {
            try
            {
                return await context.Applications.FindAsync(key);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateAsync(Application item)
        {
            try
            {
                Application orderFromDB = await ReadAsync(item.ID);

                context.Entry(orderFromDB).CurrentValues.SetValues(item);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

