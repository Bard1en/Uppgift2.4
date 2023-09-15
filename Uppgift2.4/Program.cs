using System;
using System.Security.Cryptography.X509Certificates;

namespace Uppgift2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket tjänar den första personen?");
            string x = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar den andra personen?");
            string y = Console.ReadLine();
            Console.WriteLine("Hur mycket tjänar den tredje personen?");
            string z = Console.ReadLine();
            double första = double.Parse(x);
            double andra = double.Parse(y);
            double tredje = double.Parse(z);
            double sum =  (första + andra + tredje);
            Console.WriteLine("Medellönen på personalen är " + sum/2 + "kr");
            Console.ReadKey();
        }
    }
}