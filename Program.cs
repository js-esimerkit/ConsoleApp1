using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname;
            int age;
            Console.WriteLine("Anna nimesi");
            fname = Console.ReadLine();
            Console.WriteLine("Kuinka vanha olet?");
            //seuraava kaataa sovelluksen jos laittaa vahingossa kirjaimia
            //age=int.Parse(Console.ReadLine());
            //joten TryParse on tässä parempi
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Terve " + fname);
            Console.WriteLine("Olet siis " + age + " vuotias");
        }
    }
}
