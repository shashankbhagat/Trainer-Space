using AngelHack.Model.Contract;
using AngelHack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class BookingController : Controller
    {
        ISpaceRepository _spaceRepository;

        public BookingController(ISpaceRepository spaceRepository)
        {
            _spaceRepository = spaceRepository;
        }

        // GET: Booking
        public ActionResult Main()
        {
            BookingViewModel bookingViewModel = new BookingViewModel
            {
                locationList = _spaceRepository.GetLocations(),
                StudioTypeList = _spaceRepository.GetSpaceTypes(),
                mainList = _spaceRepository.GetAlailableSpaces(0, 0, null).ToList()
            };
            return View(bookingViewModel);
        }

        public ActionResult FilterChanged(int locationSelected, int studioTypeselected, DateTime date)
        {
            List<SpaceViewModel> mvmList;

            try
            {
                mvmList = _spaceRepository
                    .GetAlailableSpaces(studioTypeselected, locationSelected, date)
                    .ToList();
            }
            catch (Exception e)
            {
                mvmList = new List<SpaceViewModel>();
            }
            return PartialView("_Main", mvmList);
        }


        public ActionResult AddBooking(int id)
        {

            return PartialView("_AddBooking", "");
        }
    }
}