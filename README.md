# Lenguaje c#

[Plataformas de trabajo usadas en estos ejemplos](#framework)

## Introducción

C# es un lenguaje de Microsoft, tiene 2 versiones Framework diseñado para ejecutarse en Windows y Core de código abierto diseñado para plataforma cruzada.

## versiones

* NET framework 4.x tiene la version de c# 5.0
* Core Net 6.0 tiene la version c# 10
* Core Net 7.0 tiene la version c# 11

## Ejemplos de programas en C# para el curso de Programación Gráfica I

Los siguientes programas fueron probados con el framework 4.0 de Windows.


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

## estrcuturas
```cs
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
```

## arreglos
Arreglo unidimensional

```cs
using System;
namespace Miespacio{
    public class A{
        public static void Main(){
            int[] edades={34,23,27,45};
            string[] nombres=new string [4];
            nombres[0]="juan";
            nombres[1]="ana";
            nombres[2]="pedro";
            nombres[3]="luis";
            Console.WriteLine(nombres[2]);

        }
    }
}
```

Arreglo de estructras
```cs
//ejemplo de uso de estructuas
using System;
namespace nuevo
{
    struct Persona
    {
        public string nombre;
        public string apellidos;
        public int edad;
    }
    class Program
    {
        static Persona leePersona(int np)
        {
            Persona p;
            Console.WriteLine("\nDeme los datos de la persona {0}", np);
            Console.Write("De su nombre: ");
            p.nombre = Console.ReadLine();
            Console.Write("De sus apellidos: ");
            p.apellidos = Console.ReadLine();
            Console.Write("De su edad: ");
            int.TryParse(Console.ReadLine(), out p.edad);
            return p;
        }
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[6];
            personas[0] = new Persona { nombre = "juan", apellidos = "perez", edad = 10 };
            personas[1] = new Persona { nombre = "luis", apellidos = "ruiz", edad = 18 };
            personas[2] = new Persona { nombre = "rosa", apellidos = "perez", edad = 20 };
            personas[3] = new Persona { nombre = "pepe", apellidos = "uc", edad = 31 };
            personas[4] = new Persona { nombre = "juan", apellidos = "balam", edad = 19 };
            personas[5] = leePersona(5);
            Console.WriteLine("\nnombre\tapellidos\tedad:");
            foreach (var p in personas)
            {
                Console.WriteLine("{0}\t{1}\tedad: {2}", p.nombre, p.apellidos, p.edad);
            }
            Console.WriteLine("--fin---->, presione una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
```
## Framework Net de Windows <a name="framework"></a>

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
Para ver las versiones de net instaladas:
`bs
dotnet --list-sdks
`
Para cosntrur un nuevo proyecto de consola 
En la consola:
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

En core net puede escribir el código principal de la aplicación sin función main, esto se le llama instrucciones de nivel superior, vea mas sobre esto en:

[instrucciones de nivel superior](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/program-structure/top-level-statements)


Puede crear un proyecto indicando que quiere la estructura del main en lugar de instrucciones de nivel superior, lo pude hacer así:
```bs
dotnet new console --use-program-main -o proyecto-1
```
Puede crear un proyecto para una version especifica (siempre y cuando tenga instalada esa versión):
```bs
dotnet new console -f net6.0 -o mirpoyecto
```

## referencias

[introduccion a core net](https://learn.microsoft.com/es-es/dotnet/core/introduction)

[documentacion en español](https://learn.microsoft.com/es-es/dotnet/core/get-started)

[descargar plataforma](https://dotnet.microsoft.com/es-es/download/dotnet)

[hola mundo en core net](https://learn.microsoft.com/es-es/dotnet/core/get-started)

[mas sobre versiones de c#](https://learn.microsoft.com/es-es/dotnet/csharp/whats-new/csharp-10)

[vscode con core net 7 y c# 11](https://dev.to/jjorozcodev/visual-studio-code-con-net-7-y-c-11-gli)