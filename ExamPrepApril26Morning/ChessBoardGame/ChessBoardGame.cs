using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    class ChessBoardGame
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[] inputText = Console.ReadLine().ToCharArray();
            int count = 0;
            int[,] board = new int[size, size];
            int blacks = 0;
            int whites = 0;
            bool blackTurn = true;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for(int j =0; j<board.GetLength(1); j++)
                {
                    if(count < inputText.Length)
                    {
                        if (blackTurn == true)
                        {
                            if (char.IsLower(inputText[count]) || char.IsDigit(inputText[count]))
                            {
                                blacks += inputText[count];
                            }

                            else if (char.IsLetter(inputText[count]))
                            {
                                whites += inputText[count];
                            }


                            blackTurn = false;
                        }
                        else if (blackTurn == false)
                        {
                            if (char.IsLower(inputText[count]) || char.IsDigit(inputText[count]))
                            {
                                whites += inputText[count];
                            }


                            else if (char.IsLetter(inputText[count]))
                            {
                                blacks += inputText[count];
                            }

                            blackTurn = true;
                        }

                        count++;
                    }
                }
            }
            if ((blacks - whites) == 0)
            {
                Console.WriteLine("Equal result: {0}", blacks);
            }
            else
            {


                string winner = blacks > whites ? "The winner is: black team" : "The winner is: white team";
                int difference = blacks > whites ? blacks - whites : whites - blacks;

                Console.WriteLine(winner);
                Console.WriteLine(difference);
            }
        }
    }
}
