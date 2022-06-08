using System;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace WorldOfTanks
{ 
    public class Tank
    {
        static void Main()
        {  }

        public string name { get; set; }
        public int bronya { get; set; }
        public int patron { get; set; }
        public int manevrenost { get; set; }
         
        public Tank(string n)
        {
            Random r = new Random();
            name = n;
            bronya = r.Next(0, 100);
            patron = r.Next(0, 100);
            manevrenost = r.Next(0, 100);
        } 

        public static implicit operator int(Tank t)
        {
            return t.bronya * t.patron;
        }
    } 
}
