using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTheTorches
{
    class Program
    {
        static void Main(string[] args)
        {
            int roomNumbers = int.Parse(Console.ReadLine());
            char[] rooms = new char[roomNumbers];
            int count = 0;
            string roomState = Console.ReadLine();
            char[] roomStateAray = roomState.ToCharArray();
            

            for (int i = 0; i < rooms.Length;i++ )
            {
                if(count == roomState.Length)
                {
                    count = 0;
                }

                rooms[i] = roomStateAray[count];
                count++;
                //Console.Write(rooms[i]);
            }
            //Console.WriteLine();
            string[] movement = Console.ReadLine().Split();
            
            int roomsPassing = 0;
            int startingRoom = (roomNumbers / 2);

            while(movement[0] != "END")
            {


                if (movement[0] == "LEFT")
                {
                    roomsPassing = int.Parse(movement[1]) + 1;

                    if(startingRoom < roomsPassing || roomNumbers-1 < roomsPassing)
                    {
                        //for(int i=0;i<startingRoom; i++)
                        //{
                        //    if(rooms[i] =='D')
                        //    {
                        //        rooms[i] = 'L';
                        //    }
                        //    else
                        //    {
                        //        rooms[i] = 'D';
                        //    }
                            
                        //}
                        if (startingRoom == 0)
                        {

                        }
                        else
                        {
                            startingRoom = 0;
                            if (rooms[startingRoom] == 'D')
                            {
                                rooms[startingRoom] = 'L';
                            }
                            else
                            {
                                rooms[startingRoom] = 'D';
                            }
                        }
                    }
                    else if(startingRoom >= roomsPassing)
                    {
                        if (startingRoom == 0)
                        {

                        }
                        else
                        {
                            
                            if (rooms[startingRoom-roomsPassing] == 'D')
                            {
                                rooms[startingRoom-roomsPassing] = 'L';
                            }
                            else
                            {
                                rooms[startingRoom-roomsPassing] = 'D';
                            }
                        }
                        startingRoom -= roomsPassing;
                        //for (int i = startingRoom-1; i >= roomsPassing; i--)
                        //{
                        //    if (rooms[i] == 'D')
                        //    {
                        //        rooms[i] = 'L';
                        //    }
                        //    else
                        //    {
                        //        rooms[i] = 'D';
                        //    }

                        //}
                   
                    }
                }

                else if (movement[0] == "RIGHT")
                {
                    roomsPassing = int.Parse(movement[1]) + 1;

                    if ((startingRoom + roomsPassing) > roomNumbers-1)
                    {
                        //for(int i=0;i<startingRoom; i++)
                        //{
                        //    if(rooms[i] =='D')
                        //    {
                        //        rooms[i] = 'L';
                        //    }
                        //    else
                        //    {
                        //        rooms[i] = 'D';
                        //    }

                        //}
                        if (startingRoom == roomNumbers-1)
                        {

                        }
                        else
                        {
                            startingRoom = roomNumbers-1;
                            if (rooms[startingRoom] == 'D')
                            {
                                rooms[startingRoom] = 'L';
                            }
                            else
                            {
                                rooms[startingRoom] = 'D';
                            }
                        }
                    }
                    else if ((startingRoom + roomsPassing) <= roomNumbers-1)
                    {
                        if (startingRoom == roomNumbers-1)
                        {

                        }
                        else
                        {

                            if (rooms[startingRoom + roomsPassing] == 'D')
                            {
                                rooms[startingRoom + roomsPassing] = 'L';
                            }
                            else
                            {
                                rooms[startingRoom + roomsPassing] = 'D';
                            }
                        }
                        startingRoom += roomsPassing;
                        //for (int i = startingRoom-1; i >= roomsPassing; i--)
                        //{
                        //    if (rooms[i] == 'D')
                        //    {
                        //        rooms[i] = 'L';
                        //    }
                        //    else
                        //    {
                        //        rooms[i] = 'D';
                        //    }

                        //}

                    }
                }
                //for (int i = 0; i < rooms.Length; i++)
                //{
                
                //    Console.Write(rooms[i]);
                //}
                movement = Console.ReadLine().Split();
            }

            int darkRoomsCount = 0;
            for (int i = 0; i < rooms.Length; i++)
            {
                if(rooms[i] == 'D')
                {
                    darkRoomsCount++;
                }
            }
            int prayers = (int)'D' * darkRoomsCount;
            Console.WriteLine(prayers);
        }
    }
}
