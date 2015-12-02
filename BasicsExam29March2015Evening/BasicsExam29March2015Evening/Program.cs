using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExam29March2015Evening
{
    class Program
    {
        static void Main(string[] args)
        {
            long r = long.Parse(Console.ReadLine());
            long d = long.Parse(Console.ReadLine());
            long e = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long m = long.Parse(Console.ReadLine());

            
            double [] prices = new double[5];
            
            double rToLeva = r/(100 / 3.5);
            double dToLeva = d * 1.5;
            double eToLeva = e * 1.95;
            double bToLeva = b / (double)2;

            prices[0]=rToLeva;
            prices[1]=dToLeva;
            prices[2]=eToLeva;
            prices[3]=bToLeva;
            prices[4]=m;

            double temp = rToLeva;

            for (int i = 0; i < 5; i++ )
            {
                if(temp > prices[i])
                {
                    temp = prices[i];
                }
            }
                Console.WriteLine("{0:F2}", temp);
        }
    }
}
