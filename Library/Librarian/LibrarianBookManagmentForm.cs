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
    public partial class LibrarianBookManagmentForm : Form
    {
        public LibrarianBookManagmentForm()
        {
            InitializeComponent();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianManageReadersForm form6 = new LibrarianManageReadersForm();
            form6.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianMenu menuLibrarian = new LibrarianMenu();
            menuLibrarian.Show();
        }
    }
}
