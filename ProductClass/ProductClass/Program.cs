using System;

namespace ProductClass
{
    enum Categories
    {
        Dairy, Fruit, Beverages, Bread
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product firstProduct = new Product(10.5, "lapte", new DateTime(2022,01,05), "Napolact", Categories.Dairy);
            Console.WriteLine(firstProduct.ExpirationDate);
        }
    }
}

/*
Model the Product class knowing that a product:
has a weight
has a name
has a production date
has an expiration date
has a producer

and it can be in one of categories : Dairy, Fruit, Beverages, Bread

we also knoow that it expires differently based on the category it belongs to:
fruits expire in 2 days
beverages expire in 3 years
dairy expire in 1 week
bread expires in 4 days
*/
