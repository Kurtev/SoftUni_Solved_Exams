using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExam19December2014
{
    class Program
    {
        static void Main(string[] args)
        {

            string yearType = Console.ReadLine();
            if(yearType == "leap")
            {
                int travelMonths = int.Parse(Console.ReadLine());
                int homeMonths = int.Parse(Console.ReadLine());
                double normalMonths = (12 * (12 - (travelMonths + homeMonths))) *((double)3 / 5);
                travelMonths = 12 * travelMonths;
                homeMonths = 4 * homeMonths;

               
                double percent = (normalMonths + travelMonths + homeMonths) * ((double)5 / 100);

                normalMonths = normalMonths + travelMonths + homeMonths + percent;

                int result = (int)normalMonths;
                Console.WriteLine(result);
            }


            if (yearType == "normal")
            {
                int travelMonths = int.Parse(Console.ReadLine());
                int homeMonths = int.Parse(Console.ReadLine());
                double normalMonths = (12 * (12 - (travelMonths + homeMonths))) * ((double)3 / 5);
                travelMonths = 12 * travelMonths;
                homeMonths = 4 * homeMonths;

                normalMonths = normalMonths + travelMonths + homeMonths;

                int result = (int)normalMonths;
                Console.WriteLine(result);

            }
        }
    }
}
