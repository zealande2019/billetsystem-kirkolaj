using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Køretøj
    {
        


        public override decimal Pris()
        {
            return 125;
        }


        public override string KøretøjStatus()
        {
            return "MC";
        }
    }

}
