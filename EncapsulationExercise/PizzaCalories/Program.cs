using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            Dough blat = new Dough("white", "chewy", 100);
            Console.WriteLine(blat.GetCalories());

            try
            {
                Dough blat2 = new Dough("Tip500", "Chewy", 100);
                Console.WriteLine(blat.GetCalories());
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message); 
            }

            try
            {
                Dough blat3 = new Dough("white", "chewy", 250);
                Console.WriteLine(blat.GetCalories());
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

            Topping topping = new Topping("meat", 30);
            Console.WriteLine(topping.GetCalories());

        }
    }

    class Pizza
    {
        string name;
        Dough dough;
        List<Topping> toppings;
    }

    class Dough
    {
        const int minWeight = 1;
        const int maxWeight = 200;
        string flourType;
        int weight;
        string bakingTechnique;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;
            private set
            {
                if (value != "crispy" && value != "chewy" && value != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var flourTypeModifier = GetFlourTypeModifier();
            var bakingModifier = GetBakingModifier();

            return this.Weight * 2 * flourTypeModifier * bakingModifier;
        }

        private double GetBakingModifier()
        {
            var baking = this.BakingTechnique.ToLower();
            if (baking == "crispy")
            {
                return 0.9;
            }

            if (baking == "chewy")
            {
                return 1.1;
            }
            return 1;
        }

        private double GetFlourTypeModifier()
        {
            var flourType = this.FlourType.ToLower();
            if (flourType == "white")
            {
                return 1.5;
            }

            return 1;
        }
    }

    class Topping
    {
        const int minWeight = 1;
        const int maxWeight = 50;
        string name;
        int weight;

        public Topping(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.name = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < minWeight || value > maxWeight)
                {
                    throw new ArgumentException($"{value} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }

        public double GetCalories()
        {
            var modifier = GetModifier();
            return this.Weight * 2 * modifier;
        }

        private double GetModifier()
        {
            var modifier = this.Name.ToLower();
            switch (modifier)
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                default:
                    return 0.9;
            }
            //if (modifier == "meat")
            //{
            //    return 1.2;
            //}

            //if (modifier == "veggies")
            //{
            //    return 0.8;
            //}
            //if (modifier == "cheese")
            //{
            //    return 1.1;
            //}
            //return 0.9;
        }
    }
}

















/*
https://github.com/irinascurtu/siit-net/blob/master/encapsulation.md - Pizza Calories
*/
