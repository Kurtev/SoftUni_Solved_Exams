using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam18._10._2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int albumsSoldInEurope = int.Parse(Console.ReadLine());
            decimal albumPriceEUR = decimal.Parse(Console.ReadLine());
            int albumsSoldInNAmerica = int.Parse(Console.ReadLine());
            decimal albumPriceDOL = decimal.Parse(Console.ReadLine());
            int albumsSoldInSAmerica = int.Parse(Console.ReadLine());
            decimal albumPricePES = decimal.Parse(Console.ReadLine());
            int concertsDuringTour = int.Parse(Console.ReadLine());
            decimal concertProfit = decimal.Parse(Console.ReadLine());




            decimal euProfit = albumsSoldInEurope * (albumPriceEUR * (decimal)1.94);
            decimal naProfit = albumsSoldInNAmerica * (albumPriceDOL * (decimal)1.72);
            decimal saProfit = albumsSoldInSAmerica * (albumPricePES / (decimal)332.74);
            decimal totalConcertsProfit = concertsDuringTour * (concertProfit * (decimal)1.94);


            decimal totalIncomeFromDiscs = (euProfit + naProfit + saProfit);
            decimal producerIncome = totalIncomeFromDiscs * (decimal)0.35;
            totalIncomeFromDiscs -= producerIncome;
            decimal taxes = totalIncomeFromDiscs * (decimal)0.2f;

            totalIncomeFromDiscs -= taxes;

            if(totalConcertsProfit > 100000)
            {
                totalConcertsProfit = totalConcertsProfit - (totalConcertsProfit * (decimal)0.15);
            }


            if(totalIncomeFromDiscs > totalConcertsProfit)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalIncomeFromDiscs);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", totalConcertsProfit);
            }
           
        }
    }
}
