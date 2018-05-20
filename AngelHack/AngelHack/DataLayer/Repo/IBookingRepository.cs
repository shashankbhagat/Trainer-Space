
using AngelHack.Models.ModelView;
using System.Collections.Generic;


namespace AngelHack.DataLayer
{
    public interface IBookingRepository
    {

        IList<Models.ModelView.SpaceType> GetSpaceTypes();
        IList<BookingView> GetLastBooking(int count);
       

    }
}
