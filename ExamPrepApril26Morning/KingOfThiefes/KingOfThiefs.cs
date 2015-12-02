using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThiefes
{
    class KingOfThiefs
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char gemSymbol = Console.ReadLine()[0];

            int outerDashes = size / 2;
            int innerSymbols = 1;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(
                    "{0}{1}{0}", new string('-', outerDashes), new string(gemSymbol, innerSymbols));

                if (i < size / 2)
                {
                    outerDashes--;
                    innerSymbols += 2;
                }
                else
                {
                    outerDashes++;
                    innerSymbols -= 2;
                }
            }
        }
    }
}
