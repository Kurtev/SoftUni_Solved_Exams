using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            int diameter = int.Parse(Console.ReadLine());
            int temp = diameter;
            int size = 2 * diameter + 1;
            int outerDashes = (size - (diameter+2) )/2;
            int dotsCount = 1;
            Console.WriteLine("{0}{1}{0}", new string('-', outerDashes), new string('*', diameter + 2));

            for(int i=0;i<diameter-1;i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDashes), new string('*', 1), new string('-', diameter));
            }

            for (int i = 0; i < diameter ; i++)
            {
                if (i < diameter / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDashes), new string('*', dotsCount), new string('-', temp));
                    dotsCount += 2;
                    outerDashes--;
                    temp -= 2;
                }
                if(i>=diameter/2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('-', outerDashes), new string('*', dotsCount), new string('-', temp));
                    dotsCount -= 2;
                    outerDashes++;
                    temp += 2;
                }
            }
        }
    }
}
