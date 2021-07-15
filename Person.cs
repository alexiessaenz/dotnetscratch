//Clase Person
//molde que contiene caracteristcias y acciones de un objeto o elemento abstraido de la realidad.
using System;
namespace dotnet_prgms
{
    class Person
    {
        // TODO: Atributos
        // Caracteristicas que definen la isntancia de una clase

        string firstName, lastName, profession, nationality;
        int age;
        char gender;

        // TODO: Metodos
        // Acciones o comportamientos que posee este elemento

        public Person(string firstName,string lastName, string profession, string nationality, int age, char gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.profession = profession;
            this.nationality = nationality;
            this.age = age;
            this.gender = gender;
        }

        void Greet()
        {
            Console.WriteLine($"{firstName} te est saludando");
        }

        void walk(string from, string to)
        {
            Console.WriteLine($"{firstName} camina desde {from} hasta {to}");
        }

        void Talk(string message)
        {
            Console.WriteLine($"{firstName} dice: \"{message}\"");
        }

        void ShowPersonInfo()
        {
            Console.WriteLine($"Nombre completo: {firstName} {lastName}");
            Console.WriteLine($"Edad: {age}");
            Console.WriteLine($"Nacionalidad: {nationality}");
            Console.WriteLine($"Profesion: {profession}");
            Console.WriteLine($"Genero: {gender}");
        }
    }
}