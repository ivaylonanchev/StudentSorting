using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class ProjectDbManager
    {
        private static ProjectDbContext _context;

        public static ProjectDbContext CreateContext()
        {
            _context = new ProjectDbContext();
            return _context;
        }

        public static ProjectDbContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }
    }
}
