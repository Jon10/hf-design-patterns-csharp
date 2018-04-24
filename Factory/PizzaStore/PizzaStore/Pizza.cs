using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    abstract class Pizza
    {
        private string _name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;

        public string Name { get => _name; set => _name = value; }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }

    class CheesePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();

            Console.WriteLine($"Dough: {dough}");
            Console.WriteLine($"Sauce: {sauce}");
            Console.WriteLine($"Cheese: {cheese}");
        }

        public override void Cut()
        {
            if (_ingredientFactory is ChicagoPizzaIngredientFactory)
                Console.WriteLine("Cutting the pizza into square slices");
            else
                base.Cut();
        }
    }

    class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            veggies = _ingredientFactory.CreateVeggies();

            Console.WriteLine($"Dough: {dough}");
            Console.WriteLine($"Sauce: {sauce}");
            Console.WriteLine($"Cheese: {cheese}");
            Console.WriteLine("Veggies: ");
            for (int i = 0; i < veggies.Length; i++)
            {
                Console.WriteLine($"\t{veggies[i]}");
            }
        }

        public override void Cut()
        {
            if (_ingredientFactory is ChicagoPizzaIngredientFactory)
                Console.WriteLine("Cutting the pizza into square slices");
            else
                base.Cut();
        }
    }

    class ClamPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            clams = _ingredientFactory.CreateClam();

            Console.WriteLine($"Dough: {dough}");
            Console.WriteLine($"Sauce: {sauce}");
            Console.WriteLine($"Cheese: {cheese}");
            Console.WriteLine($"Clams: {clams}");
        }

        public override void Cut()
        {
            if (_ingredientFactory is ChicagoPizzaIngredientFactory)
                Console.WriteLine("Cutting the pizza into square slices");
            else
                base.Cut();
        }
    }

    class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            veggies = _ingredientFactory.CreateVeggies();
            pepperoni = _ingredientFactory.CreatePepperoni();

            Console.WriteLine($"Dough: {dough}");
            Console.WriteLine($"Sauce: {sauce}");
            Console.WriteLine($"Cheese: {cheese}");
            Console.WriteLine("Veggies: ");
            for (int i = 0; i < veggies.Length; i++)
            {
                Console.WriteLine($"\t{veggies[i]}");
            }
            Console.WriteLine($"Pepperoni: {pepperoni}");
        }

        public override void Cut()
        {
            if (_ingredientFactory is ChicagoPizzaIngredientFactory)
                Console.WriteLine("Cutting the pizza into square slices");
            else
                base.Cut();
        }
    }
}
