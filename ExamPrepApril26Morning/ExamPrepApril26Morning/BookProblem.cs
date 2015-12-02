using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExamPrepApril26Morning
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            BigInteger pages = int.Parse(Console.ReadLine());
            int campingDays = int.Parse(Console.ReadLine());
            int pagesRead = int.Parse(Console.ReadLine());

            var Months = CalculateMonths(pages, campingDays, pagesRead);
            if (Months > 0)
            {
                int Years = Months / 12;
                int months = Months % 12;



                Console.WriteLine("{0} " + "years " + "{1} " + "months", Years, months);

            }

        }

        public static int CalculateMonths(BigInteger pages, int campingDays, int pagesRead)
        {

            int normalDays = 30 - campingDays;
            if (normalDays == 0)
            {
                Console.WriteLine("never");
                return 0;
            }
            pagesRead *= normalDays;
            int result = (int)Math.Ceiling((double)pages / pagesRead);
            return result;
        }
    }
}
