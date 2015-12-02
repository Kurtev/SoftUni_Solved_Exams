using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace GameOfBIts
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            List<char> temp = new List<char>();
            string binary = string.Empty;
            string command = Console.ReadLine();

            //Binary transform
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    binary += '0';
                }
                else
                {
                    binary += '1';
                }
                number /= 2;
            }
            //for (int i = binary.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(binary[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            while (command != "Game Over!")
            {
              
                for (int i = 0; i < binary.Length; i++)
                {
                    if (command == "Odd")
                    {
                        if (i % 2 == 0)
                        {
                            temp.Add(binary[i]);
                        }
                    }
                    else
                    {
                        if (i % 2 != 0)
                        {
                            temp.Add(binary[i]);
                        }
                    }
                }

                binary = string.Empty;
                for (int i = 0; i < temp.Count;i++ )
                {
                    binary += temp[i];
                }
                    

                //for (int i = 0; i < temp.Count; i++)
                //{
                //    Console.Write(temp[i]);
                //}
                temp.Clear();
                command = Console.ReadLine();
            }


            BigInteger decimalNum = 0;
            int countOnes = 0;
            for (int i = binary.Length-1; i >=0; i--)
            {
                if (binary[i] == '1')
                {
                    countOnes++;
                    decimalNum += TransformToDecimalNum(i);
                }
            }


            Console.WriteLine("{0} -> {1}",decimalNum,countOnes);
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
