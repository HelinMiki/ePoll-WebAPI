using Microsoft.EntityFrameworkCore;

namespace ePollAPI.Models
{
    public class PollDbContext : DbContext
    {
        //Database constructor
        public PollDbContext(DbContextOptions<PollDbContext> options) : base(options)
        {

        }
        public DbSet<Poll> Polls { get; set; }

        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Database relations
            modelBuilder.Entity<Option>()
                .HasOne(p => p.Poll)
                .WithMany(b => b.Options)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
