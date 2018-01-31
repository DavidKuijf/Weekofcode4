using System;

namespace Weekofcode4
{
    class Program
    {
        static void Opdracht1()
        {
            Console.WriteLine("Week of Code rocks!");
        }

        static void Opdracht2()
        {

            Console.WriteLine(" Ik \n ben \n springerig"); 
        }

        static void Opdracht3()
        {
            Console.WriteLine(" Ik");
            Console.WriteLine(" Doe");
            Console.WriteLine(" Extra");
            Console.WriteLine(" Werk");
        }

        static void Opdracht4()
        {
            Console.WriteLine(" Twee\n regels");
        }

        static void Opdracht5()
        {
            Console.WriteLine(" Tabbladen\tzijn\tgaaf");
        }

        static void Opdracht6()
        {
            Console.WriteLine("Kijk mama, zonder gegeven code!' afdrukt.");
        }

        static void Opdracht7()
        {
            Console.WriteLine( "Ik");
            Console.Write("verzamel\n");
            Console.WriteLine("vandaag");
            Console.Write("de\n");
            Console.WriteLine("meeste");
            Console.Write("achievements\n");

        }
        static void Opdracht8()
        {
            Console.WriteLine("tab,\t" +
                "tab,\t" +
                " tab,\t" +
                " die mooie tab van goud.");
        }
        static void Opdracht9()
        {
            Console.Write("Een\n");
            Console.Write("Twee\n");
            Console.Write("Drie\n");
            Console.Write("Vier\n");
            Console.Write("Vijf\n");
            Console.Write("Zes\n");
            Console.Write("Zeven\n");
            Console.Write("Acht\n");
            Console.Write("Negen\n");
            Console.Write("Tien\n");
        }
        static void Opdracht10()
        {
            Console.WriteLine("Ik");
            Console.WriteLine("hou");
            Console.WriteLine("van");
            Console.WriteLine("witregels");
        }

        static void Opdracht31()
        {
            Console.WriteLine("What is 1+1?");
            Console.WriteLine("A. 1");
            Console.WriteLine("B. 2");
            Console.WriteLine("C. 3");
            string ans = Console.ReadLine();

            Console.WriteLine("What's the capital of the Nederlands?");
            Console.WriteLine("A. Rotterdam");
            Console.WriteLine("B. Amsterdam");
            Console.WriteLine("C. Den Haag");
            string ans2 = Console.ReadLine();

        }

        static void Opdracht32()
        {
            Console.WriteLine("What's your first name?");
            string FIRST_NAME = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LAST_NAME = Console.ReadLine();
            Console.WriteLine("What's your postal code?");
            string POSTAL_CODE = Console.ReadLine();
        }

        static void Opdracht33()
        {
            Console.WriteLine("What's your first name?");
            string FIRST_NAME = Console.ReadLine();
            Console.WriteLine("What's your last name?");
            string LAST_NAME = Console.ReadLine();
            Console.WriteLine("What's your postal code?");
            string POSTAL_CODE = Console.ReadLine();
            Console.WriteLine("What's your house number?");
            string HOUSE_NUMBER = Console.ReadLine();
            Console.WriteLine("How much do you weigh?");
            string WEIGHT = Console.ReadLine();
            Console.WriteLine("How much do you earn (in euros)?");
            string EARNINGS = Console.ReadLine();
        }

        static void Main(string[] args)
        {
     
            Opdracht1();
            Opdracht2();
            Opdracht3();
            Opdracht4();
            Opdracht5();
            Opdracht6();
            Opdracht7();
            Opdracht8();
            Opdracht9();
            Opdracht10();

            Opdracht31();
            Opdracht32();
            Opdracht33();

            Console.ReadKey();
        }
    }
}
