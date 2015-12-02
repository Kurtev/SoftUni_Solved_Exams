using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Numerology
{
    class Program
    {
        static void Main(string[] args)
        {
            string Data = Console.ReadLine();
            string[] birthData = Data.Split(' ');
            string[] dates = birthData[0].Split('.');
            string name = birthData[1];

            int [] intDates = new int[3];
            BigInteger result = 0;



            for (int i = 0; i < dates.Length; i++)
            {
                intDates[i] = int.Parse(dates[i]);
            }

            if (intDates[1] % 2 == 0)
            {
                result = intDates[0] * intDates[1] * intDates[2];
            }
            else
            {
                result = intDates[0] * intDates[1] * intDates[2];
                result *= result;
            }

            for (int i = 0; i < name.Length; i++ )
            {
                if(char.IsDigit(name[i]))
                {
                    result += (name[i] - '0');
                }
                else if(char.IsUpper(name[i]))
                {
                    result = result + ((name[i] - 64) * 2); 
                }
                else if(char.IsLower(name[i]))
                {
                    result = result + ((name[i] - 96)); 
                }

            }
            char[] temp = result.ToString().ToCharArray();
           
            while(result>13)
            {
                int temp2 = 0;
                for(int i = 0; i<temp.Length; i++)
                {
                    temp2 = temp2 + (temp[i] - '0');
                }
                result = temp2;
                temp = temp2.ToString().ToCharArray();
            }

                Console.WriteLine(result);
        

        }
    }
}
