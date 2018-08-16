using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Adventure_Bot;

namespace Text_Adventure_Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Rooms();

            room.Initalize();

            foreach (var item in room.RoomList)
            {
                Console.WriteLine($"You found room {item.ID}! {item.Description}");

                for (int i = 0; i < item.Directions.GetLength(i); i++)
                {

                    Console.WriteLine($"Valid directions are {item.Directions[i]}");
                }
            }

            Console.ReadLine();

        }
    }
}
