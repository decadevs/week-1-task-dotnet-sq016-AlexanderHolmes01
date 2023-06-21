using Microsoft.EntityFrameworkCore;


namespace Coco
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            InitalizeContext();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BankDb");


            base.OnConfiguring(optionsBuilder);
        }

        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }



        public DbSet<CustomerDetails> CustomerDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<CustomerDetails>().HasKey(u => new { u.CustomerId });


            base.OnModelCreating(modelBuilder);
        }
    }
}
