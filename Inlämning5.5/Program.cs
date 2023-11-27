using System;
using System.Globalization;

namespace inlämning5.__5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Skriv en fråga, för att sluta fråga frågor skriv a");
                string[] svaren = new string[10] {"ja","nej","kanske","Det kan du ge dig fan på","Hur fan ska jag veta","Det kan du fundera på","Aldrig","Alltid","Förmdoligen","Förmodligen inte"};
                Random random = new Random();
                string svar = Console.ReadLine();
                if (svar == "a")
                {
                    break;
                }
                int index = random.Next(0,10);
                Console.WriteLine(svaren[index]);
            }
        }
    }
}
