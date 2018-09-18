using System;
using System.Collections.Generic;
using System.Text;
using BilletLibrary;

namespace storebaeltLibrary
{
    public class Bil : Køretøj
    {
        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }
        /// <summary>
        /// Returnerer prisen på en overkørsel
        /// Hvis det er lørdag eller søndag gives der 20% rabat,
        /// hvis der anvendes brobizz gives der yderligere 5% rabat.
        /// </summary>
        /// <param name="brobizz"></param>
        /// <returns></returns>
        public override decimal Pris(bool brobizz)
        {
            decimal sum = 0m;
            int pris = 240;
            decimal rabat = 0.05m;
            decimal weekendRabat = 0.20m;



            if (weekend(Dato))
            {
                sum = (pris - (pris * weekendRabat));
                return sum;

            }
            

            if (brobizz == true)
            {
                decimal nyPris = ((pris - (pris * rabat)));
                return nyPris;
            }

            return pris;
        }

        public bool weekend(DateTime dato)
        {
            if (dato.DayOfWeek == DayOfWeek.Saturday || dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Retunerer køretøjstypen
        /// </summary>
        /// <returns></returns>
        public override string Køretøjstype()
        {
            return "Bil";
        }
    }
}
