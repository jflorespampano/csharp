﻿
using System;

namespace leer_calif_calc_promedio
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("programa que lee 2 calificaciones, calcula promedio, indica si el alumno paso o no!");
			
			string s="";
			Console.Write("De la calificacion de parcial 1: ");
			s=Console.ReadLine();
			int calif1=int.Parse(s);
			Console.Write("De la calificacion de parcial 2: ");
			s=Console.ReadLine();
			int calif2=int.Parse(s);
			int promedio=(calif1+calif2)/2;
			if (promedio>=70){
				Console.WriteLine("aprueba con {0}",promedio);
			}else{
				Console.WriteLine("reprueba con {0}",promedio);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}