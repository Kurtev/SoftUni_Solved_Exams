using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAtCrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] board = new int [size];
            int crossroadsCount = 0;
            string input = Console.ReadLine();

            while(input.ToLower() != "end")
            {

                string[] coordinates = input.Split(' ');
                int coorY = int.Parse(coordinates[0]);
                int coorX = int.Parse(coordinates[1]);
                crossroadsCount++;

               // Console.WriteLine("{0}, {1}", coorX, coorY);
                var currentX = coorX;
                var currentY = coorY;
                board[coorY] |= 1 << coorX;
                //left-up
                for (int i = coorY-1; i >= 0; i--)
                {
                    currentX++;
                    if (currentX == size)
                    {
                        break;
                    }

                    if(((board[i]>>currentX) & 1) == 1)
                    {
                        crossroadsCount++;
                    }

                    else
                    {
                        board[i] |= 1 << currentX;
                    }
                }
                //right-up
                currentX = coorX;
                currentY = coorY;
                for (int i = coorY - 1; i >= 0; i--)
                {
                    currentX--;
                    if (currentX < 0)
                    {
                        break;
                    }

                    if (((board[i] >> currentX) & 1) == 1)
                    {
                        crossroadsCount++;
                    }

                    else
                    {
                        board[i] |= 1 << currentX;
                    }
                }
                //bottom-left
                currentX = coorX;
                currentY = coorY;
                for (int i = coorY + 1; i < size; i++)
                {
                    currentX++;
                    if (currentX == size)
                    {
                        break;
                    }

                    if (((board[i] >> currentX) & 1) == 1)
                    {
                        crossroadsCount++;
                    }

                    else
                    {
                        board[i] |= 1 << currentX;
                    }
                }

                //bottom-right
                currentX = coorX;
                currentY = coorY;
                for (int i = coorY + 1; i < size; i++)
                {
                    currentX--;
                    if (currentX < 0)
                    {
                        break;
                    }

                    if (((board[i] >> currentX) & 1) == 1)
                    {
                        crossroadsCount++;
                    }

                    else
                    {
                        board[i] |= 1 << currentX;
                    }
                }

               
                input = Console.ReadLine();

            }

            foreach (var number in board)
            {
                Console.WriteLine((uint)number);
            }
            Console.WriteLine(crossroadsCount);
        }
    }
}
