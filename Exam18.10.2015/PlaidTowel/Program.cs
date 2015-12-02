using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char filling = char.Parse(Console.ReadLine());
            char rombs = char.Parse(Console.ReadLine());

            int outer = size;
            int inbetween = 1;
            int inner = size + (size - 1);

            Console.WriteLine("{0}{1}{2}{1}{0}", new string(filling, size), new string(rombs, 1), new string(filling, inner));

            int tempInner = inner;
            int tempOuter = outer;
            int tempInbetween = inbetween;
            for(int i=0; i<size-1;i++)
            {
                tempInner -= 2;
                tempOuter--;
                
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(filling, tempOuter), new string(rombs, 1), new string(filling, tempInbetween), new string(filling,tempInner));
                tempInbetween+=2;
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", new string(rombs, 1), new string(filling, inner));

            for (int i = 0; i < size - 1; i++)
            {

                tempInbetween -= 2;
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(filling, tempOuter), new string(rombs, 1), new string(filling, tempInbetween), new string(filling, tempInner));
                
                tempInner += 2;
                tempOuter++;
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(filling, size), new string(rombs, 1), new string(filling, inner));
            for (int i = 0; i < size - 1; i++)
            {
                tempInner -= 2;
                tempOuter--;

                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(filling, tempOuter), new string(rombs, 1), new string(filling, tempInbetween), new string(filling, tempInner));
                tempInbetween += 2;
            }

            Console.WriteLine("{0}{1}{0}{1}{0}", new string(rombs, 1), new string(filling, inner));

            for (int i = 0; i < size - 1; i++)
            {

                tempInbetween -= 2;
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string(filling, tempOuter), new string(rombs, 1), new string(filling, tempInbetween), new string(filling, tempInner));

                tempInner += 2;
                tempOuter++;
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string(filling, size), new string(rombs, 1), new string(filling, inner));
        }
    }
}
