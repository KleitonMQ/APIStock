using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIStock.src.Entities
{
    public class Product
    {
        public Product(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public void AddQuantity(int valueToAdd)
        {
            this.Quantity += valueToAdd;
        }

        public void DecreaseQuantity(int valueToDecrease)
        {
            this.Quantity -= valueToDecrease;
        }
    }
}