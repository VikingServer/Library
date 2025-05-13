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
    public partial class ReaderMenuForm : Form
    {
        public Form Authorization;
        public ReaderMenuForm()
        {
            InitializeComponent();
            Authorization = new AuthorizationForm();
        }

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            Close();
            ReaderSelectBookForm selectBookForm = new ReaderSelectBookForm();
            selectBookForm.Show();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            Close();
            ReaderBooksForm readerBooks = new ReaderBooksForm();
            readerBooks.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Authorization.Show();
            Close();
        }
    }
}
