using System;

namespace dotnet_prgms  //nombre del proyecto
{
    class Program  //clases
    {
        static void Main(string[] args) //metodos
        {
            int num=20;  //variables explicitas, se le declaran el tipo
            char letter = 'a';
            string str = "salu2 banda";
            float f = 12.30f;
            double d = 12.34d;
            string EmptyString = string.Empty; //cadena vacia

            var aInteger = 1; //variables explicitas
            var aLetter = 'a';
            var aString = "Explicit var";
            var aFloat  = 12.34f;
            var aDouble = 12.34d;

            //Random num generator
            var randNumber = new Random().Next(1,10); 
            if (randNumber % 2 == 0)
                Console.WriteLine("El numero es par")
            else
                Console.WriteLine("El numero es par")
            

            Console.Write("Hello World!"); //impresion sin salto de lineas
            Console.WriteLine("Hello World!"); //impresion con salto de linea
            
        }
    }
}
