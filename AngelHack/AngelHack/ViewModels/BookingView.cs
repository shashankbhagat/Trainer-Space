using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.ViewModels
{
    public class BookingView
    {
        public string SpaceTitle  {get; set; }
        public string SpaceImgUrl { get; set; }
        public int AvailableSpots { get; set; }     
    }
}