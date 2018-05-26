using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace AngelHack.Model
{
    [Table("Booking")]
    public class Booking
    {
        [Column("Id")]
        public int Id { get; set; }
        
        public Space Space { get; set; }                
        public Trainer Trainer { get; set; }
        public int GroupSize { get; set; }     
        public DateTime Created { get; set; }
    }
}