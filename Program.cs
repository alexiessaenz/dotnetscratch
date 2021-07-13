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
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es par");


            Console.Write("Hello World!"); //impresion sin salto de lineas
            Console.WriteLine("Hello World!"); //impresion con salto de linea

            var name = "moises";
            name = name.ToLower();

            for (int i = 0; i < name.Length; i++)
            {
                switch (name[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"El caracter {name[i]} es vocal");
                        break;
                    default:
                        Console.WriteLine($"El caracter {name[i]} no es vocal");
                        break;
                }
            }

            //Parseo o parsing 
            int edad = 0;

            //convertir un string a entero
            Console.WriteLine("Cual es su edad?");
            edad = Int32.Parse(Console.ReadLine());

            char a = char.Parse(Console.ReadLine());
            char e = Console.ReadLine()[0];

            double dd = double.Parse(Console.ReadLine());
            
        }
    
        static int AddNumbers(int a, int b)
        {
            return a+b;
        }

        static string ConvertToUpperCase(string word)
        {
            return word.ToUpper();
        }
    }
}
