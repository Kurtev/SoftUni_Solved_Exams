using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoklQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int innerDots = N;
            int outerDots = N;
            int asteriks = N;
            Console.WriteLine("{0}{1}{0}", new string('.', N), new string('*', N), new string('.', N));

         


            for(int i = 0; i<N/2; i++)
            {
                innerDots += 2;
                outerDots -= 2;
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerDots), new string('*', 1), new string('.', innerDots));
                innerDots += 2;
            }

            innerDots = N;
            outerDots = N;
            asteriks = N;
            int mostOuter = 1;

            for (int i = 0; i < N / 2; i++)
            {
                outerDots -= 2;
                if (i == 0)
                {

                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', outerDots), new string('.', innerDots));
                }
                else
                {
                   
                    Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}", new string('*', 1), new string('.', outerDots), new string('.', mostOuter), new string('.',innerDots));
                    mostOuter+=2;
                }
            }

            innerDots = N;
            outerDots = N-1;
            asteriks = N;

            for(int i=0;i<N-1;i++)
            {
                
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerDots), new string('*', 1), new string('.', innerDots));
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine("{0}", new string('*', N * 3));
        }
    }
}
