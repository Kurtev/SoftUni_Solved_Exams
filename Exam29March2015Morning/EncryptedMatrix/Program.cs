using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Numerics;

namespace EncryptedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string diagonal = Console.ReadLine();

            int[] temp = new int[input.Length];
            List<int> newNumber = new List<int>();

            BigInteger number = new BigInteger();

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] >= 10)
                {
                    temp[i] = (int)input[i] % 10;
                }

            }
            if (temp.Length == 1)
            {
                Console.WriteLine(temp[0]);
            }
            else
            {


                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] % 2 != 0)
                    {
                        if (i == 0)
                        {
                            if (temp[i] + temp[i + 1] >= 10)
                            {
                                newNumber.Add((temp[i] + temp[i + 1]) / 10);
                                newNumber.Add((temp[i] + temp[i + 1]) % 10);
                            }
                            else
                            {
                                newNumber.Add(temp[i] + temp[i + 1]);
                            }

                        }

                        else if (i == temp.Length - 1)
                        {
                            if (temp[i] + temp[i - 1] >= 10)
                            {
                                newNumber.Add((temp[i] + temp[i - 1]) / 10);
                                newNumber.Add((temp[i] + temp[i - 1]) % 10);
                            }
                            else
                            {
                                newNumber.Add(temp[i] + temp[i - 1]);
                            }
                        }

                        else if (i != 0 && i != temp.Length - 1)
                        {
                            if (temp[i - 1] + temp[i] + temp[i + 1] >= 10)
                            {
                                newNumber.Add((temp[i - 1] + temp[i] + temp[i + 1]) / 10);
                                newNumber.Add((temp[i - 1] + temp[i] + temp[i + 1]) % 10);
                            }
                            else
                            {
                                newNumber.Add(temp[i - 1] + temp[i] + temp[i + 1]);
                            }

                        }
                    }
                    else
                    {
                        if (temp[i] * temp[i] >= 10)
                        {
                            newNumber.Add((temp[i] * temp[i]) / 10);
                            newNumber.Add((temp[i] * temp[i]) % 10);
                        }
                        else
                        {
                            newNumber.Add(temp[i] * temp[i]);
                        }

                    }
                    //  Console.Write(newNumber[i]);
                }


                if (diagonal == "\\")
                {
                    for (int i = 0; i < newNumber.Count; i++)
                    {
                        for (int j = 0; j < newNumber.Count; j++)
                        {
                            if (j != i)
                            {
                                Console.Write(0 + " ");
                            }
                            else
                            {
                                Console.Write(newNumber[i] + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                else
                {
                    int count = newNumber.Count - 1;
                    for (int i = newNumber.Count - 1; i >= 0; i--)
                    {
                        for (int j = 0; j < newNumber.Count; j++)
                        {
                            if (j - count == 0)
                            {
                                Console.Write(newNumber[i] + " ");
                            }
                            else
                            {
                                Console.Write(0 + " ");
                            }

                        }
                        count--;
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }
        }

    }
}
