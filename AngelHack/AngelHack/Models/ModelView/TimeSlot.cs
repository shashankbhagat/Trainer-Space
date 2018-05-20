using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Models.ModelView
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