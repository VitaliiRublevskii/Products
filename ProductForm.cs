using System.Text.Json;

namespace WinFormsApp1
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();

            brandListBox.Items.Add("Samsung");
            brandListBox.Items.Add("Apple");
            brandListBox.Items.Add("Nokia");
            brandListBox.Items.Add("Google");
            brandListBox.Items.Add("Xiaomi");


            //string prodFromFile = File.ReadAllText("product.json");
            //List<Product> products = JsonSerializer.Deserialize<List<Product>>(prodFromFile);


            
        }

        public ProductForm(string userLogin) : this() => userLabel.Text = $"Hello, {userLogin}";
        
        

        private void brandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodFromFile = File.ReadAllText("product.json");
            List<Product> products = JsonSerializer.Deserialize<List<Product>>(prodFromFile);
            if (brandListBox.SelectedIndex >= 0 && brandListBox.SelectedIndex <= brandListBox.Items.Count)
            {
                prodComboBox.Items.Clear();
                prodComboBox.Text = String.Empty;
                if (brandListBox.Items[brandListBox.SelectedIndex] == "Samsung")
                {
                    prodComboBox.Items.Add("S23 Ultra");
                    prodComboBox.Items.Add("S22 Ultra");
                    prodComboBox.Items.Add("S22");
                    
                }
                else if (brandListBox.Items[brandListBox.SelectedIndex] == "Apple")
                {
                    prodComboBox.Items.Add("15 pro");
                    prodComboBox.Items.Add("15 pro max");
                    prodComboBox.Items.Add("14 pro max");
                    prodComboBox.Items.Add("14");
                }
                else if (brandListBox.Items[brandListBox.SelectedIndex] == "Nokia")
                {
                    foreach (var p in products)
                    {
                        if (p.Name == "Nokia")
                            prodComboBox.Items.Add(p.Model);
                    }
                        
                }
                else
                {
                    prodComboBox.Items.Add("No items");
                }
            }

        }

        private void addProdBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello in add product!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductAddForm form = new ProductAddForm();
            form.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
