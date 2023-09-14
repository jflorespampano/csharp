//ejemplo de uso de estructuas
using System;
namespace nuevo
{

    struct Persona
    {
        public string nombre;
        public string apellidos;
        public int edad;
    }
    class Program
    {
        static Persona leePersona(int np)
        {
            Persona p;
            Console.WriteLine("\nDeme los datos de la persona {0}", np);
            Console.Write("De su nombre: ");
            p.nombre = Console.ReadLine();
            Console.Write("De sus apellidos: ");
            p.apellidos = Console.ReadLine();
            Console.Write("De su edad: ");
            int.TryParse(Console.ReadLine(), out p.edad);
            return p;
        }
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[6];
            personas[0] = new Persona { nombre = "juan", apellidos = "perez", edad = 10 };
            personas[1] = new Persona { nombre = "luis", apellidos = "ruiz", edad = 18 };
            personas[2] = new Persona { nombre = "rosa", apellidos = "perez", edad = 20 };
            personas[3] = new Persona { nombre = "pepe", apellidos = "uc", edad = 31 };
            personas[4] = new Persona { nombre = "juan", apellidos = "balam", edad = 19 };
            personas[5] = leePersona(5);

            Console.WriteLine("\nnombre\tapellidos\tedad:");
            foreach (var p in personas)
            {
                Console.WriteLine("{0}\t{1}\tedad: {2}", p.nombre, p.apellidos, p.edad);
            }

            // Console.WriteLine("p=Nombre: {0}, Apellidos: {1}, edad:{2}", p.nombre, p.apellidos, p.edad);
            Console.WriteLine("--fin---->, presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}