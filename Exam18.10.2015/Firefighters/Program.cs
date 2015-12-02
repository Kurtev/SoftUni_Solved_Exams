using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firefighters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFirefighters = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int kids = 0;
            int adults = 0;
            int seniors = 0;

            int kidsSaved = 0;
            int adultsSaved = 0;
            int seniorsSaved = 0;
            
            while(command != "rain")
            {
                for(int i=0; i<command.Length;i++)
                {
                    if(command[i]=='K')
                    {
                        kids++;
                    }

                    if (command[i] == 'A')
                    {
                        adults++;
                    }

                    if (command[i] == 'S')
                    {
                        seniors++;
                    }
                }
                
                for(int i=0; i<numberOfFirefighters; i++)
                {
                    if(kids > 0)
                    {
                        kidsSaved++;
                        kids--;
                    }
                    else if(adults > 0 && kids == 0)
                    {
                        adultsSaved++;
                        adults--; 
                    }
                    else if(seniors > 0 && adults == 0 && kids == 0)
                    {
                        seniorsSaved++;
                        seniors--;
                    }
                }
                kids = 0;
                adults = 0;
                seniors = 0;
               
                   

                
                command = Console.ReadLine();
              
            }
            Console.WriteLine("Kids: {0}", kidsSaved);
            Console.WriteLine("Adults: {0}", adultsSaved);
            Console.WriteLine("Seniors: {0}", seniorsSaved);
        }
    }
}
