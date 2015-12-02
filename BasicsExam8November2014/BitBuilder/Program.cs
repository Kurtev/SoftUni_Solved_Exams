using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BitBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string poziciq = Console.ReadLine();
            string command;
            int position;

            while(true)
            {
                if(poziciq !="quit")
                {
                    position = int.Parse(poziciq);
                }
                else
                {
                    break;
                }
                command = Console.ReadLine().ToLower();
                if(command == "flip")
                {
                    if (((number >> position) & 1) == 1)
                    {
                        number ^= (-0 ^ number) & (1 << position);
                       
                    }
                    else
                    {
                        number ^= (-1 ^ number) & (1 << position);
                    }
                }

                if (command == "insert")
                {
                    BitArray array = new BitArray(new int[]{number});
                    

                    for (int j = array.Count - 1; j > position; j--)
                    {
                        array.Set(j, array.Get(j - 1));
                    }

                    // setting the position bit
                    array.Set(position, true);

                    // converting BitArray to byte again
                    int[] intArray = new int[1];
                    array.CopyTo(intArray, 0);
                    number = intArray[0];
                   
                }

                if (command == "remove")
                {
                    BitArray array = new BitArray(new int[] { number });
                    BitArray coppyArray = new BitArray(32);

                    for (int j = 0; j < array.Count; j++)
                    {
                      if(j >= position)
                      {
                          if(j+1==32)
                          {
                              break;
                          }
                          else
                          {
                              coppyArray[j] = array[j + 1];
                          }
                      }
                      else
                      {
                          coppyArray[j] = array[j];
                      }
                      
                    }

                    // converting BitArray to byte again
                    int[] intArray = new int[1];
                    coppyArray.CopyTo(intArray, 0);
                    number = intArray[0];
                 
                }
                if (command == "skip")
                {

               }

                poziciq = Console.ReadLine();
               
                
            }
            Console.WriteLine(number);
        }
    }
}
