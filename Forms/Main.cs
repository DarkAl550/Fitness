using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitnessApp.Controllers;
using FitnessApp.Database;

namespace FitnessApp
{
    public partial class Main : Form
    {
        public string username;
        public string userId;
        public string userMass;
        public string userHieght;
        public Main()
        {
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessDataSet.Food". При необходимости она может быть перемещена или удалена.
            this.foodTableAdapter.Fill(this.fitnessDataSet.Food);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessDataSet.Exesize". При необходимости она может быть перемещена или удалена.
            this.exesizeTableAdapter.Fill(this.fitnessDataSet.Exesize);

            label1.Text = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            groupBox1.Text = "Упражнения";
            groupBox1.Visible = true;
            textBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
            groupBox1.Text = "Приемы пищи";
            groupBox1.Visible = true;
            textBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Text = "Рекомендации";
            textBox1.Visible = true;
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            textBox1.Text = (!String.IsNullOrEmpty(MainController.GenerateRecomends(userMass, userHieght))) ? MainController.GenerateRecomends(userMass, userHieght) : "Нет подходящих рекомендаций!";
        }
    }
}
