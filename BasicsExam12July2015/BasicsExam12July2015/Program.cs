using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BasicsExam12July2015
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger FG = BigInteger.Parse(Console.ReadLine());
            BigInteger FGA = BigInteger.Parse(Console.ReadLine());
            BigInteger ThreeP = BigInteger.Parse(Console.ReadLine());
            BigInteger TOV = BigInteger.Parse(Console.ReadLine());
            BigInteger ORB = BigInteger.Parse(Console.ReadLine());
            BigInteger Opp_DRB = BigInteger.Parse(Console.ReadLine());
            BigInteger FT = BigInteger.Parse(Console.ReadLine());
            BigInteger FTA = BigInteger.Parse(Console.ReadLine());

            double eFGpercent = ((double)FG + (0.5 * (double)ThreeP)) / (double)FGA;
            double TOVpercent = (double)TOV/((double)FGA + (0.44*(double)FTA)+(double)TOV);
            double ORBpercent = (double)ORB / ((double)ORB + (double)Opp_DRB);
            double FTpercent = (double)FT / (double)(FGA);

            Console.WriteLine("eFG% {0:F3}", eFGpercent);
            Console.WriteLine("TOV% {0:F3}", TOVpercent);
            Console.WriteLine("ORB% {0:F3}", ORBpercent);
            Console.WriteLine("FT% {0:F3}", FTpercent);
        }
    }
}
