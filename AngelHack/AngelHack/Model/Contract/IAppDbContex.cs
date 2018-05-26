using System.Data.Entity;
using AngelHack.Model;

namespace AngelHack.Model.Contract
{
    public interface IAppDbContex
    {
        DbSet<SpaceType> SpaceTypes { get; set; }
        DbSet<Space> Spaces { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Booking> Bookings { get; set; }
    }
}
