using System;
namespace proyecto
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
        public void setNombre(string name){
            this.name=name;
        }
        public string getNombre(){
            return this.name;
        }
        public void setEdad(int edad){
            age=edad;
        }
        public int getEdad(){
            return this.age;
        }
        public string Saludo()
        {
             return string.Format("Hola soy {0} y tengo {1} años", this.name, this.age);
        }
    }
    class Principal{
        static void Main(){
            Persona p=new Persona("maira",37);
            Console.WriteLine(p.Saludo());
        }
    }

}