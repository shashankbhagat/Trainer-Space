using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Model
{
    [Table("Location")]
    public class Location
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}