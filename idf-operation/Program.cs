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


            idf idf = new idf();

            strike(aman, idf);
            

        }

        static terrorist randomTerrorist(hamas h)
        {
            Random rnd = new Random();
            int i = rnd.Next(h.terrorists.Count);
            terrorist ranTerrorist = h.terrorists_list[i];

            return ranTerrorist;
        }

        static public int rankTerrorist(terrorist t)
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


        static public int chooseIndex(aman aman)
        {
            Console.WriteLine("choose number of intel:");
            int num = int.Parse(Console.ReadLine());

            if (num > aman.intels.Count || num > aman.intels.Count)
            {
                Random rnd = new Random();
                num = rnd.Next(aman.intels.Count);
                Console.WriteLine("the index is out of range. random number was choosen.");
            }
            return num;
        }

        static public void strike(aman aman, idf idf)
        {
            int index = chooseIndex(aman);


            intel i = aman.intels[index];

            if (i.ter.isLive == true)
            {

                string weaponName;
                weapon w;

                switch (i.location)
                {
                    case "building":
                        weaponName = "F16";
                        w = idf.F16;
                        break;
                    case "car":
                        weaponName = "Hermes460";
                        w = idf.Hermes460;
                        break;
                    case "open space":
                        weaponName = "M109";
                        w = idf.M109;
                        break;
                    default:
                        weaponName = "-";
                        w = idf.M109;
                        break;
                }

                if (w.remainingStrikes > 0)
                {
                    i.ter.isLive = false;
                    w.remainingStrikes--;

                    int rank = rankTerrorist(i.ter);

                    Console.WriteLine($"the terrorist {i.ter.name}, graded {rank} in the terror organization hamas, " +
                        $"was killed by {weaponName} of idf; he wached before at {i.timestamp} o'clock in {i.location}" +
                        $" helding a {i.ter.Weapon}. remined strikes in the {weaponName} after the strike: {w.remainingStrikes}.");
                }
                else
                {
                    Console.WriteLine($"there is no remaining strikes in the {weaponName}.");
                }
            }
            else
            {
                Console.WriteLine("this terrorist is alredy dead.");
            }
        }
    }
}
