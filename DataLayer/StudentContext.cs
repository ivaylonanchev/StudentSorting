using BusinessLayer;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentContext : IDB<Student, string>
    {
        private ProjectDbContext context;
        public StudentContext(ProjectDbContext _context)
        {
            this.context = context;
        }
        public async Task CreateAsync(Student item)
        {
            try
            {
                context.Students.Add(item);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task DeleteAsync(string key)
        {
            try
            {
                Student studentdb = await context.Students.FindAsync(key);

                context.Students.Remove(studentdb);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<Student>> ReadAllAsync()
        {
            try
            {
                return await context.Students.ToListAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<Student> ReadAsync(string key)
        {
            try
            {
                return await context.Students.FindAsync(key);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task UpdateAsync(Student item)
        {
            try
            {
                Student orderFromDB = await ReadAsync(item.EGN);

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
