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
            CommanderInterface A = new CommanderInterface();
            A.IDF.Intelligence.IntelligenceGathering(A.Hamas);
            A.IDF.Intelligence.IntelligenceGathering(A.Hamas);
            A.IDF.Intelligence.IntelligenceGathering(A.Hamas);

            terrorist target = A.IDF.Intelligence.GetIntel().Terrorist;
            Console.WriteLine("hkjh");

            A.IDF.GetWeapon().KillTheTerrorist(target);



        }
    }
}
