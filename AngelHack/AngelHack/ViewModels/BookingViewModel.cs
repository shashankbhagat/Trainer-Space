
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngelHack.ViewModels
{
    public class BookingViewModel
    {
        public int Id { get; set; }

        public IEnumerable<SelectListItem> locationList { get; set; }

        [Display(Name = "Location Type")]
        public int locationSelected { get; set; }

        public IEnumerable<SelectListItem> StudioTypeList { get; set; }

        [Display(Name = "Studio Type")]
        public int StudioTypeselected { get; set; }

        public string Title { set; get; }

        public string ImageUrl { set; get; }

        public int Available { get; set; }        

        public List<SpaceViewModel> mainList { get; set; }

        public DateTime dateInOut { get; set; }
    }
}