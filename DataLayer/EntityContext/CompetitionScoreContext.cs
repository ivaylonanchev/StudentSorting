using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EntityContext
{
    public class CompetitionScoreContext : IDB<CompetitionScore, int>
    {
        private ProjectDbContext context;
        private CompetitionScore competition;
        public CompetitionScoreContext(ProjectDbContext context)
        {
            this.context = context;
        }


        public async Task CreateAsync(CompetitionScore item)
        {
            try
            {
                context.CompetitionsScores.Add(item);
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Task<CompetitionScore> ReadAsync(int key)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CompetitionScore>> ReadAllAsync()
        {
            try
            {
                return await context.CompetitionsScores.ToListAsync();
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
                context.Update(item);
                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Task DeleteAsync(int key)
        {
            throw new NotImplementedException();
        }
    }
}
