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
        public ReaderMenuForm()
        {
            InitializeComponent();
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
            ReaderBooks readerBooks = new ReaderBooks();
            readerBooks.Show();
        }
    }
}
