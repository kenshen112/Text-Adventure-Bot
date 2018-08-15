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
        private bool wasParsed = false;
        private int id;
        private String name;
        private String description;
        private Char[] directions;

        public Rooms()
        {
            wasParsed = false;
        }

        public bool parseFile(string filePath)
        {
            String fp = File.ReadAllText(filePath);

            if (File.Exists(filePath)){
                var JSON = JsonConvert.DeserializeObject<dynamic>(filePath);
                name = JSON.Room_Name;
                id = JSON.ID;
                description = JSON.description;
                wasParsed = true;
            }

            else { wasParsed = false; }

            return wasParsed;
        }
    
        public void printRoom()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(description);
        }

    }
}
