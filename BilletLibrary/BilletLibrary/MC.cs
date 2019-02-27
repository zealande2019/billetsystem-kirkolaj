using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade { get; set; }

        public DateTime Dato { get; set; }


        public decimal Pris()
        {
            return 125;
        }


        public string køretøj()
        {
            return "MC";
        }
    }

}
