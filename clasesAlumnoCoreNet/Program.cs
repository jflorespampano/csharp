using System;
namespace A
{

    public class Principal
    {
        public static void Main(string[] args)
        {
            Persona a = new Persona("veronica rios", 24);
            Persona b = new Persona();
            b.Nombre = "rosario blues";
            b.Edad = 34;
            a.Saludo();
            b.Saludo();
            //
            Alumno al = new Alumno("mi alumno", 45, "isc");
            al.Saludo();

        }
    }
}