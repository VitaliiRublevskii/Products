using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Memory { get; set; }
        public double Price { get; set; }
        public string Dimensions { get; set; }

        public Product() { }

        public Product(string name, string model, string memory, double price, string dimensions)
        {
            Name = name;
            Model = model;
            Memory = memory;
            Price = price;
            Dimensions = dimensions;
        }
    }
}
