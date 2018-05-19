using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.Models
{
    public class TimeSlot
    {
        public int Id { get; set; }
        public string TimeRange { get; set; }
        public DateTime Date { get; set; }
    }
}