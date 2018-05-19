using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngelHack.Utils
{
    public class SessionFacade
    {
        static readonly string loggedin = "LOGGEDIN";
        public static string LOGGEDIN
        {
            get
            {
                if (HttpContext.Current.Session[loggedin] != null)
                    return (string)HttpContext.Current.Session[loggedin];
                else
                    return null;
            }
            set
            {
                HttpContext.Current.Session[loggedin] = value;
            }
        }

        static readonly string redirecturl = "REDIRECTURL";
        public static string REDIRECTURL
        {
            get
            {
                if (HttpContext.Current.Session[redirecturl] != null)
                    return (string)HttpContext.Current.Session[redirecturl];
                else
                    return null;
            }
            set
            {
                HttpContext.Current.Session[redirecturl] = value;
            }
        }
    }
}