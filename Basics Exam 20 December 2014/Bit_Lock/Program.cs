using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] board = new int[8];
            int colToCheck=0;
            int temp = 0;
            int ee;
            List<int> checkList = new List<int>();
            string[] colsToAttack = Console.ReadLine().Split(' ');

            for(int i=0; i<8 ; i++)
            {
                board[i] = int.Parse(colsToAttack[i]);
            }
           
           string command = Console.ReadLine();

           while (command.ToLower() != "end")
            {
                if (command.ToLower().Contains("check"))
                {
                    command = command.Replace("check ", "");
                    for (int i = 0; i < board.Length; i++)
                    {
                        ee=int.Parse(command);
                        if((board[i] >> ee & 1) == 1)
                        {
                            temp++;
                        }
                    }
                    checkList.Add(temp);
                    temp = 0;
                }

                if (command.ToLower().Contains("right"))
                {
                    command = command.Replace(" right", "");
                    string[] numbers = command.Split(' ');
                    int[] intNumbers = new int[2];

                    intNumbers[0] = int.Parse(numbers[0]);
                    intNumbers[1] = int.Parse(numbers[1]);

                    
                    int iterations = 1;

                    while(iterations<=intNumbers[1])
                    {
             
                        if ((board[intNumbers[0]] & 1) == 1)
                        {
                            board[intNumbers[0]] = board[intNumbers[0]] >> 1;
                            board[intNumbers[0]] ^= (-1 ^ board[intNumbers[0]]) & (1 << 11);
              
                        }

                        else if ((board[intNumbers[0]] & 1) == 0)
                        {
                            board[intNumbers[0]] = board[intNumbers[0]] >> 1;
                            board[intNumbers[0]] ^= (-0 ^ board[intNumbers[0]]) & (1 << 11);
       
                        }
                        iterations++;
                    }
                }

                if (command.ToLower().Contains("left"))
                {
                    command = command.Replace(" left", "");
                    string[] numbers = command.Split(' ');
                    int[] intNumbers = new int[2];

                    intNumbers[0] = int.Parse(numbers[0]);
                    intNumbers[1] = int.Parse(numbers[1]);

                    int iterations = 1;

                    while (iterations <= intNumbers[1])
                    {
                        int count = 1;
                        if (((board[intNumbers[0]] >> 11) & 1) == 1)
                        {
                            board[intNumbers[0]] = board[intNumbers[0]] << 1;
                            board[intNumbers[0]] ^= (-1 ^ board[intNumbers[0]]) & (1 << 0);
                            board[intNumbers[0]] ^= (-0 ^ board[intNumbers[0]]) & (1 << 12);
                            count++;
                        }

                        else if (((board[intNumbers[0]] >> 11) & 1) == 0)
                        {
                            board[intNumbers[0]] = board[intNumbers[0]] << 1;
                            board[intNumbers[0]] ^= (-0 ^ board[intNumbers[0]]) & (1 << 0);
                            board[intNumbers[0]] ^= (-0 ^ board[intNumbers[0]]) & (1 << 12);
                            count++;
                        }
                        iterations++;
                    }

                }


                command = Console.ReadLine();
           }

           foreach (var item in checkList)
           {
               Console.WriteLine(item);
           }
           foreach (var item in board)
           {
               Console.Write(item +" ");
           }
        }
    }
}
