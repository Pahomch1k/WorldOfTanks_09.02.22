using System;
using System.Threading;
using static System.Console;
using static System.Convert;
using WorldOfTanks;

namespace Lib
{
    class Program
    {
        static void Main()
        {
            int ch;
            WriteLine("Сколько такнов будет играть ?");
            ch = ToInt32(ReadLine());
             
            Tank[] T34 = new Tank[ch];
            Tank[] Pantera = new Tank[ch];
            for (int i = 0; i < ch; i++) T34[i] = new Tank("T34");
            for (int i = 0; i < ch; i++) Pantera[i] = new Tank("Pantera");

            for (int i = 0; i < ch; i++)
            {
                string s = "";
                int t1 = T34[i];
                int t2 = Pantera[i];
                if (t1 > t2)
                    WriteLine($"Бой номер {i + 1}. Победил танк {T34[i].name} \nХарактеристики: \nБроня - {T34[i].bronya}\nПатроны - {T34[i].patron}\nМаневреность - {T34[i].manevrenost}\n"); 
                else 
                    WriteLine($"Бой номер {i + 1}. Победил танк {Pantera[i].name}\nХарактеристики: \nБроня - {T34[i].bronya}\nПатроны - {T34[i].patron}\nМаневреность - {T34[i].manevrenost}\n");
                Thread.Sleep(1000);
            } 
        }
    }
}
