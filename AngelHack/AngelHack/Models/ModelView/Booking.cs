using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Models.ModelView
{
    [Table("Booking")]
    public class Booking
    {
        [Column("Id")]
        public int Id { get; set; }

        [ForeignKey("Id")]
        public Space Space { get; set; }

        [ForeignKey("Id")]
        public Trainer Trainer { get; set; }

        public int GroupSize { get; set; }
     
        public DateTime Created { get; set; }
    }
}