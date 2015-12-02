using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFootballStatician
{
    class Program
    {
        static void Main(string[] args)
        {
         Dictionary<string,int> table = new Dictionary<string,int>
         {
            {"Arsenal",0},
            {"Chelsea",0},
            {"Everton",0},
            {"Liverpool",0},
            {"ManchesterCity",0},
            {"ManchesterUnited",0},
            {"Southampton",0},
            {"Tottenham",0}

         };
            double price = double.Parse(Console.ReadLine());
            price = price * 1.94d;
            int count = 0;
            while(true)
            {
                string input = Console.ReadLine();

                if(input == "End of the league.")
                {
                    break;
                }

                else
                {
                    
                    count++;
                    string[] matches = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); ;
                    

                        if (matches[1] == "1")
                        {
                            var points = table[matches[0]];
                            table[matches[0]] = points + 3;
                        }

                        else if (matches[1] == "X")
                        {
                            var points = table[matches[0]];
                            table[matches[0]] = points + 1;

                            points = table[matches[2]];
                            table[matches[2]] = points + 1;
                        }

                        else if (matches[1] == "2")
                        {
                            var points = table[matches[2]];
                            table[matches[2]] = points + 3;
                        }

                   

                }
              
            }
            double sum = price * count;
            Console.WriteLine("{0:F2}lv.", sum);
            foreach (KeyValuePair<string, int> kvp in table)
            {
                if(kvp.Key.Contains("ManchesterCity"))
                {
                    Console.WriteLine("Manchester City - {0} points.", kvp.Value);
                }
                else if (kvp.Key.Contains("ManchesterUnited"))
                {
                    Console.WriteLine("Manchester United - {0} points.", kvp.Value);
                }
                else
                {
                    Console.WriteLine("{0} - {1} points.", kvp.Key, kvp.Value);
                }
            }
        }
    }
}
