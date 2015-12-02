using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrrayMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split('\\');
            char temp = ' ';
            string longerArray = arrays[0].Length > arrays[1].Length ? arrays[0] : arrays[1];
            string shorterArray = arrays[0].Length < arrays[1].Length ? arrays[0] : arrays[1];
            string matchedArray = string.Empty;

            if(arrays[2] == "join" )
            {
                for(int i=0; i<Math.Min(arrays[0].Length, arrays[1].Length);i++)
                {
                    temp = arrays[0].Length > arrays[1].Length ? arrays[1][i] : arrays[0][i];
                    for(int j=0;j<longerArray.Length;j++)
                    {
                        if(temp == longerArray[j])
                        {
                            matchedArray += temp;
                            break;
                        }
                    }
                }
                char[] result = matchedArray.ToCharArray();
                SortChars(result);
            }

            if (arrays[2] == "right exclude")
            {
                bool isIncluded = false;
                for (int i = 0; i < arrays[0].Length; i++)
                {
                    temp = arrays[0][i];
                    for (int j = 0; j < arrays[1].Length; j++)
                    {
                        if (temp == arrays[1][j])
                        {
                            isIncluded = true;
                            break;
                        }
                    }
                    if(isIncluded == false)
                    {
                        matchedArray += temp;
                    }
                    isIncluded = false;
                }
                char[] result = matchedArray.ToCharArray();
                SortChars(result);
            }

            if (arrays[2] == "left exclude")
            {
                bool isIncluded = false;
                for (int i = 0; i < arrays[1].Length; i++)
                {
                    temp = arrays[1][i];
                    for (int j = 0; j < arrays[0].Length; j++)
                    {
                        if (temp == arrays[0][j])
                        {
                            isIncluded = true;
                            break;
                        }
                    }
                    if (isIncluded == false)
                    {
                        matchedArray += temp;
                    }
                    isIncluded = false;
                }
                char[] result = matchedArray.ToCharArray();
                SortChars(result);
            }
        }
        static void SortChars(char[] arrayofChars)
        {
            char temp;
            for(int i=0; i<arrayofChars.Length;i++)
            {
                temp = arrayofChars[i];
                for(int j=i; j<arrayofChars.Length;j++)
                {
                    if(temp > arrayofChars[j])
                    {
                        
                        arrayofChars[i] = arrayofChars[j];
                        arrayofChars[j] = temp;
                        temp = arrayofChars[i];
                  
                    }
                }
                Console.Write(temp);
            }
            
        }
    }
}
