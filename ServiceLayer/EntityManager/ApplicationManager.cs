using BusinessLayer;
using DataLayer;
using DataLayer.EntityContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.EntityManager
{
    public class ApplicationManager : IManager<Application, int>
    {
        ApplicationContext _context;
        public ApplicationManager(ProjectDbContext context)
        {
            _context = new ApplicationContext(context);
        }
        public async Task CreateAsync(Application item)
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

        public async Task<List<Application>> ReadAllAsync()
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

        public async Task<Application> ReadAsync(int key)
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

        public async Task UpdateAsync(Application item)
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
