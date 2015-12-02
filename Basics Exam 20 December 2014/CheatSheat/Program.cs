using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CheatSheat
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            BigInteger vNum = int.Parse(Console.ReadLine());
            BigInteger hNum = int.Parse(Console.ReadLine());


            BigInteger[,] cheatSheet = new BigInteger[rows, cols];

            for(int i = 0; i<cheatSheet.GetLength(0); i++)
            {
                BigInteger temp = hNum;
                for(int j = 0; j<cheatSheet.GetLength(1); j++)
                {
                    
                    cheatSheet[i, j] = vNum * temp;
                    temp++;
                    if (j < cheatSheet.GetLength(1) - 1)
                    {
                        Console.Write("{0} ", cheatSheet[i, j]);
                    }
                    else
                    {
                        Console.Write("{0}", cheatSheet[i, j]);
                    }
                }
                if (i < cheatSheet.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    vNum++;
                }
            }


        }
    }
}
