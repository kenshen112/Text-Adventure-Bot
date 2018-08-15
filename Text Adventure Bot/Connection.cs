using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Text_Adventure_Bot
{
    class Connection
    {
        readonly bool isConnected;

        public Connection()
        {
            isConnected = false;
        }

        public bool Connect()
        {
            return isConnected;
        }


    }
}
