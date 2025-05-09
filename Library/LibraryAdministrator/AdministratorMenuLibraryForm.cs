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
    public partial class AdministratorMenuLibraryForm : Form
    {
        public AdministratorMenuLibraryForm()
        {
            InitializeComponent();
            label1.Text = "Информация о библиотеке";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorBookManagementForm form2 = new AdministratorBookManagementForm();
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorManagementOfReadingRoomsForm form3 = new AdministratorManagementOfReadingRoomsForm();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Synopsis form4 = new Synopsis();
            form4.Show();
        }
    }
}
