using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {

        public string nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public abstract Decimal Pris();

        public abstract string KøretøjStatus();

    }
}
