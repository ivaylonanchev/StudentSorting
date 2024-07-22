using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace DataLayer.EntityContext
{
    public class CompetitionContext : IDB<Competition, int>
    {
        private ProjectDbContext context;
        private Competition competition;
        
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

                var comps = await context.CompetitionsScores.Where(x=>x.CompetitionId== key).ToListAsync();
                context.RemoveRange(comps);
                
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
                return await context.Competitions.Include(c => c.CompetitionScores).FirstOrDefaultAsync(c => c.ID == key);
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
                Profile profile = await context.Profiles
                    .FindAsync(ID.ID);
                var comp = context.CompetitionsScores.First(x => x.ProfileId == ID.ID && x.CompetitionId == item.ID);

                if (p == 1)
                {
                    comp.Points = ID.PointsCompetition1;
                }
                else if (p == 2)
                {
                    comp.Points = ID.PointsCompetition2;
                }
                else if (p == 3)
                {
                    comp.Points = ID.PointsCompetition3;
                }
                profile.NewRating();

                competition.CompetitionScores.Add(comp);
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
