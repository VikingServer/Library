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
    public partial class AdminBookManagementForm : Form
    {
        public AdminBookManagementForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminManagementOfReadingRoomsForm form3 = new AdminManagementOfReadingRoomsForm();
            form3.Show();
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
