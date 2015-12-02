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
           

            int outerdots = N / 2;
            int ampersands = N / 2 + 1;
            int asteriks = N / 2;

            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerdots), new string('&', ampersands), new string('.', N));

            for (int i = 0; i < N / 2-1; i++)
            {
                outerdots--;
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outerdots), new string('*', asteriks), new string('.', N));
                asteriks++;
            }

            Console.WriteLine("&{0}&{1}&{0}&", new string('*', asteriks), new string('=', N));

            for(int i =0; i<N/2-1; i++)
            {
               
                asteriks--;
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', outerdots), new string('*', asteriks), new string('.', N));
                outerdots++;
                
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', outerdots), new string('&', ampersands), new string('.', N));

        }
    }
}
