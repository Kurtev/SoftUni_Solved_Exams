using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string mask = Console.ReadLine();
            string maskedMessage = Console.ReadLine();
            int maskNumber = 0;
            int tempSum = 0;

            for(int i = 0; i<mask.Length; i++)
            {
                maskNumber += mask[i];
            }

            while (maskNumber>10)
            {
                tempSum = maskNumber % 10;
                maskNumber = (maskNumber / 10) + tempSum;
            }


            string message = string.Empty;
            for (int i = 0; i < maskedMessage.Length; i++ )
            {
                if (maskedMessage[i] % maskNumber == 0)
                {
                    message += (char)(maskedMessage[i] + maskNumber);
                }
                else
                {
                    message += (char)(maskedMessage[i] - maskNumber);
                }
            }

            for (int i = message.Length-1; i >=0; i-- )
            {
                Console.Write(message[i]);
            }
                
        }
    }
}
