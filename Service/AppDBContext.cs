using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Service
{
   public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Faculty> faculties { get; set; }


    }
}
