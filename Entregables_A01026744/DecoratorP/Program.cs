using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{

    // Este ejemplo usa un restaurante con platillos para demostrar el decorador
    class Program
    {
        static void Main(string[] args)
        {
            Pasta pasta = new Pasta
            {
                Tipo = "Spaguetti",
                Salsa = "Pomodoro",
                Disponibles = 2
            };

            Ensalada ensalada = new Ensalada
            {
                Aderezo = "Cesar",
                Queso = "Parmesano",
                Disponibles = 4
            };

            pasta.Imprimir();
            ensalada.Imprimir();

            PedidoPlato pedido = new PedidoPlato { Documento = pasta };

            pedido.Pedir("Victoria");
            pedido.Pedir("Antonio");
            pedido.Pedir("Ana");
            pedido.Imprimir();

            PedidoPlato pedidoEnsalada = new PedidoPlato { Documento = ensalada };

            pedidoEnsalada.Pedir("Patricio");
            pedidoEnsalada.Pedir("Paola");
            pedidoEnsalada.Pedir("Rodrigo");
            pedidoEnsalada.Imprimir();

            Console.ReadKey();
        }
    }

    // clase abstracta de decorador
    abstract class Doc
    {
        public int Disponibles {get; set;}

        public abstract void Imprimir();
    }

    class Pasta : Doc
    {
        public string Tipo { get; set; }
        public string Salsa {get; set;}

        public override void Imprimir()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Pasta: ");
            Console.WriteLine("Tipo: {0}", Tipo);
            Console.WriteLine("Salsa: {0}", Salsa);
            Console.WriteLine("Disponibles: {0}", Disponibles);
        }
    }

    class Ensalada : Doc
    {
        public string Aderezo {get; set;}
        public string Queso {get; set;}

        public override void Imprimir()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Ensalada: ");
            Console.WriteLine("Aderezo: {0}", Aderezo);
            Console.WriteLine("Número Revista: {0}", Queso);
            Console.WriteLine("Disponibles: {0}", Disponibles);
            Console.WriteLine("-------------------");
        }
    }

    abstract class Decorator : Doc
    {

        private Doc documento;

        public Doc Documento { 
            get { return documento; } 
            set{documento = value;} 
        }

        public abstract void Pedir(string nombre);

        public override void Imprimir()
        {
            Documento.Imprimir();
        }
    }

    class PedidoPlato : Decorator
    {
        List<string> pedidos = new List<string>();

        public override void Pedir(string nombre)
        {
            if (Documento.Disponibles > 0){
                pedidos.Add(nombre);
                Documento.Disponibles--;
            } else {
                Console.WriteLine("No hay suficientes ingredientes para la orden de {0} !", nombre);
            }
        }

        public override void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("-------------------");
            Console.WriteLine("Pedidos realizados: ");

            foreach (string s in pedidos)
            {
                Console.WriteLine("Platillo pedido por: {0}", s);
            }
        }
    }
}