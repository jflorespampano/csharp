using System;
namespace Mispace{
    public class A{
        public static void Main(){
            const int N=7;
            int[] v={60,70,65,90,50,75,95};
            int suma,promedio;
            suma=0;
            for(int i=0;i<N;i++){
                suma+=v[i];
            }
            promedio=suma/N;
            Console.WriteLine("Promedio = {0}",promedio);
            Console.ReadKey();
        }
    }
}