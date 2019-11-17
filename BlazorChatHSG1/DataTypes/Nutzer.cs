using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChat.DataTypes
{
    public class Nutzer
    {
        public string Name { get; set; }
        public int ID { get; set; }
        static int count;
        public Nutzer(string s)
        {
            ID = ++count;
            Name = s;
        }
    }
}
