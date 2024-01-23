using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class RigistrForm : Form
    {

        User vlad99 = new User("vlad99", "12345");
        User boris11 = new User("boris11", "112233");
        User boris12 = new User("boris12", "55555");
        List<User> users = new List<User>();
        public RigistrForm()
        {
            InitializeComponent();
            string usersFile = File.ReadAllText("user.json");
            List<User> users = JsonSerializer.Deserialize<List<User>>(usersFile);

        }
        

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void RegBtn_Click(object sender, EventArgs e)
        {
            //users.Add(vlad99);
            //users.Add(boris12);
            //users.Add(boris11);



            if (passTB.Text == confirmTB.Text)
            {                
                User newUser = new User();
                newUser.Login = loginTB.Text;
                newUser.Password = passTB.Text;
                for (int i = 0; i < users.Count;i++)
                {
                    if (newUser.Login == users[i].Login)
                    {
                        DialogResult res = MessageBox.Show("Такой логин уже существует!", "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (res == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                    }
                    else
                    {
                        users.Add(newUser);
                        string usersToFaile = JsonSerializer.Serialize(users);
                        File.WriteAllText("user.json", usersToFaile);

                        DialogResult res1 = MessageBox.Show("Пользователь добавлен!", "...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (res1 == DialogResult.OK)
                        {
                            this.Close();
                        }
                        break;
                    }
                }
                                       
                          
            }
            else
            {
                DialogResult res = MessageBox.Show("Пароль не совпадает!", "...", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            
        }
    }



//    foreach (User log in users)
//                {
//                    if (log.Login == newUser.Login)
//                    {
//                        DialogResult res = MessageBox.Show("Такой логин уже существует!", "...", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        if (res == DialogResult.OK)
//                        {
//                            this.Close();
//    }
//                        break;
//                    }
//                    else
//{
//    users.Add(newUser);
//    string usersToFaile = JsonSerializer.Serialize(users);
//    File.WriteAllText("user.json", usersToFaile);

//    DialogResult res1 = MessageBox.Show("Пользователь добавлен!", "...", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    if (res1 == DialogResult.OK)
//    {
//        this.Close();
//    }
//}

//Close();
//                }
}
