using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Model
{
    [Table("TimeSlot")]
    public class TimeSlot
    {
        [Column("Id")]
        public int Id { get; set; }
        public string TimeRange { get; set; }
        public DateTime Date { get; set; }

    }
}