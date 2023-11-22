using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectStoicaLuca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Prima_Click(object sender, EventArgs e)
        {
            Form2 p2 = new Form2();
            this.Hide();
            p2.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form p3 = new Form3();
            this.Hide();
            p3.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form4 p4 = new Form4();
            this.Hide();
            p4.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 p5 = new Form5();
            this.Hide();
            p5.ShowDialog();
            this.Show();
        }
    }
}
