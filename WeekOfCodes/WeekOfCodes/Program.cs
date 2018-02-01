using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOfCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nummer16();
            Nummer17();
            Nummer18();
            Nummer19();
            Nummer20();
            Nummer21();*/
            Nummer22();

            Console.ReadKey();
        }

        private static void Nummer16()
        {
            int op16 = 678;
        }

        private static void Nummer17()
        {
            string op17 = "Apenbal";
        }

        private static void Nummer18()
        {
            double op18 = 1.43;
        }

        private static void Nummer19()
        {
            double op19 = 2.82842712475;
        }

        private static void Nummer20()
        {
            Console.WriteLine("Hoe oud ben je?");
            int op20 = Console.Read();
        }

        private static void Nummer21()
        {
            int varA = 3;
            int varB = 10;
            Console.WriteLine("varA is " + varA);
            Console.WriteLine("varB is " + varB);
            int temp = varA;
            varA = varB;
            varB = temp;
            Console.WriteLine("varA is " + varA);
            Console.WriteLine("varB is " + varB);
        }

        private static void Nummer22()
        {
            int var1 = 10;
            double var2 = 9.99;
            double var3 = 0.11;
            Console.WriteLine("Totale waarde is " + (var1 + var2 + var3));
        }

        private static void Nummer23()
        {
            int x = 10;
            int y = 20;
            int z = 30;
        }
    }
}
