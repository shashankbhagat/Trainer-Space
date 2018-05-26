using AngelHack.Model.Contract;
using System.Data.Entity;


namespace AngelHack.Model.Implementation
{
    public partial class AppDbContext : DbContext, IAppDbContex
    {
        public AppDbContext() : base("name=TrainerSpace")
        {

        }

        public virtual DbSet<SpaceType> SpaceTypes { get; set; }
        public virtual DbSet<Space> Spaces { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
            modelBuilder.Entity<Space>()
                .HasRequired(w => w.Location)
                .WithMany()
                .Map(m => m.MapKey("Location"));

            modelBuilder.Entity<Space>()
             .HasRequired(w => w.SpaceType)
             .WithMany()
             .Map(m => m.MapKey("SpaceType"));
             */
        }
    }
}
