using System.Text.Json;

namespace WinFormsApp1
{
    public partial class SignInForm : Form
    {
        List<User> users = new List<User>();
        User vlad99 = new User("vlad99", "12345");
        User boris11 = new User("boris11", "112233");
        User boris12 = new User("boris12", "55555");
        public SignInForm()
        {
            InitializeComponent();
            string usersFile = File.ReadAllText("user.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(usersFile);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = string.Empty;
            passTB.Text = string.Empty;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length >= 5 && passTB.Text.Length >= 5)  //&& !users.Contains(loginTextBox.Text) || 
            {
                MessageBox.Show("Hello in profile!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ProductForm form = new ProductForm(loginTextBox.Text);
                //form.Show();
                form.ShowDialog();

            }
            else
            {
                DialogResult res = MessageBox.Show("Error data!", "...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e) => loginTextBox.BackColor = (loginTextBox.Text.Length < 5) ? Color.Gray : Color.White;

        private void regisrtBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello in registration!", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RigistrForm form = new RigistrForm();
            form.ShowDialog();           

        }
    }
}