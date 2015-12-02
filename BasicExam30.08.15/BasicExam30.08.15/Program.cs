using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace BasicExam30._08._15
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            BigInteger workoutsPerWeek = BigInteger.Parse(Console.ReadLine());
            double BMR = 0.0d;

            BigInteger result;

            if(gender == 'm')
            {
                weight = (weight / 2.2d) * 13.75d;
                height = (height * 2.54d) * 5.003d;
                age = age * 6.755d;

                if(workoutsPerWeek <1)
                {
                    BMR = 1.2d;
                }
                else if(workoutsPerWeek>=1 && workoutsPerWeek<=3)
                {
                    BMR = 1.375d;
                }
                else if(workoutsPerWeek>=4 && workoutsPerWeek<=6)
                {
                    BMR = 1.55d;
                }
                else if(workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    BMR = 1.725d;
                }
                else if(workoutsPerWeek > 9)
                {
                    BMR = 1.9d;
                }

                result = (BigInteger)Math.Floor((66.5 + weight + height - age) * BMR);
                Console.WriteLine(result);
            }

            if (gender == 'f')
            {
                weight = (weight / 2.2d) * 9.563d;
                height = (height * 2.54d) * 1.850d;
                age = age * 4.676d;


                if (workoutsPerWeek < 1)
                {
                    BMR = 1.2d;
                }
                else if (workoutsPerWeek >= 1 && workoutsPerWeek <= 3)
                {
                    BMR = 1.375d;
                }
                else if (workoutsPerWeek >= 4 && workoutsPerWeek <= 6)
                {
                    BMR = 1.55d;
                }
                else if (workoutsPerWeek >= 7 && workoutsPerWeek <= 9)
                {
                    BMR = 1.725d;
                }
                else if (workoutsPerWeek > 9)
                {
                    BMR = 1.9d;
                }

                result = (BigInteger)Math.Floor((655 + weight + height - age) * BMR);
                Console.WriteLine(result);
            }
        }
    }
}
