using AngelHack.Model.Contract;
using System.Data.Entity;

namespace AngelHack.Model.Implementation
{
    public partial class AppDbContext : DbContext, IAppDbContex
    {
        public AppDbContext() : base("name=TrainerSpace")
        { }
        
        public virtual DbSet<SpaceType> SpaceTypes { get; set; }
        public virtual DbSet<Space> Spaces { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Location> Locations { get; set; }        
    }
}
