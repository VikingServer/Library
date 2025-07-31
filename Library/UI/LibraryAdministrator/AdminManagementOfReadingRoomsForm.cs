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
    public partial class AdminManagementOfReadingRoomsForm : Form
    {
        public AdminManagementOfReadingRoomsForm()
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
            AdminBookManagementForm form2 = new AdminBookManagementForm();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            AdminMenuForm form10 = new AdminMenuForm();
            form10.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            AdminMenuForm form10 = new AdminMenuForm();
            form10.Show();
        }
    }
}
