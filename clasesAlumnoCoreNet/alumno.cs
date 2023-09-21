using System.Diagnostics.Contracts;

namespace A
{
    public class Alumno : Persona
    {
        private string carrera;
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public Alumno(string nombre, int edad, string carrera) : base(nombre, edad)
        {
            this.carrera = carrera;
        }
    }
}