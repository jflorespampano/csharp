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
            Persona p;
            p.nombre = "ana";
            p.apellidos = "perez leon";
            p.edad = 34;
            Persona q = p;
            p.nombre = "rosario";
            p.apellidos = "ruiz perez";
            Console.WriteLine("P=Nombre: {0}, Apellidos: {1}, edad:{2}", p.nombre, p.apellidos, p.edad);
            Console.WriteLine("Q=Nombre: {0}, Apellidos: {1}, edad:{2}", q.nombre, q.apellidos, q.edad);
            Console.WriteLine("fin, presione una tecla");
            Console.ReadKey();
        }
    }
}