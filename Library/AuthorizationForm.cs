namespace Library
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                AdministratorMenuLibraryForm form10 = new AdministratorMenuLibraryForm();
                form10.ShowDialog();
                Hide();

            }

            if (textBox1.Text == "2")
            {
                LibrarianMenu form11 = new LibrarianMenu();
                form11.Show();

            }

            if (textBox1.Text == "3")
            {
                ReaderMenuForm form13 = new ReaderMenuForm();
                form13.Show();

            }
        }
    }
}
