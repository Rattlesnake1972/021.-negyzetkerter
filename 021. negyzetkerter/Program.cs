using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021.negyzetkerter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a négyzet oldalát és kiírom annak kerületét!");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int kerulet = szam1 * 4;
            Console.WriteLine("A négyzet kerülete " + kerulet + " cm." + "\n");

            Console.WriteLine("Kérem a négyzet oldalát és kiírom annak területét!");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int terulet = szam2 * szam2;
            Console.WriteLine("A négyzet területe " + terulet + " cm2." + "\n");

            Console.ReadKey();
        }
    }
}
