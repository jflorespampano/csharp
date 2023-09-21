//jflores
//lee el nombre : nombre1 nombre2 apellido1 apellido2
//o: nombre1 apellido1 apellido2
//y separa nombres y apellidos
//
using System;
namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s2, s3, s4;
            string n1, n2, n3;
            int tc, i;
            Console.Write("De su nombre completo: ");
            s = Console.ReadLine();
            i = s.IndexOf(" ");
            //si encontro espacio primer tiene apellidos o segnundo nombre
            if (i > 0)
            {
                n1 = s.Substring(0, i);
                tc = s.Length;
                s2 = s.Substring(i + 1, tc - (i + 1));
                i = s2.IndexOf(" ");
                //si encontro segundo espacio tiene primer apellido o segundo apellido
                if (i > 0)
                {
                    n2 = s2.Substring(0, i);
                    tc = s2.Length;
                    s3 = s2.Substring(i + 1, tc - (i + 1));
                    i = s3.IndexOf(" ");
                    //si encontro tercer espacio tiene segundo apellido
                    if (i > 0)
                    {
                        n3 = s3.Substring(0, i);
                        tc = s3.Length;
                        s4 = s3.Substring(i + 1, tc - (i + 1));
                        Console.WriteLine("Nombre: {0} {1}, apellidos: {2} {3}", n1, n2, n3, s4);
                    }
                    else
                    {
                        //solo titne primer apellido
                        Console.WriteLine("Nombre: {0} apellidos: {1} {2}", n1, n2, s3);
                    }
                }
                else
                {
                    Console.WriteLine("No puso su nombre completo");
                }
            }
            else
            {
                Console.WriteLine("No tiene el apellido");
            }
            Console.Write("Presione tecla para terminar...");
            Console.ReadKey();
        }
    }
}