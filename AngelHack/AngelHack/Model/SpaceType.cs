using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngelHack.Model
{
    [Table("SpaceType")]
    public class SpaceType
    {
        [Column("Id")]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}