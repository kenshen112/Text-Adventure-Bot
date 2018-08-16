using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Text_Adventure_Bot
{
    public class playerData
    {
        int HP { get; set; }
        string Name { get; set; }
        int Story_Progress { get; set; }       
    }

    class Player
    {
        playerData mainPlayer;
        public bool initalizePlayer()
        {
         


            return true;
        }


    }
}
