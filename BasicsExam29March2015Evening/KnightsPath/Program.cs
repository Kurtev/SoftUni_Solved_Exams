using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int[] grid = new int[8];
            byte xPosition = 0;
            byte yPosition = 0;
            grid[0] = 1;

            while(command != "stop")
            {
                //LEFT or RIGHT
                
                if(command == "left up")
                {
                    xPosition += 2;
                    yPosition--;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition -= 2;
                        yPosition++;
                    }
                    else
                    {
                    
                        grid[yPosition] ^= (1 << xPosition);
                        // Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "left down")
                {
                    xPosition += 2;
                    yPosition++;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition -= 2;
                        yPosition--;
                    }
                    else
                    {
                        
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "right up")
                {
                    xPosition -= 2;
                    yPosition--;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition += 2;
                        yPosition++;
                    }
                    else
                    {
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "right down")
                {
                    xPosition -= 2;
                    yPosition++;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition += 2;
                        yPosition--;
                    }
                    else
                    {
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }

                //UP and DOWN
                if (command == "up left")
                {
                    xPosition++;
                    yPosition -= 2;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition--;
                        yPosition += 2;
                    }
                    else
                    {
                        
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "down left")
                {
                    xPosition++;
                    yPosition += 2;
                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition--;
                        yPosition -= 2;
                    }
                    else
                    {
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "up right")
                {
                    xPosition--;
                    yPosition -= 2;

                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition++;
                        yPosition += 2;
                    }
                    else
                    {   
                        grid[yPosition] ^= (1 << xPosition);
                        //Console.WriteLine(grid[yPosition]);
                    }
                }
                if (command == "down right")
                {
                    xPosition--;
                    yPosition += 2;

                    if (xPosition < 0 || xPosition > 7 || yPosition < 0 || yPosition > 7)
                    {
                        xPosition++;
                        yPosition -= 2;
                    }
                    else
                    {    
                        grid[yPosition] ^= (1 << xPosition);
                        // Console.WriteLine(grid[yPosition]);
                    }
                }
                
                    command = Console.ReadLine();
            }
            bool isEmpty = false;
            int counter = 0;

            for (int i = 0; i < grid.Length;i++ )
            {
                if(grid[i] != 0)
                {
                    counter++;
                }
            }

            if(counter == 0)
            {
                isEmpty = true;
            }

            if(isEmpty)
            {
                Console.WriteLine("[Board is empty]");
            }

            else
            {
                for (int i = 0; i < grid.Length; i++)
                {
                    if (grid[i] != 0)
                        Console.WriteLine(grid[i]);
                }
            }

                
        }
    }
}
