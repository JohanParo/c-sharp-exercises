using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public static class Helper
    {
        //Get the price of the ticket based on input age
        public static int GetTicketPrice(int age)
        {
            if (age < 20)
            {
                return 80;
            }
            else if (age > 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }
        }

        //Get the name of the ticket based on input age
        public static string GetTicketName(int age)
        {
            if (age < 20)
            {
                return "Undomspris";
            }
            else if (age > 64)
            {
                return "Pensionärspris";
            }
            else
            {
                return "Standardpris";
            }
        }
    }
}
