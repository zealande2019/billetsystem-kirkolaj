using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace BilletLibrary
{
    public abstract class Køretøj
    {
        private string _nummerplade;
        public string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length <= 7 && value.Length > 0)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new ArgumentException("Nummerplade skal være mellem 1-7 tegn");
                }
            }
        }
        public DateTime Dato { get; set; }

        public abstract Decimal Pris();

        public abstract string KøretøjStatus();

    }
}
