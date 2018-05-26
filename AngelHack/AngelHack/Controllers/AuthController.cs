using AngelHack.Model;
using AngelHack.Model.Contract;
using AngelHack.Utils;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class AuthController : Controller
    {
        IMembershipRepository _membershipRepository;

        public AuthController(IMembershipRepository membershipRepository)
        {
            _membershipRepository = membershipRepository;
        }

        // GET: Auth
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

        public ActionResult Index()
        {
            return View();
        }

    }
}

