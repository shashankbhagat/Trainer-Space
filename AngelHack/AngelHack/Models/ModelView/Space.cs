using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Models.ModelView
{
    [Table("Space")]
    public class Space
    {
        [Column("Id")]
        public int Id { get; set; }
        public int Spots { get; set; }
        [ForeignKey("Id")]
        public SpaceType SpaceType { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        [ForeignKey("Id")]
        public Location Location { get; set; }
    }
}