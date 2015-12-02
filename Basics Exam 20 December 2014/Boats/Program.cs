using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boats
{
    class Program
    {
        static void Main(string[] args)
        {
            int BoatSize = int.Parse(Console.ReadLine());

            int dots=BoatSize-1;
            int asteriks = -1;

            for (int i = 0; i < BoatSize/2; i++)
            {
                asteriks += 2;
                Console.WriteLine("{0}{1}{2}", new String('.', dots), new String('*', asteriks), new String('.', BoatSize));
                dots -= 2;
            }

            Console.WriteLine("{0}{1}{2}", new String('.', 0), new String('*', BoatSize), new String('.', BoatSize));

            asteriks = BoatSize-2;
            dots = 0;

            for (int i = 0; i <  BoatSize / 2; i++)
            {
                dots += 2;
                Console.WriteLine("{0}{1}{2}", new String('.', dots), new String('*', asteriks), new String('.', BoatSize));
                asteriks -= 2;
            }

           
            asteriks = BoatSize*2;
            dots = 0;

            for (int i = 0; i < BoatSize / 2; i++)
            {
                
                Console.WriteLine("{0}{1}{2}", new String('.', dots), new String('*', asteriks), new String('.', dots));
                asteriks -= 2;
                dots += 1;
            }

        }
    }
}
