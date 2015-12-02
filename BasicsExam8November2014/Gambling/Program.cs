using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    class Program
    {
        static void Main(string[] args)
        {
            double pot = double.Parse(Console.ReadLine());
            string[] houseHand = Console.ReadLine().Split(' ');
            int HouseStrenght = 0;
            int PlayerHand = 0;
            int winningHands = 0;
            int allPossibleHands = 0;

            for (int i = 0; i < houseHand.Length; i++)
            {
                switch(houseHand[i])
                {
                    case "A": { HouseStrenght += 14; break; }
                    case "K": { HouseStrenght += 13; break; }
                    case "Q": { HouseStrenght += 12; break; }
                    case "J": { HouseStrenght += 11; break; }
                    case "2": { HouseStrenght += 2; break; }
                    case "3": { HouseStrenght += 3; break; }
                    case "4": { HouseStrenght += 4; break; }
                    case "5": { HouseStrenght += 5; break; }
                    case "6": { HouseStrenght += 6; break; }
                    case "7": { HouseStrenght += 7; break; }
                    case "8": { HouseStrenght += 8; break; }
                    case "9": { HouseStrenght += 9; break; }
                    case "10": { HouseStrenght += 10; break; }
                }
               
            }

            for (int color1 = 2; color1 < 15; color1++ )
            {
                PlayerHand = 0;
                for (int color2 = 2; color2 < 15; color2++)
                {

                    for (int color3 = 2; color3 < 15; color3++)
                    {

                        for (int color4 = 2; color4 < 15; color4++)
                        {
                            PlayerHand = 0;
                            PlayerHand = color1 + color2 + color3 + color4;

                            if(PlayerHand>HouseStrenght)
                            {
                                winningHands++;
                            }
                            allPossibleHands++;
                        }
                    }
                }

            }
            double ratio = ((double)winningHands / allPossibleHands)*100;
            if (ratio < 50.0)
            {
                Console.WriteLine("FOLD");
                double winnings = (2*pot * ratio)/100;
                Console.WriteLine("{0:F2}", winnings);
            }
            if (ratio >= 50.0)
            {
                Console.WriteLine("DRAW");
                double winnings = (2*pot * ratio)/100;
                Console.WriteLine("{0:F2}", winnings);
            }
        }
    }
}
