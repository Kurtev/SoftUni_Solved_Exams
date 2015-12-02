using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Bohemcho
{
    class Program
    {
        static void Main(string[] args)
        {
            string floor = Console.ReadLine();
            BigInteger floors = 0;
            List<BigInteger> floorsList = new List<BigInteger>();
            int lightsCount = 0;

            while (floor != "Stop, God damn it")
            {
                int[] apartaments = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                floors = long.Parse(floor);

                for (int i = 0; i < apartaments.Length; i++)
                {
                        floors ^=  ((BigInteger)1 << apartaments[i]);
                }
        
                floorsList.Add(floors);
                floor = Console.ReadLine();
            }

            BigInteger result = 0;
            string binary = string.Empty;

            for (int i = 0; i < floorsList.Count; i++)
            {
                result += floorsList[i];
                while (floorsList[i] > 0)
                {
                    if (floorsList[i] % 2 == 0)
                    {
                        binary += '0';
                    }
                    else
                    {
                        binary += '1';
                        lightsCount++;
                    }
                    floorsList[i] /= 2;
                }
            }

            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", lightsCount, result);
        }
    }
}