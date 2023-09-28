using System;
class estructura{
    struct Persona{
        public string nombre;
        public int edad;
    }
    public static void Main(string[] args){
        //persona estatica
        Persona p1;
        p1.nombre="luis";
        p1.edad=17;
        Console.WriteLine("nombre: {0}, edad {1}",p1.nombre,p1.edad);
        //persona dinamica
        Persona p2=new Persona{nombre="chayo", edad=45};
        Console.WriteLine("nombre: {0}, edad {1}",p2.nombre,p2.edad);
        //arreglo de personas
        Persona[] personas = new Persona[5];
            personas[0] = new Persona { nombre = "juan", edad = 10 };
            personas[1] = new Persona { nombre = "luis", edad = 18 };
            personas[2] = new Persona { nombre = "rosa", edad = 20 };
            personas[3] = new Persona { nombre = "pepe", edad = 31 };
            //
            personas[4].nombre="josefa";
            personas[4].edad=50;
            Console.WriteLine("\nnombre\tedad:");
            foreach (var p in personas)
            {
                Console.WriteLine("{0}\t{1}", p.nombre, p.edad);
            }
    }
}