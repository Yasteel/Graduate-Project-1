using Microsoft.EntityFrameworkCore;
using Graduate_Project_1.Models;

namespace Graduate_Project_1
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Profiles> Profiles { get; set; }
    }
}
