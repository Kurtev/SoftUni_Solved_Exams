using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam29March2015Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMbs = int.Parse(Console.ReadLine());
            int cinemaPrice = int.Parse(Console.ReadLine());
            int wifeSpending = int.Parse(Console.ReadLine());

            double downloadTime = (((double)totalMbs / (double)2) / (double)60) / (double)60;
            decimal priceForDownload = (decimal)downloadTime * wifeSpending;
            double numberOfMoviesDownloaded = (double)totalMbs / 1500;
            decimal totalCinemaPrice = (decimal)numberOfMoviesDownloaded * cinemaPrice;

            priceForDownload = Math.Round(priceForDownload, 2);
            totalCinemaPrice = Math.Round(totalCinemaPrice, 2);

            if (priceForDownload == totalCinemaPrice)
            {
                Console.WriteLine("mall -> {0}lv", priceForDownload);
            }
            else
            {
                Console.WriteLine("{0} -> {1:F2}lv",
                    priceForDownload > totalCinemaPrice ? "cinema" : "mall"
                    , priceForDownload > totalCinemaPrice ? totalCinemaPrice : priceForDownload);
            }
        }
    }
}
