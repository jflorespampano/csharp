using System;
namespace Miespacio{
    public class Principaal{
        struct Auto{
            public string marca;
            public int modelo;
        }
        static void actualiza(ref Auto x){
            x.modelo=2028;
            
        }
        public static void Main(){
            Auto a,b;
            a.marca="vw";
            a.modelo=2023;
            b=a;
            actualiza(ref a);
            Console.WriteLine("auto; {0}, modelo {1}",b.marca,a.modelo);
        }
    }
}