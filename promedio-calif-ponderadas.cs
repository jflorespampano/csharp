using System;
class uno{
	public static void Main(){
		Console.WriteLine("lee 2 calificacion con valores ponderados calif vale 40% y calif 2 vale 60%, calcula el promedio");
		string s="";
		Console.Write("De la calificacion de parcial 1: ");
		s=Console.ReadLine();
		double calif1=double.Parse(s);
		Console.Write("De la calificacion de parcial 2: ");
		s=Console.ReadLine();
		double calif2=double.Parse(s);
		double promedio=calif1*0.40+calif2*0.60;
		if (promedio>=70){
			Console.WriteLine("aprueba con {0}",promedio);
		}else{
			Console.WriteLine("reprueba con {0}",promedio);
		}
		
		Console.Write("Press any key to continue . . . ");
		Console.ReadKey(true);
	}
}