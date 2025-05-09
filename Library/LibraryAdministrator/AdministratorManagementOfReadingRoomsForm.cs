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
    public partial class AdministratorManagementOfReadingRoomsForm : Form
    {
        public AdministratorManagementOfReadingRoomsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Synopsis form4 = new Synopsis();
            form4.Show();
        }

        private void btnBookOperations_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorBookManagementForm form2 = new AdministratorBookManagementForm();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorMenuLibraryForm form10 = new AdministratorMenuLibraryForm();
            form10.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            AdministratorMenuLibraryForm form10 = new AdministratorMenuLibraryForm();
            form10.Show();
        }
    }
}
