using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_Exam_20_December_2014
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int  daysinMont = 30;

            int TankPrise = int.Parse(Console.ReadLine());
            int partyDays = int.Parse(Console.ReadLine());

            int savingDays = 30 - partyDays;
            int savedMoney = savingDays * 2;
            int spendedMoney = partyDays * 5;

            int all = savedMoney - spendedMoney;

            if(all > 0)
            {

                double result = (double)TankPrise / all;
                int neededTime = (int)Math.Ceiling(result);

                int Years = neededTime / 12;
                int Month = neededTime % 12;

                Console.WriteLine("{0} years, {1} months", Years, Month);
            }

            else
            {
                Console.WriteLine("never");
            }

        }
    }
}
