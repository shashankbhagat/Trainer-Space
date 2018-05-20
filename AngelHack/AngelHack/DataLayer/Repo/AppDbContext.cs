using System.Data.Entity;
using AngelHack.Models.ModelView;

namespace AngelHack.DataLayer.Repo
{
    public partial class AppDbContext : DbContext, IAppDbContex
    {
        public AppDbContext() : base("name=TrainerSpace")
        {

        }

        public virtual DbSet<Models.ModelView.SpaceType> SpaceTypes { get; set; }
        public virtual DbSet<Models.ModelView.Space> Spaces { get; set; }
        public virtual DbSet<Models.ModelView.Booking> Bookings { get; set; }

    }
}
