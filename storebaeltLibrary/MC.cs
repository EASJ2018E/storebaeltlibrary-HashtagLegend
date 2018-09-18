using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace storebaeltLibrary
{
    public class MC : Køretøj
    {
        public MC(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        /// <summary>
        /// Returnere prisen på en overkørsel
        /// Hvis der er anvendt brobizz gives der 5% rabat på overkørslen
        /// </summary>
        /// <returns></returns>
        public override decimal Pris(bool brobizz)
        {
            int pris = 125;
            decimal rabat = 0.05m;

            if (brobizz == true)
            {
                decimal nyPris = ((pris - (pris * rabat)));
                return nyPris;
            }

            return pris;
        }

        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string Køretøjstype()
        {
            return "MC";
        }
    }
}
