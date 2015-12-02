using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            Dictionary<string, int> monthLenght = new Dictionary<string, int>(){

                {"Jan", 31},
                {"Feb", 28},
                {"March", 31},
                {"Apr", 30},
                {"May", 31},
                {"June", 30},
                {"July", 31},
                {"Aug", 31},
                {"Sept", 30},
                {"Oct", 31},
                {"Nov", 30},
                {"Dec", 31}

            };

            //string month = input[0];
            double payPerHour = double.Parse(input[1]);
            int workingHours = int.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);
            double difference = 0.0;
            decimal paying = (decimal)0.0;

            paying = (decimal)((monthLenght[input[0]] - 10) * payPerHour * workingHours);

            if(paying>700)
            {
                paying = (decimal)(paying + (paying * (decimal)0.1));
            }

            if(itemPrice > paying)
            {
                itemPrice = (decimal)(itemPrice - paying);
                Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice);
            }
            else
            {
                paying -= itemPrice;
                Console.WriteLine("Money left = {0:F2} leva.", paying);
            }

        }
    }
}
