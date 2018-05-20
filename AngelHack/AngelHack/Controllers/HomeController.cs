using AngelHack.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class HomeController : Controller
    {
        IBookingRepository _bookingRepository;

        public HomeController(IBookingRepository bookingRepository)
        {

            _bookingRepository = bookingRepository;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Welcome", "Home");

        }       

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your contact page.";

            var bookings = _bookingRepository.GetLastBooking(3);

            return View( bookings);
        }
    }
}