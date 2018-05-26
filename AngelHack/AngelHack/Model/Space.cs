using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace AngelHack.Model
{
    [Table("Space")]
    public class Space
    {
        [Column("Id")]

        public int Id { get; set; }

        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public int Spots { get; set; }
               
        public SpaceType SpaceType { get; set; }        
        public Location Location { get; set; }
    }
}