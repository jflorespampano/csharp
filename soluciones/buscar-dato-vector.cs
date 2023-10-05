using System;
namespace Mispace{
    public class A{
        public static void Main(){
            const int N=7;
            bool encontrado=false;
            int[] v={60,70,65,90,50,75,95};
            int dato,posicion;
            Console.Write("De el numero a buscar: ");
            dato=int.Parse(Console.ReadLine());
            for(int i=0;i<N;i++){
                if (dato==v[i]){
                    posicion=i;
                    Console.WriteLine("El dato {0} esta en la posicion {1}",dato,posicion);
                    encontrado=true;
                    break;
                }
            }
            if(!encontrado){
                Console.WriteLine("No se encontro el dato");
            }
            Console.ReadKey();
        }
    }
}