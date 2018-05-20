using AngelHack.DataLayer;
using AngelHack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Main()
        {
            MainVM mvm = new MainVM();
            mvm.locationList = RepositoryMain.getLocations();
            mvm.locationSelected = mvm.locationList[0].Value;
            mvm.StudioTypeList = RepositoryMain.getStudioType();
            mvm.StudioTypeselected = mvm.StudioTypeList[0].Value;
            mvm.mainListCount = RepositoryMain.getSpacewithAvailibility(mvm.locationSelected, mvm.StudioTypeselected).Count;
            mvm.mainList = RepositoryMain.getSpacewithAvailibility(mvm.locationSelected, mvm.StudioTypeselected);
            
            return View(mvm);
        }

        
        public ActionResult MainAJAX(string locationSelected, string StudioTypeselected)
        {
            List<MainVM> mvmList = null;
            try
            {
                mvmList = RepositoryMain.getSpacewithAvailibility(locationSelected, StudioTypeselected);
            }
            catch(Exception)
            {
                throw;
            }
            return PartialView("_Main", mvmList);
        }
    }
}