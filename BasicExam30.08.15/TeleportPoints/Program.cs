using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleportPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] Xses = new float[4];
            float[] Yses = new float[4];
            float AB;
            float BC;
            float H = 0;
            float R = 0;

            string coordinates;

            for (int i = 0; i < 4; i++)
            {
                coordinates = Console.ReadLine();
                string[] coos = coordinates.Split(' ');
                Xses[i] = float.Parse(coos[0]);
                Yses[i] = float.Parse(coos[1]);
            }

            R = float.Parse(Console.ReadLine());
            H = float.Parse(Console.ReadLine());


            int temp = 0;

            for (float i = 0; i <= R; i += H)
            {
                for (float j = 0; j <= R; j += H)
                {
                    if ((i * i) + (j * j) <= R * R)
                    {
                       
                        if (j > Yses[0] && j < Yses[3] && i > Xses[0] && i < Xses[1])
                        {
                            temp++;
                        }
                    }
                }
                for (float j = -H; j >= -R; j -= H)
                {
                    if ((i * i) + (j * j) <= R * R)
                    {
                        if (j > Yses[0] && j < Yses[3] && i > Xses[0] && i < Xses[1])
                        {
                            temp++;
                        }
                    }
                }
            }
            for (float i = -H; i >= -R; i -= H)
            {
                for (float j = 0; j <= R; j += H)
                {
                    if ((i * i) + (j * j) <= R * R)
                    {
                        if (j > Yses[0] && j < Yses[3] && i > Xses[0] && i < Xses[1])
                        {
                            temp++;
                        }
                    }
                }
                for (float j = -H; j >= -R; j -= H)
                {
                    if ((i * i) + (j * j) <= R * R)
                    {
                        if (j > Yses[0] && j < Yses[3] && i > Xses[0] && i < Xses[1])
                        {
                            temp++;
                        }
                    }
                }
            }

            Console.WriteLine(temp);

            //for(int i=0; i<Xses.Length; i++)
            //{
            //    Console.WriteLine(Xses[i]);
            //}
            //(x - center_x)^2 + (y - center_y)^2 < radius^2.
        }
    }
}
