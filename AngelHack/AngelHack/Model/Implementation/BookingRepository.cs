using AngelHack.Model.Contract;
using AngelHack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.Model.Implementation
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IAppDbContex _appDbContext;

        public BookingRepository(IAppDbContex appDbContext)
        {
            _appDbContext = appDbContext;
        }

        IEnumerable<SpaceType> IBookingRepository.GetSpaceTypes()
        {
            return _appDbContext.SpaceTypes.ToList();
        }

        public IEnumerable<SpaceViewModel> GetLastBooking(int count)
        {
            return _appDbContext.Bookings
                .Include("Space")
                .OrderByDescending(b => b.Created)
                .Take(count)
                .Select(b => new SpaceViewModel
                {
                    ImageUrl = b.Space.ImageUrl,
                    Title = b.Space.Title,
                    Id = b.Space.Id
                }).ToList();
        }

    }
}