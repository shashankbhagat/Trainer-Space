using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.ViewModels
{
    public class SpaceViewModel
    {
        public int Id { get; set; }
        
        public string Title { set; get; }

        public string ImageUrl { set; get; }

        public int IsAvailable { get; set; }
    }
}