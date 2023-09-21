using System;
namespace A
{
    public class Persona
    {
        private string name;
        private int age;
        public Persona(string nombre, int edad)
        {
            this.name = nombre;
            this.age = edad;
        }
        public Persona(string nombre)
        {
            this.name = nombre;
            this.age = 0;
        }
        public Persona()
        {
            this.name = "";
            this.age = 0;
        }
        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }
        public int Edad
        {
            get { return age; }
            set { age = value; }
        }
        public void Saludo()
        {
            Console.WriteLine("Hola soy {0} y tengo {1} años", this.Nombre, this.Edad);
        }
    }

}