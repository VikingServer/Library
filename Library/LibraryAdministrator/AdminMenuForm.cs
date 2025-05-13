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
    public partial class AdminMenuForm : Form
    {
        public Form Authorization;
        public AdminMenuForm()
        {
            InitializeComponent();
            label1.Text = "Информация о библиотеке";
            Authorization = new AuthorizationForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            AdminBookManagementForm form2 = new AdminBookManagementForm();
            form2.Show();
        }

        private void btnAddHall_Click(object sender, EventArgs e)
        {
            Close();
            AdminManagementOfReadingRoomsForm form3 = new AdminManagementOfReadingRoomsForm();
            form3.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Close();
            Synopsis form4 = new Synopsis();
            form4.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Authorization.Show();
            Close();
        }
    }
}
