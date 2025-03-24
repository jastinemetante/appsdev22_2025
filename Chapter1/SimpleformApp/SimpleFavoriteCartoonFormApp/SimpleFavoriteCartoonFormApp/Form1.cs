namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cartoons = { "Tom and Jerry", "Sponge bob", "Scooby Doo", "Mickey Mouse", "Donald Duck" };
            comboBox1.Items.AddRange(cartoons);
            comboBox1.SelectedIndex = 0;

        }


        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a cartoon");
                return;
            }

            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Tom and Jerry":
                    cartoonpictureBox.Image = Image.FromFile(@"C:/Users/User/Desktop/cartoonimage/tomjerry.jpg");
                    break;
                case "Sponge bob":
                    cartoonpictureBox.Image = Image.FromFile(@"C:/Users/User/Downloads/sp.jpg");
                    break;
                case "Scooby Doo":
                    cartoonpictureBox.Image = Image.FromFile(@"C:/Users/User/Downloads/scb.jpg");
                    break;
                case "Mickey Mouse":
                    cartoonpictureBox.Image = Image.FromFile(@"C:/Users/User/Downloads/mick.jpg");
                    break;
                case "Donald Duck":
                    cartoonpictureBox.Image = Image.FromFile(@"C:/Users/User/Desktop/cartoonimage/dn.jpg");
                    break;

                default:
                    cartoonpictureBox.Image = null;
                    break;
            }

            
        }




        private void clear_Click(object sender, EventArgs e)
        {
            cartoonpictureBox.Image = null;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cartoonpictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
