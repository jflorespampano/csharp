using System;
class dos{
	public static void Main(){
		Console.WriteLine("ordena 3 valores de mayor a menor");
		//cadena verbatim
		string s=@"
		hola
		mundo
		";
		Console.WriteLine("la cadena s tiene:{0}",s);
		//cadena
		string s2="hola\n mundo\n bye";
		Console.WriteLine("la cadena s2 tiene:{0}",s2);
		//leer datos numericos
		int i;
		string sn="108";
		bool ok=int.TryParse(sn, out i);
		Console.WriteLine("Los caracteres de sn son validos: {0}, y el valor convertido es:{1}",ok,i);
		//
		sn="1ax08";
		ok=int.TryParse(sn, out i);
		Console.WriteLine("Los caracteres de sn son validos: {0}, y el valor convertido es:{1}",ok,i);
		//
		//buscar subcadena
		string s3="una ves que termine, son las 10";
		i=s3.IndexOf(",");
		Console.WriteLine("en la cadena '{0}' , esta en la posicion: {1}",s3,i);   
		//subcadena
		Console.WriteLine("subacdena hasta la ,: {0}",s3.Substring(0,i));
		Console.ReadKey();
	}
}