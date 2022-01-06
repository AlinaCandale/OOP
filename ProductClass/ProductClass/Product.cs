using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{
    class Product
    {
        private double weight;
        private string name;
        private DateTime productionDate;
        private string producer;
        private Categories category;

        public double Weight { get => weight; }
        public string Name { get => name; }
        public DateTime ProductionDate { get => productionDate; }
        public string Producer { get => producer; }
        public Categories Category { get => category; }
        public DateTime ExpirationDate 
        {
            get 
            {
                switch (category)
                {
                    case Categories.Dairy:
                        return productionDate.AddDays(7);
                    case Categories.Fruit:
                        return productionDate.AddDays(2);
                    case Categories.Beverages:
                        return productionDate.AddYears(4);
                    case Categories.Bread:
                        return productionDate.AddDays(4);
                    default:
                        return productionDate.Date;
                }
            }
        }

        public Product(double weight, string name, DateTime productionDate, string producer, Categories category)
        {
            this.weight = weight;
            this.name = name;
            this.productionDate = productionDate;
            this.producer = producer;
            this.category = category;
        }
    }
}
