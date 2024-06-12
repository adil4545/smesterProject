using Microsoft.EntityFrameworkCore;
using tour_and_travel.Models;

namespace tour_and_travel.data
{
    public class addDbContext : DbContext
    {

        public addDbContext(DbContextOptions<addDbContext> options) : base(options)
        {

        }
        public DbSet<book> tour
       { get; set; }
    }
}
