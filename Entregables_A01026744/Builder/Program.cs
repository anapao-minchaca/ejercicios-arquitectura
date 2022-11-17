using System;
using System.Collections.Generic;

// Ejemplo de build pattern con pizzas. 

namespace Patrones.Builder
{
    public class MainApp
    {
        public static void Main()
        {

            PizzaBuilder builder;

            Shop shop = new Shop();

            // Construct and display pizzas

            builder = new MargheritaPizza();
            shop.Construct(builder);
            builder.Pizza.Show();

            builder = new QuatroFormaggiPizza();
            shop.Construct(builder);
            builder.Pizza.Show();

            builder = new PepperoniPizza();
            shop.Construct(builder);
            builder.Pizza.Show();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Director' class
    /// </summary>

    class Shop
    {
        public void Construct(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.BuildBase();
            pizzaBuilder.BuildSize();
            pizzaBuilder.BuildCheese();
            pizzaBuilder.BuildIngredients();
        }
    }

    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>

    abstract class PizzaBuilder
    {
        protected Pizza pizza;
        
        // Gets pizza instance
        public Pizza Pizza
        {
            get { return pizza; }
        }

        // Abstract build methods
        public abstract void BuildBase();
        public abstract void BuildSize();
        public abstract void BuildCheese();
        public abstract void BuildIngredients();
    }

    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>

    class PepperoniPizza : PizzaBuilder
    {
        public PepperoniPizza()
        {
            pizza = new Pizza("Pepperoni");
        }

        public override void BuildBase()
        {
            pizza["base"] = "Normal crust";
        }

        public override void BuildSize()
        {
            pizza["size"] = "Medium";
        }

        public override void BuildCheese()
        {
            pizza["cheese"] = "Mozzarella, Parmesan";
        }

        public override void BuildIngredients()
        {
            pizza["ingredients"] = "Tomato, Pepperoni";
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>

    class QuatroFormaggiPizza : PizzaBuilder
    {
        public QuatroFormaggiPizza()
        {
            pizza = new Pizza("Quatro Formaggi");
        }

        public override void BuildBase()
        {
            pizza["base"] = "Thick crust";
        }

        public override void BuildSize()
        {
            pizza["size"] = "Large";
        }

        public override void BuildCheese()
        {
            pizza["cheese"] = "Mozzarella, Gorgonzola, Fontina, Parmesan";
        }

        public override void BuildIngredients()
        {
            pizza["ingredients"] = "Tomato";
        }
    }


    /// <summary>
    /// The 'ConcreteBuilder3' class
    /// </summary>

    class MargheritaPizza : PizzaBuilder
    {
        public MargheritaPizza()
        {
            pizza = new Pizza("Margherita");
        }

        public override void BuildBase()
        {
            pizza["base"] = "Thin crust";
        }

        public override void BuildSize()
        {
            pizza["size"] = "Small";
        }

        public override void BuildCheese()
        {
            pizza["cheese"] = "Mozzarella";
        }

        public override void BuildIngredients()
        {
            pizza["ingredients"] = "Tomato, Basil";
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>

    class Pizza
    {
        private string _pizzaType;

        private Dictionary<string, string> _parts =

          new Dictionary<string, string>();

        // Constructor

        public Pizza(string pizzaType)
        {
            this._pizzaType = pizzaType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Pizza Type: {0}", _pizzaType);
            Console.WriteLine(" Base : {0}", _parts["base"]);
            Console.WriteLine(" Size : {0}", _parts["size"]);
            Console.WriteLine(" Cheese: {0}", _parts["cheese"]);
            Console.WriteLine(" Ingredients : {0}", _parts["ingredients"]);
        }
    }
}