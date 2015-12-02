using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWand
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int width = 3 * N + 2;
            int outerDots = width / 2;
            int innerDots = 1;

            Console.WriteLine("{0}*{0}", new string('.', width / 2));

            for(int i=0; i<N/2+1;i++)
            {
                outerDots--;
                Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots),new string('.', innerDots));
                innerDots+=2;
            }

            Console.WriteLine("{0}{1}{0}", new string('*', N), new string('.', N+2), new string('*', N));

            outerDots = 1;
            innerDots = width - 4;
            int betweenerDots = N/2;
            int beforeMiddleDots=0;
            for(int i=0; i<N-1;i++)
            {
                if(i<N/2)
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', outerDots), new string('.', innerDots));
                    if (i < N / 2 - 1)
                    {
                        outerDots++;
                        innerDots -= 2;
                    }
                }
                else
                {
                    outerDots--;
                   
                    Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}", new string('.', outerDots), new string('.', betweenerDots), new string('.',beforeMiddleDots), new string('.',N));

                    beforeMiddleDots++;
                    

                }
            }
            Console.WriteLine("{0}{1}*{2}*{1}{0}", new string('*', N / 2 + 1), new string('.', N / 2), new string('.', N));

           for(int i=0;i<N;i++)
           {
               Console.WriteLine("{0}*{0}*{0}", new string('.', N));
           }
           Console.WriteLine("{0}{1}{0}", new string('.', N), new string('*', N+2));


        }
    }
}
