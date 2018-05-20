using AngelHack.Models;
using AngelHack.Models.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.DataLayer.Repo
{
    public class BookingRepository : IBookingRepository
    {

        private readonly IAppDbContex _appDbContext;


        public BookingRepository(IAppDbContex appDbContext)
        {
            _appDbContext = appDbContext;
        }



        IList<Models.ModelView.SpaceType> IBookingRepository.GetSpaceTypes()
        {
            return _appDbContext.SpaceTypes.ToList();
        }

        public IList<BookingView> GetLastBooking(int count)
        {
            return _appDbContext.Bookings
                .Include("Space")
                .OrderByDescending(b => b.Created)
                .Take(count)
                .Select(b => new BookingView
                {
                    AvailableSpots = b.Space.Spots,
                    SpaceImgUrl = b.Space.ImageUrl,
                    SpaceTitle = b.Space.Title
                }).ToList();
        }

    }
}