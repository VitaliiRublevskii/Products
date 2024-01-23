using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class ProductAddForm : Form
    {
        //List<Product> products = new List<Product>();
        //Product product1 = new Product("iPhone", "15 Pro Max", "256Gb", 60499, "6,7");
        //Product product2 = new Product("iPhone", "14 Pro Max", "512Gb", 65499, "6,7");
        //Product product3 = new Product("Samsung", "Galaxy S24 Ultra", "512Gb", 57999, "6,8");
        


        public ProductAddForm()
        {
            InitializeComponent();
            
        }
        

        private void canselBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string prodFromFile = File.ReadAllText("product.json");
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(prodFromFile);
            //products.Add(product1);
            //products.Add(product2);
            //products.Add(product3);

            Product product = new Product();
            product.Name = nameTB.Text;
            product.Model = modelTB.Text;
            product.Memory = memoryTB.Text;
            product.Price = double.Parse(priceTB.Text);
            product.Dimensions = dimensionTB.Text;
            products.Add(product);

            string prodInText = JsonSerializer.Serialize(products);
            File.AppendAllText("product.json", prodInText);

            
            Close();         

        }
    }
}
