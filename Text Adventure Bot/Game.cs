using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Adventure_Bot;

namespace Text_Adventure_Bot
{
    class Game
    {


        public bool initalize()      
        {
            var rooms = new Rooms();
            rooms.Initalize();

            return true;
        }

        public void gameLoop()
        {
            while (true)
            {

            }
        }

    }
}
