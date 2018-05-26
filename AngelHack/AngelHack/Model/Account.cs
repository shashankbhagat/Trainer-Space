using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
    }
}