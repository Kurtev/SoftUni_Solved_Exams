using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBall
{
    class Program
    {
        static void Main(string[] args)
        {

            //int a = 7;
            //a |= 0 << 1;
            //Console.WriteLine(a);
            int[] grid = new int[10];
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    grid[j] = 1023;
                }
            }
            int counts = 1;
            string command = Console.ReadLine();
            string[] inputs;
            int[] result = new int[10];
            int Sum = 0;
            while (command != "End")
            {
                inputs = command.Split(' ');

                if(counts % 2 != 0)
                {
                   result = ShootZeroes(grid, int.Parse(inputs[0]), int.Parse(inputs[1]), int.Parse(inputs[2]));
                }
                else
                {
                  result =  ShootOnes(grid, int.Parse(inputs[0]), int.Parse(inputs[1]), int.Parse(inputs[2]));
                }

                counts++;
                command = Console.ReadLine();

            }

            for (int i = 0; i < result.Length; i++)
            {
                Sum += result[i];
                
            }
            Console.WriteLine(Sum);
        }

        static int[] ShootZeroes(int[] grid, int coorA, int coorB, int size)
        {
            int startX = Math.Max(coorB - size, 0);
            int startY = Math.Max(coorA - size, 0);
            int endX = Math.Min(coorB + size, 9);
            int endY = Math.Min(coorA + size, 9);

            for(int i=startY; i <= endY; i++)
            {
                for(int j=startX; j <= endX; j++)
                {
                   
                        //number ^= (-x ^ number) & (1 << n);
                        grid[i] ^= (-0 ^ grid[i]) & (1 << j);
                    
                }
            }
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    Console.Write(grid[i]);
            //    Console.WriteLine();
            //}
            return grid;
        }

        static int[] ShootOnes(int[] grid, int coorA, int coorB, int size)
        {
            int startX = Math.Max(coorB - size, 0);
            int startY = Math.Max(coorA - size, 0);
            int endX = Math.Min(coorB + size, 9);
            int endY = Math.Min(coorA + size, 9);

            for (int i = startY; i <= endY; i++)
            {
                for (int j = startX; j <= endX; j++)
                {

                    //number ^= (-x ^ number) & (1 << n);
                    grid[i] ^= (-1 ^ grid[i]) & (1 << j);

                }
            }
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    Console.Write(grid[i]);
            //    Console.WriteLine();
            //}
            return grid;
        }
    }
}
