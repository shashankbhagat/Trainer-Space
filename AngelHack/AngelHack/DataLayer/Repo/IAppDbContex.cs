using System.Data.Entity;


namespace AngelHack.DataLayer.Repo
{
    public interface IAppDbContex
    {
        DbSet<Models.ModelView.SpaceType> SpaceTypes { get; set; }
        DbSet<Models.ModelView.Space> Spaces { get; set; }
        DbSet<Models.ModelView.Booking> Bookings { get; set; }
    }
}
