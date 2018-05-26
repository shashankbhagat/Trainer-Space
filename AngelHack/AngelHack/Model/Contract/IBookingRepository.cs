using AngelHack.Model;
using AngelHack.ViewModels;
using System.Collections.Generic;

namespace AngelHack.Model.Contract
{
    public interface IBookingRepository
    {

        IEnumerable<SpaceType> GetSpaceTypes();
        IEnumerable<SpaceViewModel> GetLastBooking(int count);
    }
}
