using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TP4.Models;

namespace TP4.Data
{
    public class UniversityContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        private static UniversityContext Context = null;

        public static UniversityContext GetContext()
        {
            if(Context == null)
            {
                Context = Instantiate_UniversityContext();
            }
            return Context;
        }

        public UniversityContext(DbContextOptions o) : base(o) {}
        public static UniversityContext Instantiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\Mehdi\\Downloads\\TP4-master\\TP4-master\\db\\database.db");
            Debug.WriteLine("********************************************** Entred in Instantiate_ **********************************************");
            return new UniversityContext(optionsBuilder.Options);
        }
    }
}
