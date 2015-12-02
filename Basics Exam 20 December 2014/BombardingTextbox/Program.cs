using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombardingTextbox
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] centence = Console.ReadLine().ToCharArray();
            int lineWidth = int.Parse(Console.ReadLine());
            string[] colsToAttack = Console.ReadLine().Split(' ');
            int temp;
            bool bombDropped = false;
            

            for(int i=0; i<colsToAttack.Length;i++)
            {
                temp= int.Parse(colsToAttack[i]);
                bombDropped = false;
                while (temp < centence.Length)
                {
                    if (centence[temp] == ' ' && bombDropped==true)
                    {
                        break;
                    }
                    else
                    {
                        if (centence[temp] == ' ')
                        {

                        }
                        else
                        {
                            centence[temp] = ' ';
                            bombDropped = true;
                        }
                    }
                    temp += lineWidth;
                }
                
            }
            for (int i = 0; i < centence.Length; i++)
            {
                Console.Write(centence[i]);
            }
        }
    }
}
