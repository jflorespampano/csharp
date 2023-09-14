//ejemplo de uso de estructuas
using System;
namespace Estructuras
{
    //estructura dirección
    struct Direccion
    {
        public string ciudad;
        public string colonia;
        public string calle;
        public int numero;
        public string cp;
        //puede llevar un constructor
        public string getDireccion()
        {
            return string.Format("calle:{0} numero:{1} colonia:{2}", calle, numero, colonia);
        }
    }
    //estructura persona
    struct Persona
    {
        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.direccion.ciudad = "";
            this.direccion.calle = "";
            this.direccion.colonia = "";
            this.direccion.cp = "";
            this.direccion.numero = 0;
        }
        public string nombre;
        public string apellidos;
        public int edad;
        public Direccion direccion;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //si creamos una estructura sin new, no se llama al constructor
            Direccion d;
            d.ciudad = "Carmen";
            d.colonia = "centro";
            d.calle = "calle 22";
            d.numero = 25;
            d.cp = "24190";
            Persona p;
            p.nombre = "ana";
            p.apellidos = "perez leon";
            p.edad = 34;
            p.direccion = d;
            Console.WriteLine(p.direccion.ciudad);
            Console.WriteLine(p.direccion.getDireccion());

            //tambien se puede crear una estrutura llamando al constructor
            Console.WriteLine("Estructura creada con new");
            Persona np = new Persona("petra", "uc chi", 45);
            Console.WriteLine("Nombre: {0}, Apellidos: {1}", np.nombre, np.apellidos);
            Console.WriteLine("fin, presione una tecla");
            Console.ReadKey();
        }
    }
}