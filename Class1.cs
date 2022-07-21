using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Basics
{
    class Class1
    {

        public static void DateOperations()
        {
            DateTime aDay = DateTime.Now;
            TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
            DateTime aDayAfterAMonth = aDay.Add(aMonth);
            DateTime aDayBeforeAMonth = aDay.Subtract(aMonth);
            Console.WriteLine("{0:dddd}", aDayAfterAMonth);
            Console.WriteLine("{0:dddd}", aDayBeforeAMonth);

        }
    }
}
