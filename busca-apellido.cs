using System;
namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.Write("De su nombre completo: ");
            string s = Console.ReadLine();
            if (s.IndexOf("perez") >= 0)
            {
                Console.WriteLine("Tiene el apellido perez");
            }
            else
            {
                Console.WriteLine("No tiene el apellido perez");
            }
            Console.ReadKey();
        }
    }
}