namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1")
            {
                Form10 form10 = new Form10();
                form10.ShowDialog();
                Hide();

            }

            if (textBox1.Text == "2")
            {
                Form11 form11 = new Form11();
                form11.Show();

            }

            if (textBox1.Text == "3")
            {
                Form13 form13 = new Form13();
                form13.Show();

            }
        }
    }
}
