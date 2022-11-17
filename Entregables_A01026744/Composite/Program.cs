using System;
using System.Collections.Generic;

namespace Patrones.CompositeReal
{

    class MainApp
    {

        // Ejemplo para mostrar una red de empleados usando el patrón composite

        static void Main()
        {
            CompositeElement root = new CompositeElement(1, "Luisa");

            root.Add(new PrimitiveElement(3, "Max"));
            root.Add(new PrimitiveElement(10, "Diana"));
            root.Add(new PrimitiveElement(8, "Ana"));

            // Create a branch
            CompositeElement comp = new CompositeElement(2, "Ruben");
            // como crear objetos con jerarquia
            comp.Add(new PrimitiveElement(6, "Vicente Cubells"));
            comp.Add(new PrimitiveElement(12, "Patricio"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement(5, "Lorenzo");
            root.Add(pe);

            // Recursively display nodes
            root.Display(1);
            //pe.Add(null);
            // Wait for user
            Console.ReadKey();
        }
    }

    abstract class DrawingElement
    {
        protected int _ID;
        protected string _name;

        // Constructor
        public DrawingElement(int ID, string name)
        {
            this._ID = ID;
            this._name = name;
        }

        public abstract void Add(DrawingElement d);
        public abstract void Remove(DrawingElement d);
        public abstract void Display(int indent);
    }

    class PrimitiveElement : DrawingElement
    {
        // Constructor
        public PrimitiveElement(int ID, string name): base(ID, name)
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
              new String('-', indent) +  " " + "EmpID=" + _ID + ", " + "Nombre=" + _name);
        }
    }

    /// The 'Composite' class
    class CompositeElement : DrawingElement
    {
        private List<DrawingElement> elements = new List<DrawingElement>();

        // Constructor
        public CompositeElement(int ID, string name): base(ID, name)
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
            Console.WriteLine(new String('-', indent) + "+ " + "EmpID=" + _ID + ", " + "Nombre=" + _name);

            // Display each child element on this node
            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
                // eliminar objetos con jerarquia
                // d.Remove(new PrimitiveElement("Ruben"));
            }
        }
    }
}
