using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MIN_SENCE = 0;
            const int MAX_SENCE = 900;
            const int MIN_LIST_RNG = 0;
            const int MAX_LIST_RNG = 30;

            Random rndm = new Random();
            List<int> catalog = new List<int>();

            int rangeOfCatalog = rndm.Next(MIN_LIST_RNG, MAX_LIST_RNG);
            for (int i = 0; i < rangeOfCatalog; i++)
            {
                catalog.Add(rndm.Next(MIN_SENCE, MAX_SENCE));
            }
            Max_And_Prev_Max maxprevvalues = new Max_And_Prev_Max();

            foreach (var number in catalog)
            {
                if (number > maxprevvalues.MAX)
                {
                    maxprevvalues.SetMax(number);
                }
            }

            int ammout = 0;
            for (int i = 0; i < rangeOfCatalog; i++)
            {
                if (i % 2 == 0)
                {
                    ammout += catalog[i];
                }
            }

            foreach (var number in catalog)
            {
               Write("{0}  ", number);
            }
            WriteLine("SECOND MAX ELEMENT: {0}", maxprevvalues.PREV_MAX);
            WriteLine("AMMOUT OF ALL ELEMENTS, WHICH  DEVIDE 2: {0}", ammout);
            ReadLine();
        }
    }
}
