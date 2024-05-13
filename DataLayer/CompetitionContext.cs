using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
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
                return await context.Competitions.Include(c => c.Students).FirstOrDefaultAsync(c => c.ID == key);
                // return await context.Competitions.FindAsync(key);
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
                // Competition orderFromDB = await ReadAsync(item.ID);

                //context.Entry(orderFromDB).CurrentValues.SetValues(item);
                context.Update(item);
                context.SaveChanges();

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
                // Competition orderFromDB = await ReadAsync(item.ID);

                //context.Entry(orderFromDB).CurrentValues.SetValues(item);
                // context.Update(item);
                Profile profile = await context.Profiles.FindAsync(ID.ID);
                if (p == 1)
                {
                    profile.PointsCompetition1 = ID.PointsCompetition1;
                }
                else if (p == 2)
                {
                    profile.PointsCompetition2 = ID.PointsCompetition2;
                }
                else if (p == 3)
                {
                    profile.PointsCompetition3 = ID.PointsCompetition3;
                }
                profile.NewRating();
                Competition competition = await ReadAsync(item.ID);
                competition.Students.Add(profile);
                context.Update(competition);
                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
