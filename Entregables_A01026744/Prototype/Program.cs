﻿namespace Patron.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //instanciamos dos obj
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            //modificamos el estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Modificamos el estado
            uno.Nombre = "Patricio";
            dos.Nombre = "Frida";

            // verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Creamos una instancia
            CAuto auto = new CAuto("Toyota", 2019, 1000000);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto del prototipo anterior
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el estado
            auto2.Modelo = "Cadillac";

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----");
        }
    }
}