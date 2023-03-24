using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataLayer
{
    public class CompetitionContext : IDB<Competition, int>
    {
        private ProjectDbContext context;
        public CompetitionContext(ProjectDbContext context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Competition item)
        {
            try
            {
                context.Competitions.Add(item);
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
                Competition competitiondb = await context.Competitions.FindAsync(key);

                context.Competitions.Remove(competitiondb);
                await context.SaveChangesAsync();
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
                return await context.Competitions.ToListAsync();
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
                return await context.Competitions.FindAsync(key);

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
                Competition orderFromDB = await ReadAsync(item.ID);

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
