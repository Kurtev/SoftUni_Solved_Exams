using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveBits
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            ulong quot;
            string rem = "";
            string temp;
            int count = 1;
            int tempCount = 0;
            int startIndex =0;
            int endIndex = 0;

            while (number >= 1)
            {
                quot = number / 2;
                rem += (number % 2).ToString();
                number = quot;
            }
            string bin = "";

            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }

            temp = "101";
            string temp2;
            StringBuilder strb = new StringBuilder();

            for (int i = 0; i < rem.Length-2;i++)
            {
                strb.Append(rem[i]);
                strb.Append(rem[i+1]);
                strb.Append(rem[i+2]);

                if(temp == strb.ToString())
                {
                    count += 2;
                  
                    
                    if (tempCount <= count)
                    {
                        tempCount = count;
                        endIndex = i+2;
                    }
                    i++;
                }
                else
                {
                   
                    if(tempCount<count)
                    {
                        tempCount = count;
                    }
                    count = 1;
                   
                }
                strb = new StringBuilder();
            }
            //Console.WriteLine(endIndex);
            strb = new StringBuilder(rem);
            strb.Remove(endIndex-tempCount, tempCount);
            //Console.WriteLine(strb);

          
            //for (int i = rem.Length-strb.Length; i < rem.Length;i++ )
            //{
            //    strb.Append("0");
            //}

            byte[] binarics = new byte[strb.Length];
            for (int i = strb.Length - 1; i >= 0; i--)
            {
                binarics[i] = byte.Parse(Convert.ToString((strb[i])));
            }


            ulong numDecimal = 0;
            ulong multiplier = 1;
            foreach (var digit in binarics)
            {
                numDecimal += (digit * multiplier);
                multiplier *= 2;
            }

            if (tempCount < 2)
            {
                Console.WriteLine("No waves found!");
            }
            else
            {
                Console.WriteLine(numDecimal);
            }
                
        }
    }
}









//namespace WaveBits
//{
//    using System;

//    public class WaveBits
//    {
//        public static void Main()
//        {
//            ulong number = ulong.Parse(Console.ReadLine());

//            int bestSequenceLength = 0;
//            int bestSequenceStartIndex = 0;
//            int currentSequenceLength = 1;

//            // ends at 61, because the following boolean expressions will eventually check bits @62 and @63
//            for (int i = 0; i <= 61; i++)
//            {
//                bool isFirstBitUp = ((number >> i) & 1) == 1;
//                bool isSecondBitDown = ((number >> i + 1) & 1) == 0;
//                bool isThirdBitUp = ((number >> i + 2) & 1) == 1;

//                bool isWaveTriple = isFirstBitUp && isSecondBitDown && isThirdBitUp;

//                if (isWaveTriple)
//                {
//                    // our sequence always starts from 1, so we only need to increment by 2
//                    // for example 1 + 2 + 2 is the length of 10101
//                    currentSequenceLength += 2;

//                    if (currentSequenceLength > bestSequenceLength)
//                    {
//                        bestSequenceStartIndex = i + 2;
//                        bestSequenceLength = currentSequenceLength;
//                    }

//                    // skip the zero in the middle of the triple and test the next three bits
//                    i++;
//                }
//                else
//                {
//                    // the current sequence has ended, so start over
//                    currentSequenceLength = 1;
//                }
//            }

//            int bestSequenceEndIndex = bestSequenceStartIndex - bestSequenceLength + 1;
//            ulong outputNumber = 0UL;

//            for (int i = 63; i >= 0; i--)
//            {
//                bool inShouldBeDeletedRange = i <= bestSequenceStartIndex && i >= bestSequenceEndIndex;
//                if (inShouldBeDeletedRange)
//                {
//                    outputNumber >>= 1;
//                }
//                else
//                {
//                    ulong currentBit = number & (1UL << i);
//                    outputNumber |= currentBit;
//                }
//            }

//            if (bestSequenceLength == 0)
//            {
//                Console.WriteLine("No waves found!");
//            }
//            else
//            {
//                Console.WriteLine(outputNumber);
//            }
//        }
//    }
//}
