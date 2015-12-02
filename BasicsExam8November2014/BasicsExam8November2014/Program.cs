using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExam8November2014
{
    class Program
    {
        static void Main(string[] args)
        {
            string Passengers = Console.ReadLine();
            string[] firstClassPassengers = Passengers.Split(' ');

            string PassengersFreq = Console.ReadLine();
            string[] freqPassengers = PassengersFreq.Split(' ');

            string PassengersMeal = Console.ReadLine();
            string[] mealPassengers = PassengersMeal.Split(' ');


            int[] first = new int[3];
            int[] second = new int[3];
            int[] third = new int[3];

            double resultFirst = 0;
            double resultSecond = 0;
            double resultThird = 0;

            double full = (12 * 7000 + (7000 * 0.005) * 12) + (28 * 3500 + (3500 * 0.005) * 28) + (50 * 1000 + (1000 * 0.005) * 50);

            for (int i = 0; i < 3; i++)
            {
                first[i] = int.Parse(firstClassPassengers[i]);
                second[i] = int.Parse(freqPassengers[i]);
                third[i] = int.Parse(mealPassengers[i]);
            }

   
              resultFirst = (first[0] - (first[1] + first[2])) * 7000;
              resultFirst = resultFirst + (7000 * 0.3) * first[1];
              resultFirst = resultFirst + (first[2] * 7000) + (7000 * 0.005)*first[2];

              resultSecond = (second[0] - (second[1] + second[2])) * 3500;
              resultSecond = resultSecond + (3500 * 0.3) * second[1];
              resultSecond = resultSecond + (second[2] * 3500) + (3500 * 0.005) * second[2];


              resultThird = (third[0] - (third[1]+third[2])) * 1000;
              resultThird = resultThird + (1000 * 0.3) * third[1];
              resultThird = resultThird + (third[2] * 1000) + (1000 * 0.005) * third[2];

              int res = (int)(resultFirst + resultSecond + resultThird);
              full = full - res;
              Console.WriteLine(res);
              Console.WriteLine(full);
           
            

        }
    }
}
