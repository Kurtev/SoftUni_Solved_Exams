using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] players = new string[2];
            players[0] = Console.ReadLine();

            if(players[0] == "Simeon")
            {
                players[1] = "Nakov";
            }
            else
            {
                players[1] = "Simeon";
            }

            int numberOfRounds = int.Parse(Console.ReadLine());
            int count = 1;
            int turn = 0;
            int[] playerPoints = new int[2];
            int pointsTry = 0;
            string succorFail = string.Empty;
            string switchPlayers;
            int switchPoints = 0;
            int playerTurn = -1;

            while (count <= numberOfRounds)
            {

                if (turn < 2)
                {
                    pointsTry = int.Parse(Console.ReadLine());
                    succorFail = Console.ReadLine();

                    if (succorFail == "success")
                    {
                        playerPoints[turn] += pointsTry;
                        
                        if(playerPoints[turn] == 500)
                        {
                            break;
                        }

                        if(playerPoints[turn] > 500)
                        {
                            playerPoints[turn] -= pointsTry;
                        }
                    }
                    turn++;
                }

                else
                {
                    turn = 0;
                    count++;

                    switchPlayers = players[0];
                    players[0] = players[1];
                    players[1] = switchPlayers;

                    switchPoints = playerPoints[0];
                    playerPoints[0] = playerPoints[1];
                    playerPoints[1] = switchPoints;
                }

            }

            if(playerPoints[0] == 500)
            {
                Console.WriteLine(players[0]);
                Console.WriteLine(count);
                Console.WriteLine(playerPoints[1]);
            }

            if (playerPoints[1] == 500)
            {
                Console.WriteLine(players[1]);
                Console.WriteLine(count);
                Console.WriteLine(playerPoints[0]);
            }

            if(playerPoints[0] == playerPoints[1])
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(playerPoints[0]);
            }

            if ((playerPoints[0] != playerPoints[1]) && playerPoints[0] < 500 && playerPoints[1] < 500)
            {
                if(playerPoints[0] > playerPoints[1])
                {
                    Console.WriteLine(players[0]);
                    Console.WriteLine(playerPoints[0] - playerPoints[1]);
                }
                else
                {
                    Console.WriteLine(players[1]);
                    Console.WriteLine(playerPoints[1] - playerPoints[0]);
                }
            }

        }
    }
}
