using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil
    {
        public string nummerplade { get; set; }
        public DateTime Dato { get; set; }


        public decimal pris()
        {
            return 240;
        }

        public string køretøjer()
        {
            return "Bil";
        }


    }
}
