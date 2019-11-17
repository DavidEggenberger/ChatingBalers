using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.DataTypes
{
    public class Nachricht
    {
        public string Message { get; set; }
        public string MessageFormatiert => " " + Message;
        public DateTime GeschriebenZeit { get; set; }
        public Nutzer Verfasser { get; set; }
        public Nachricht(Nutzer n, string s = "")
        {
            GeschriebenZeit = DateTime.UtcNow;
            Message = s;
            Verfasser = n;
        }
    }
}
