using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Models.ModelView
{
    [Table("Location")]
    public class Location
    {
        [Column("Id")]
        public int Id { get; set; }
        public int Name { get; set; }
    }
}