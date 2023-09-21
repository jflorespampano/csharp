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
            int i=s.IndexOf(" ");
            int tc=s.Length;
            Console.WriteLine("i={0} tc={1}",i,tc);
            if (i > 0)
            {
                Console.WriteLine("Tiene el apellido: {0}",s.Substring(i,tc-i));
            }
            else
            {
                Console.WriteLine("No tiene el apellido");
            }
            Console.ReadKey();
        }
    }
}