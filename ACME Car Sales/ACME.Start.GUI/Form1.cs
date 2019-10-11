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
    }
}
