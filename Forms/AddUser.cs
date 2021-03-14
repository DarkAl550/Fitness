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
    public partial class AddUser : Form
    { 
        private string[] cb1Values = { "Пользователь", "Тренер" };
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date;
            Random r = new Random();
            string[] columns = new string[]
            {
                "Name",
                "Birthdate",
                "Hieght",
                "Mass",
                "Status"
            };
            string[] values = new string[]
            {
                textBox1.Text,
                dateTimePicker1.Value,
                textBox2.Text,
                textBox3.Text,
                comboBox1.Text = (comboBox1.Text == "Тренер")? "1": "0"
            };
            Database.DataManager.InsertValuses("Users", String.Join(",", columns), String.Join(",",values), r.Next(int.MaxValue));
            MessageBox.Show("Новый пользователь успешно создан!");
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(cb1Values);
        }
    }
}
