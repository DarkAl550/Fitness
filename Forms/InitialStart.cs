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
    public partial class InitialStart : Form
    {
        public InitialStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitialStartController.createServerLogFile(textBox1.Text, textBox2.Text, true);
            try
            {
                Database.DatabaseManager.ConnOpen();
                Database.DatabaseManager.ConnClosed();
                Database.DataManager.CreateTables();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
               MessageBox.Show("Вы ввели некорректные данные!\nПроверьте введенные данные и попробуйте снова!");
            }
            
        }
    }
}
