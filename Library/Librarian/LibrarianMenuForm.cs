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
    public partial class LibrarianMenuForm : Form
    {
        //public Form Authorization { get; set; }
        public LibrarianMenuForm()
        {
            InitializeComponent();
            //Authorization = new AuthorizationForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianBookKeeping form12 = new LibrarianBookKeeping();
            form12.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianBookManagmentForm form5 = new LibrarianBookManagmentForm();
            form5.Show();
        }

        private void btnAddReader_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianManageReadersForm form6 = new LibrarianManageReadersForm();
            form6.Show();
        }

        private void btnAccounting_Click(object sender, EventArgs e)
        {
            Close();
            LibrarianBookKeeping bookKeeping = new LibrarianBookKeeping();
            bookKeeping.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Authorization.Show();
            Close();
        }
    }
}
