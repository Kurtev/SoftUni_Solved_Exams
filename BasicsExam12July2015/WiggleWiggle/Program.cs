using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WiggleWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            string binary1 = string.Empty;
            string binary2 = string.Empty;
            char temp = ' ';

            char[,] switchedNumbers = new char[numbers.Length, 63];
            BigInteger[] decimalNum = new BigInteger[numbers.Length];
            



            for (int i = 0; i < switchedNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < 63; j++)
                {
                    switchedNumbers[i, j] = '0';
                }
            }


            for (int i = 0; i < numbers.Length; i += 2)
            {
                while (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        binary1 += '0';
                    }
                    else
                    {
                        binary1 += '1';
                    }
                    numbers[i] /= 2;
                }

                while (numbers[i + 1] > 0)
                {
                    if (numbers[i + 1] % 2 == 0)
                    {
                        binary2 += '0';
                    }
                    else
                    {
                        binary2 += '1';
                    }
                    numbers[i + 1] /= 2;
                }

                binary1 = binary1.PadRight(63, '0');
                binary2 = binary2.PadRight(63, '0');


                for (int j = 0; j < 63; j++)
                {
                    if (j == 0)
                    {
                        switchedNumbers[i, j] = binary2[j];
                        switchedNumbers[i + 1, j] = binary1[j];
                    }

                    if (j % 2 == 0)
                    {
                        switchedNumbers[i, j] = binary2[j];
                        switchedNumbers[i + 1, j] = binary1[j];
                    }
                    else
                    {
                        switchedNumbers[i, j] = binary1[j];
                        switchedNumbers[i + 1, j] = binary2[j];
                    }
                }

                for (int j = 0; j < 63; j++)
                {
                    if (switchedNumbers[i, j] == '0')
                    {
                        switchedNumbers[i, j] = '1';
                    }
                    else
                    {
                        switchedNumbers[i, j] = '0';
                    }

                    if (switchedNumbers[i + 1, j] == '0')
                    {
                        switchedNumbers[i + 1, j] = '1';
                    }
                    else
                    {
                        switchedNumbers[i + 1, j] = '0';
                    }

                }

                binary1 = string.Empty;
                binary2 = string.Empty;
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < 63; j++)
                {
                    if (switchedNumbers[i, j] == '1')
                    {
                        decimalNum[i] += TransformToDecimalNum(j);
                    }
                }
            }


            for (int i = 0; i < switchedNumbers.GetLength(0); i++)
            {
                
                Console.Write(decimalNum[i] + " ");
                
                for (int j = 62; j >= 0; j--)
                {
                    Console.Write(switchedNumbers[i, j]);
                }
                Console.WriteLine();
            }

          
            
            
        }

        static BigInteger TransformToDecimalNum(int position)
        {
            BigInteger number = 0;
            if (position == 0)
            {
                number = 1;
            }
            else
            {
                number = 1;
                for (int i = 0; i < position; i++)
                {
                    number *= 2;
                }
            }

            return number;
        }
    }
}

