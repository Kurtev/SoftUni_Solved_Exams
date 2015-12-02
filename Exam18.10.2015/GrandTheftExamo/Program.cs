using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace GrandTheftExamo
{
    class Program
    {
        static void Main(string[] args)
        {
            int escapeAttemps = int.Parse(Console.ReadLine());
            BigInteger T = 0;
            BigInteger B = 0;
            BigInteger totalThiefesEscape = 0;
            BigInteger totalThiefesSlapped = 0;
            BigInteger Beers = 0;
            BigInteger thiefsSlapped = 0;
            for(int i=0; i<escapeAttemps;i++)
            {
                T = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());

                if (T >= 5)
                {
                    thiefsSlapped = 5;
                    totalThiefesSlapped += 5;
                }
                else
                {
                    thiefsSlapped = T;
                    totalThiefesSlapped += T;
                }

                totalThiefesEscape += T - thiefsSlapped;

              
                
                Beers += B;
            }

            BigInteger totalPacks = Beers / 6;
            BigInteger totalBeers = Beers % 6;
            Console.WriteLine("{0} thieves slapped.", totalThiefesSlapped);
            Console.WriteLine("{0} thieves escaped.", totalThiefesEscape);
            Console.WriteLine("{0} packs, {1} bottles.", totalPacks, totalBeers);


        }
    }
}
