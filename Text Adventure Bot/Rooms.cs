using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Text_Adventure_Bot;

namespace Text_Adventure_Bot
{
    class Rooms
    {
        public class Data
        {
            public int ID;
            public String Room_Name;
            public String Description;
            public Char[] Directions;
        }

        private Data room = new Data();
        private bool wasParsed = false;

        public Rooms()
        {
            wasParsed = false;
        }

        public bool parseFile(string filePath)
        {
            String fp = File.ReadAllText(filePath);

            if (File.Exists(filePath)){
                var JSON = JsonConvert.DeserializeObject<Data>(fp);
                wasParsed = true;
            }

            else { wasParsed = false; }

            return wasParsed;
        }
    
        public void printRoom()
        {
            Console.WriteLine(room.ID);
            Console.WriteLine(room.Room_Name);
            Console.WriteLine(room.Description);
        }

    }
}
