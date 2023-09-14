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
        static void Main(string[] args)
        {
            Persona p = new Persona { nombre = "juan", apellidos = "perez", edad = 10 };
            p.nombre = "ana";
            p.apellidos = "perez leon";

            Console.WriteLine("p=Nombre: {0}, Apellidos: {1}, edad:{2}", p.nombre, p.apellidos, p.edad);
            Console.WriteLine("fin, presione una tecla");
            Console.ReadKey();
        }
    }
}