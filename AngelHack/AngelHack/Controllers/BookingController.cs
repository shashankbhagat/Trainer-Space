using AngelHack.Model.Contract;
using AngelHack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            BookingViewModel mvm = new BookingViewModel
            {
                locationList = _spaceRepository.GetLocations(),
                StudioTypeList = _spaceRepository.GetSpaceTypes(),
                mainList = _spaceRepository.GetAlailableSpaces(0, 0).ToList()
            };           
            return View(mvm);
        }


        public ActionResult MainAJAX(int locationSelected, int StudioTypeselected, string dateInOut)
        {
            List<SpaceViewModel> mvmList = new List<SpaceViewModel>();
            try
            {
                mvmList = _spaceRepository.GetAlailableSpaces(StudioTypeselected, locationSelected)                   
                    .ToList();
            }
            catch (Exception e)
            {
                // log error
            }
            return PartialView("_Main", mvmList);
        }

        public ActionResult AddBooking(int id)
        {

            return PartialView("_AddBooking", "");
        }
    }
}