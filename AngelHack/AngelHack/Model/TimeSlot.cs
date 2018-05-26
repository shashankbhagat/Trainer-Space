using System;
using System.ComponentModel.DataAnnotations.Schema;

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