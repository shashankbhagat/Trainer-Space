using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.Models
{
    public class MainVM
    {
        public int Id { get; set; }

        public List<SelectListItem> locationList { get; set; }
        public string locationSelected { get; set; }

        public List<SelectListItem> StudioTypeList { get; set; }
        public string StudioTypeselected { get; set; }

        public string Title { set; get; }

        public string ImageUrl { set; get; }

        public int Available { get; set; }

        public int mainListCount { get; set; }

        public List<MainVM> mainList { get; set; }

        public string dateInOut { get; set; }
    }
}