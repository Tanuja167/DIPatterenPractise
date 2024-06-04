using DIPatterenPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPatterenPractise.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op): base(op)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
