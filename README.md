# Ejemplos de programas en C# para el curso de Programación Gráfica I

## estructura de un programa en c#
```cs
using System;
namespace holamundo{
    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.WriteLine("Hello world!");
            Console.ReadKey();
        }
    }
}
```
## ejemplo 1
Leer 2 calificaciones sacar el promedio e indicar si el alumno aprueba o no.

Solución: 
```cs
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
```
Puede descargar el código desde el archivo: `ller-calif-y-calcular-promedio.cs`

## leer datos
Para leer datos pude usar las funciones anteriores `Console.ReadLine()`, pero esta no verifica errores, es decir si en la cadena tenemos letras y no nuneros esto hará que el rpograma aborte la ejecución:

por ejemplo:
```cs
sn="doce";
int i=int.Parse(sn);
```
El código anterior provocará que el programa falle pues estamos tratando de convertir a número una cadena que no contiene numeros. La solución en c#, es usar la función: 
```cs
string sn="aqui ira su cadena numérica";
bolean pudo=TryParse(sn, out n)
```

Esta trata de convertir la cadena a número, si logra la conversión devuelve true, y en la variable n pone el número convertido, si no puede convertir devueve false y en la variable n pone 0.

Ejemplo:

```cs
int i;
string sn="1ax08";
ok=int.TryParse(sn, out i);
if(ok){
	Console.WriteLine("caracteres validos: {0}",i);
}else{
	Console.WriteLine("caracteres no validos:");
}

```

## Cadenas
Almacenan cadenas de caracteres:

`string s="mi cadena";`

cuando queremos una cadena larga, por ejemplo de varias líneas, usamos cadenas verbatim:

```cs
	string s=@"
		hola
		mundo
	";
```
para buscar una subcadena dentro de una cadena:

```cs
string s3="una ves que termine, son las 10";
int i=s3.IndexOf(","); //busca la coma
Console.WriteLine("en la cadena '{0}' la coma esta en la posicion: {1}",s3,i); 
//para obtener una subcadena, pruebe:
Console.WriteLine("subacdena hasta la ,: {0}",s3.Substring(0,i));
//para obtener la longitud de una cadena
string str = "abcdefg";
Console.WriteLine("la longitud de '{0}' is {1}", str, str.Length);
```
Ejemplo: indicar si el nombre de una persona tiene apellido perez.
```cs
using System;
namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your program starts here...
            Console.Write("De su nombre completo: ");
            string s = Console.ReadLine();
            if (s.IndexOf("perez") >= 0)
            {
                Console.WriteLine("Tiene el apellido perez");
            }
            else
            {
                Console.WriteLine("No tiene el apellido perez");
            }
            Console.ReadKey();
        }
    }
}
```
## Framework Net de Windows

Para trabajar con Microsoft .NET que vine preinstalado en computadoras con SO Windows, puede agregar al path la direccion del compilador de c#, en micaso esta en la ruta:

`C:\Windows\Microsoft.NET\Framework64\v4.0.30319`

En la linea de mando ejecute:  `csc holamundo.cs`

Si el programa esta en varios archivos compile así:
`csc /out:ejecutable.exe holamundo.cs persona.cs`

[Vea aquí las opciones avanzadas del compilador de c#](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/compiler-options/miscellaneous)

## dotnet
NET Core es una plataforma de desarrollo de aplicaciones multiplataforma de código abierto, que permite a los desarrolladores crear aplicaciones de alta calidad para diferentes plataformas, incluyendo Windows, MacOS y Linux. Puede descargarlo desde aquí: 

[core net](https://dotnet.microsoft.com/es-es/download)


## Core net y VSCode.
### instalar extension 
Para trabajar en el editor VSCode instalar la extensión C# de Microsoft, esta pregunta por instalar el corenet si no lo ha instalado.

### construir proyecto en corenet
* Crear una carpeta de proyecto
* Ir a esa carpeta `cd carpeta`
* Ejecutar `dotnet new console --framework net7.0`
* Ejecutar proyecto `dotnet run`

Otra forma es ejecutar el comando:

```bs
dotnet new console -o sample1
cd sample1
dotnet run

```

En core net puede escribir el código principal de la aplicación sin función main, esto se le llama instrucciones de nivel superior, lo probe desde c# framework net 7, vea mas sobre esto en:

[instrucciones de nivel superior](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/program-structure/top-level-statements)

## referencias

[introduccion a core net](https://learn.microsoft.com/es-es/dotnet/core/introduction)

[documentacion en español](https://learn.microsoft.com/es-es/dotnet/core/get-started)

[descargar plataforma](https://dotnet.microsoft.com/es-es/download/dotnet)

[hola mundo en core net](https://learn.microsoft.com/es-es/dotnet/core/get-started)

[mas sobre versiones de c#](https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-10)