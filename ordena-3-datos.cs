using System;
class dos{
	public static void Main(){
		Console.WriteLine("ordena 3 valores de mayor a menor");
		Console.Write("de el primer valor entero: ");
		int a=int.Parse(Console.ReadLine());
		Console.Write("de el segundo valor entero: ");
		int b=int.Parse(Console.ReadLine());
		Console.Write("de el tercer valor entero: ");
		int c=int.Parse(Console.ReadLine());
	
		if(a>b){
			//a>b
			if(b>c){
				//tenemos a>b y b>c
				Console.WriteLine("{0},{1},{2}",a,b,c);
			}else{
				//tenemos que a>b y c>b
				if(a>c) Console.WriteLine("{0},{1},{2}",a,c,b);
				else Console.WriteLine("{0},{1},{2}",c,a,b);
			}
		}else{
			//b>a
			if(b>c){
				//tenemos b>a y b>c
				if(a>c) Console.WriteLine("{0},{1},{2}",b,a,c);
				else Console.WriteLine("{0},{1},{2}",b,c,a);
			}else{
				//tenemos que b>a y c>b
				Console.WriteLine("{0},{1},{2}",c,b,a);
			}
		}
		Console.ReadKey();
	}
}