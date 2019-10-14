using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ACME.DAL;

namespace ACME.Start.GUI
{
    public partial class Form1 : Form
    {
        Repository repo = new Repository();
        public Form1()
        {
            InitializeComponent();

            label1.Text = "Registrera bil";
            label2.Text = "Modell";
            label3.Text = "Registreringsnummer";
            label4.Text = "Max hastighet";
            label5.Text = "Hästkraft";

            button2.Text = "Registrera bil";

            label6.Text = "Bilar i lager";
            button1.Text = "Uppdatera";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Car c in repo.MyCars)
            {
                listBox1.Items.Add(c);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            repo.MyCars.Add(new Car() { Modell = textBox1.Text, RegNum = textBox2.Text, MaxSpeed = textBox3.Text, HästKraft = textBox4.Text });
            Update();
        }

        private void Update()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox1.Focus();
        }
    }
}
