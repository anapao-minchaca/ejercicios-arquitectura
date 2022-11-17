// Patrón Composite -- Ejemplo real

// Composite es un patrón de diseño estructural que te permite componer objetos en estructuras 
// de árbol y trabajar con esas estructuras como si fueran objetos individuales.

using System;
using System.Collections.Generic;

namespace Patrones.CompositeReal
{

    /// <summary>

    /// MainApp startup class for Real-World 

    /// Composite Design Pattern.

    /// </summary>

    class MainApp
    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {

            // Create a tree structure 

            CompositeElement root =

              new CompositeElement("Amigos");

            root.Add(new PrimitiveElement("Max"));

            root.Add(new PrimitiveElement("Diana"));

            root.Add(new PrimitiveElement("Ana"));



            // Create a branch

            CompositeElement comp =

            new CompositeElement("Ruben");

            // como crear objetos con jerarquia

            comp.Add(new PrimitiveElement("Vicente Cubells"));

            comp.Add(new PrimitiveElement("Patricio"));

            root.Add(comp);



            // Add and remove a PrimitiveElement

            PrimitiveElement pe =

              new PrimitiveElement("Lorenzo");

            root.Add(pe);


            // Recursively display nodes

            root.Display(1);

            //pe.Add(null);


            // Wait for user

            Console.ReadKey();

        }

    }



    /// <summary>

    /// The 'Component' Treenode

    /// </summary>

    abstract class DrawingElement
    {
        protected string _name;


        // Constructor

        public DrawingElement(string name)
        {
            this._name = name;
        }


        public abstract void Add(DrawingElement d);

        public abstract void Remove(DrawingElement d);

        public abstract void Display(int indent);

    }



    /// <summary>

    /// The 'Leaf' class

    /// </summary>

    class PrimitiveElement : DrawingElement
    {
        // Constructor

        public PrimitiveElement(string name): base(name)
        {

        }

        public override void Add(DrawingElement c)
        {
            Console.WriteLine("Este elemento no puede tener hijos");
        }

        public override void Remove(DrawingElement c)
        {
            Console.WriteLine("Este elemento no tiene hijos");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + _name);
        }
    }



    /// <summary>

    /// The 'Composite' class

    /// </summary>

    class CompositeElement : DrawingElement
    {

        private List<DrawingElement> elements = new List<DrawingElement>();


        // Constructor

        public CompositeElement(string name): base(name)
        {

        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + _name);


            // Display each child element on this node

            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);

                // eliminar objetos con jerarquia
                d.Remove(new PrimitiveElement("Ruben"));
            }
        }
    }
}
