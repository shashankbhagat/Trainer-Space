using AngelHack.Model;
using AngelHack.Model.Contract;
using AngelHack.Utils;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class HomeController : Controller
    {
        IBookingRepository _bookingRepository;
        IMembershipRepository _membershipRepository;

        public HomeController(IBookingRepository bookingRepository, IMembershipRepository membershipRepository)
        {
            _bookingRepository = bookingRepository;
            _membershipRepository = membershipRepository;
        }

        public ActionResult Index()
        {
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Welcome()
        {
            ViewBag.Message = "Your contact page.";

            Queue<int> queue = new Queue<int>();

            var bookings = _bookingRepository.GetLastBooking(4);

            return View(bookings);
        }

        public ActionResult Login()
        {
            Account a = new Account();
            return View(a);
        }

        [HttpPost]
        public ActionResult Login(Account a)
        {
            if (ModelState.IsValid)
            {
                bool result = _membershipRepository.VerifyLogin(a.UserName, a.Password);
                if (result == true)
                {
                    ViewBag.msg = "Welcome " + a.UserName;
                    SessionFacade.LOGGEDIN = a.UserName;
                    if (SessionFacade.REDIRECTURL != null)
                        return Redirect(SessionFacade.REDIRECTURL);
                }
                else
                    ViewBag.msg = "Invalid Login....";
            }
            return RedirectToAction("Welcome", "Home");
        }

    }
}