namespace SimpleFormsAppWithMessageBoxes
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

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void suffix_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure you want to submit?",
                                                  "Confirm Submission",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                
                string fNameValue = firstName.Text;
                string mNameValue = middleName.Text;
                string lNameValue = lastName.Text;
                string sNameValue = suffix.Text;

                
                MessageBox.Show($"Hello There! {fNameValue} {mNameValue} {lNameValue} {sNameValue}",
                                "Greetings!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                
                MessageBox.Show("Submission cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
