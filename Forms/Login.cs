using FitnessApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessApp.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(LoginController.checkLogin(textBox1.Text, comboBox1.Text))
            {
                List<Database.DataObjects.Users> users = Database.DataLogic.getUsers($"WHERE Name LIKE '{textBox1.Text}'");
                Main m = new Main
                {
                    username = "Имя: "+users[0].Name,
                    userId = users[0].Id,
                    userHieght = "Рост: "+users[0].Hieght,
                    userMass = "Вес: "+users[0].Mass
                };
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные данные пользователя!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUser a = new AddUser();
            a.Show();
            Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[] { "Пользователь", "Тренер" });
        }
    }
}
