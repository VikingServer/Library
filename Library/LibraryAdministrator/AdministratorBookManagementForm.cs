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
    public partial class AdministratorBookManagementForm : Form
    {
        public AdministratorBookManagementForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdministratorManagementOfReadingRoomsForm form3 = new AdministratorManagementOfReadingRoomsForm();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorMenuLibraryForm form10 = new AdministratorMenuLibraryForm();
            form10.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorMenuLibraryForm form10 = new AdministratorMenuLibraryForm();
            form10.Show();
        }
    }
}
