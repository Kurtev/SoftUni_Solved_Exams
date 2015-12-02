using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummertimeForProgrammers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int bottleTop = N + 1;
           
            int bottleBottom = N * 2;
            int bottleHeight = 3 * N + 1;
            int curve = N/2-1;
            int between = N-(1+curve);
            int whiteSpace = (bottleBottom - bottleTop) / 2;
            int whiteSpaceInside = N - 1;
            Console.WriteLine("{0}*{1}*{0}",new string(' ',whiteSpace),new string('*',N-1));

            for(int i=0;i<between;i++)
            {
                Console.WriteLine("{0}*{1}*{0}",new string(' ',whiteSpace), new string(' ', N - 1));
            }

            
            for(int i = 0; i<curve;i++)
            {
                whiteSpace--;
                whiteSpaceInside += 2;
                Console.WriteLine("{0}*{1}*{0}", new string(' ', whiteSpace), new string(' ',whiteSpaceInside));
            }
            for(int i=0; i<N*2;i++)
            {
                if(i<N)
                {
                    Console.WriteLine("*{0}*", new string('.',(N*2)-2));
                }
                else
                {
                    Console.WriteLine("*{0}*", new string('@', (N * 2) - 2));

                }
            }
            Console.WriteLine("{0}", new string('*', N * 2));
        }
    }
}
