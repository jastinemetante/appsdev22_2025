namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            comboBox1.Items.Add("Filipino");
            comboBox1.Items.Add("American");
            comboBox1.Items.Add("Japanese");
            comboBox1.Items.Add("Korean");
            comboBox1.Items.Add("Chinese");

            
            comboBox1.SelectedIndex = 0;
        }

        private void Simplefavoritefoodpicker_Click(object sender, EventArgs e)
        {

        }

        private void Cuisine_Click(object sender, EventArgs e)
        {

        }

        private void foodlist_Click(object sender, EventArgs e)
        {

        }

        private void favoritefoodlist_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Select_Click(object sender, EventArgs e)
        {
            string[] Filipino = { "Adobo", "Sinigang", "Lechon", "Pancit", "Tinola" };
            string[] American = { "Hamburger", "Hotdog", "BBQ", "Steak", "Apple Pie" };
            string[] Japanese = { "Sushi", "Ramen", "Tempura", "Sashimi", "Yakitori" };
            string[] Korean = { "Bibimbap", "Kimchi", "Samgyeopsal", "Bulgogi", "Tteokbokki" };
            string[] Chinese = { "Dimsum", "Noodles", "Dumplings", "Peking Duck", "Sweet and Sour Pork" };

            FoodcheckedListBox.Items.Clear();

            if (comboBox1.SelectedItem.ToString().Contains("Filipino"))
            {
                FoodcheckedListBox.Items.AddRange(Filipino);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("American"))
            {
                FoodcheckedListBox.Items.AddRange(American);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Japanese"))
            {
                FoodcheckedListBox.Items.AddRange(Japanese);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Korean"))
            {
                FoodcheckedListBox.Items.AddRange(Korean);
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Chinese"))
            {
                FoodcheckedListBox.Items.AddRange(Chinese);
            }

        }

        private void FoodcheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodcheckedListBox.CheckedItems)
            {
                bool isSelected = FoodcheckedListBox.GetItemChecked(FoodcheckedListBox.Items.IndexOf(item));
                if (isSelected && !MyfavoritefoodListBox.Items.Contains(item))
                {
                    MyfavoritefoodListBox.Items.Add(item);
                }
            }

        }

        private void MyfavoritefoodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (MyfavoritefoodListBox.Items.Count >= -1)
            {
                MyfavoritefoodListBox.Items.Remove(MyfavoritefoodListBox.SelectedItem);
            }

        }

        private void clearall_Click(object sender, EventArgs e)
        {
            MyfavoritefoodListBox.Items.Clear();

        }
    }
}
