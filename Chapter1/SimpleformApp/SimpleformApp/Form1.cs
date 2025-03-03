namespace SimpleformApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jastine_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metante_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstName.Text;
            string lNameValue = lastName.Text;
            MessageBox.Show($"Hello World!{fNameValue} {lNameValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
