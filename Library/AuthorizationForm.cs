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
            if (textBoxLogin.Text == "1")
            {
                AdminMenuForm adminMenu = new AdminMenuForm();
                Hide();
                adminMenu.Authorization = this;
                adminMenu.Show();

                CleanTextBox();
            }
            else if (textBoxLogin.Text == "2")
            {
                LibrarianMenuForm librarianMenu = new LibrarianMenuForm();
                Hide();
                librarianMenu.Authorization = this;
                librarianMenu.Show();

                CleanTextBox();

            }
            else if (textBoxLogin.Text == "3")
            {
                ReaderMenuForm readerMenu = new ReaderMenuForm();
                Hide();
                readerMenu.Authorization = this;
                readerMenu.Show();

                CleanTextBox();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CleanTextBox()
        {
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }
    }
}
