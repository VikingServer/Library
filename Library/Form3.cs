using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void btnBookOperations_Click(object sender, EventArgs e)
        {
            Close();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Form10 form10 = new Form10();
            form10.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            Form10 form10 = new Form10();
            form10.Show();
        }
    }
}
