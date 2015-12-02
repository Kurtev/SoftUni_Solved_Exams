using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptMessage
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, char> dictionary = new Dictionary<char, char>();
            dictionary.Add('+', ' ');
            dictionary.Add('%', ',');
            dictionary.Add('&', '.');
            dictionary.Add('#', '?');
            dictionary.Add('$', '!');

            string startEnd = string.Empty;

            while (startEnd.ToLower() != "start")
            {
                startEnd = Console.ReadLine();
            }

            List<string> listOfMessages = new List<string>();
            if (startEnd.ToLower() == "start")
            {
                do
                {
                    startEnd = Console.ReadLine();
                    if (startEnd != null && startEnd != string.Empty && startEnd.ToLower() != "end")
                    {
                        listOfMessages.Add(startEnd);
                    }


                } while (startEnd.ToLower() != "end");
            }

            char[][] listOfReversedMessages = new char[listOfMessages.Count][];

            for (int i = 0; i < listOfReversedMessages.Length; i++)
            {
                listOfReversedMessages[i] = new char[listOfMessages[i].ToCharArray().Length];
                listOfReversedMessages[i] = listOfMessages[i].ToCharArray();
                Array.Reverse(listOfReversedMessages[i]);

                for (int j = 0; j < listOfReversedMessages[i].Length; j++)
                {
                    if (listOfReversedMessages[i][j] >= 'A' && listOfReversedMessages[i][j] <= 'M')
                    {
                        listOfReversedMessages[i][j] += (char)13;
                    }

                    else if (listOfReversedMessages[i][j] >= 'N' && listOfReversedMessages[i][j] <= 'Z')
                    {
                        listOfReversedMessages[i][j] -= (char)13;
                    }

                    else if (listOfReversedMessages[i][j] >= 'a' && listOfReversedMessages[i][j] <= 'm')
                    {
                        listOfReversedMessages[i][j] += (char)13;
                    }

                    else if (listOfReversedMessages[i][j] >= 'n' && listOfReversedMessages[i][j] <= 'z')
                    {
                        listOfReversedMessages[i][j] -= (char)13;
                    }

                    if (dictionary.ContainsKey(listOfReversedMessages[i][j]))
                    {
                        char value = dictionary[listOfReversedMessages[i][j]];
                        listOfReversedMessages[i][j] = value;
                    }
                }


            }

            string numberOfMessages = listOfMessages.Count > 0 ? String.Format("Total number of messages: {0}", listOfMessages.Count) : "No messages sent.";
            Console.WriteLine(numberOfMessages);
            foreach (var message in listOfReversedMessages)
            {
                Console.WriteLine(message);

            }

        }
    }
}