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

public class Data
    {
        public int ID { get; set; }
        public string Room_Name { get; set; }
        public string Description { get; set; }
        public char[] Directions { get; set; }
    }


    class Rooms
    {
        private bool wasParsed { get; set; }

        public List <Data> RoomList { get; private set; }

        public Rooms()
        {
            wasParsed = false;
        }

        private List<Data> parseFile(string filePath)
        {
            string fp = File.ReadAllText(filePath);

            if (File.Exists(filePath)){
                wasParsed = true;
                return JsonConvert.DeserializeObject<List<Data>>(File.ReadAllText(filePath));
            }

            else
            {
                wasParsed = false;
                return null;
            }
        }
    
        public void Initalize()
        {
            var items = parseFile("Data/Room.json");
            RoomList = items;
        }

    }
}
