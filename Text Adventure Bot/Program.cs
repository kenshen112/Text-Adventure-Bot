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
            Rooms room = new Rooms();
            room.parseFile("Data/Room.json");
            room.printRoom();
        }
    }
}
