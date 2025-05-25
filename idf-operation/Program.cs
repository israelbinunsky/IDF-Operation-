using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idf_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hamas hamas = new hamas();
            hamas.addTerrorist("muhamad", 5, "AK47");
            hamas.addTerrorist("ali", 4, "M16");
            hamas.addTerrorist("ahmad", 3, "M16");
            hamas.addTerrorist("mustafa", 3, "gun");
            hamas.addTerrorist("abed", 2, "knife");
            hamas.addTerrorist("saud", 1, "knife");


            aman aman = new aman();
            terrorist t1 = randomTerrorist(hamas);
            aman.addIntel(t1 , "building", "12:20");
            terrorist t2 = randomTerrorist(hamas);
            aman.addIntel(t2, "car", "17:44");
            terrorist t3 = randomTerrorist(hamas);
            aman.addIntel(t3, "open space", "09:33");
            terrorist t4 = randomTerrorist(hamas);
            aman.addIntel(t4, "building", "11:11");
            terrorist t5 = randomTerrorist(hamas);
            aman.addIntel(t5, "car", "20:22");
            terrorist t6 = randomTerrorist(hamas);
            aman.addIntel(t6, "open space", "10:10");
            terrorist t7 = randomTerrorist(hamas);
            aman.addIntel(t7, "building", "11:20");
            terrorist t8 = randomTerrorist(hamas);
            aman.addIntel(t8, "car", "12:12");
            terrorist t9 = randomTerrorist(hamas);
            aman.addIntel(t9, "open space", "01:55");
            terrorist t10 = randomTerrorist(hamas);
            aman.addIntel(t10, "building", "04:04");
            terrorist t11 = randomTerrorist(hamas);
            aman.addIntel(t11, "car", "22:03");
            terrorist t12 = randomTerrorist(hamas);
            aman.addIntel(t12, "open space", "11:04");

            terrorist myTerrorist = hamas.terrorists[aman.intels[0].ter.name];
            strike(myTerrorist);
            Console.WriteLine(myTerrorist.isLive);

        }

        static terrorist randomTerrorist(hamas h)
        {
            Random rnd = new Random();
            int i = rnd.Next(h.terrorists.Count);
            terrorist ranTerrorist = h.terrorists_list[i];

            return ranTerrorist;
        }

        static int rankTerrorist(terrorist t)
        {
            int w = 0;
            switch (t.Weapon)
            {
                case "knife": w = 1; break;
                case "gun": w = 2; break;
                case "M16": w = 3; break;
                case "AK47": w = 4; break;
            }
            return (w + t.rank) * 2;
        }

        static public void strike(terrorist t)
        {
            t.isLive = false;
        }
    }
}
