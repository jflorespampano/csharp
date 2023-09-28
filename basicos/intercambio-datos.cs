using System;
class dos{
	public static void Main(string[] args){
		Console.WriteLine("intercambia dos valores");
		int a=10, b=20;
		Console.WriteLine("a tiene:{0} y b tiene:{1} ",a,b);
		int aux=a;
		a=b;
		b=aux;
		Console.WriteLine("a tiene:{0} y b tiene:{1} ",a,b);
		Console.ReadKey();
	}
}