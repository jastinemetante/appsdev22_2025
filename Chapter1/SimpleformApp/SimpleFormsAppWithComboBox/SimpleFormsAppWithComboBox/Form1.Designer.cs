namespace SimpleFormsAppWithComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Simplefavoritefoodpicker = new Label();
            Cuisine = new Label();
            foodlist = new Label();
            favoritefoodlist = new Label();
            comboBox1 = new ComboBox();
            FoodcheckedListBox = new CheckedListBox();
            MyfavoritefoodListBox = new ListBox();
            Select = new Button();
            add = new Button();
            remove = new Button();
            clearall = new Button();
            SuspendLayout();
            // 
            // Simplefavoritefoodpicker
            // 
            Simplefavoritefoodpicker.AutoSize = true;
            Simplefavoritefoodpicker.BackColor = Color.BurlyWood;
            Simplefavoritefoodpicker.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Simplefavoritefoodpicker.ForeColor = Color.Black;
            Simplefavoritefoodpicker.Location = new Point(294, 62);
            Simplefavoritefoodpicker.Name = "Simplefavoritefoodpicker";
            Simplefavoritefoodpicker.Size = new Size(297, 35);
            Simplefavoritefoodpicker.TabIndex = 0;
            Simplefavoritefoodpicker.Text = "Simple Favorite Food Picker";
            Simplefavoritefoodpicker.Click += Simplefavoritefoodpicker_Click;
            // 
            // Cuisine
            // 
            Cuisine.AutoSize = true;
            Cuisine.BackColor = Color.PeachPuff;
            Cuisine.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cuisine.ForeColor = Color.Black;
            Cuisine.Location = new Point(44, 149);
            Cuisine.Name = "Cuisine";
            Cuisine.Size = new Size(72, 30);
            Cuisine.TabIndex = 1;
            Cuisine.Text = "Cuisine";
            Cuisine.Click += Cuisine_Click;
            // 
            // foodlist
            // 
            foodlist.AutoSize = true;
            foodlist.BackColor = Color.PeachPuff;
            foodlist.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodlist.Location = new Point(223, 149);
            foodlist.Name = "foodlist";
            foodlist.Size = new Size(92, 30);
            foodlist.TabIndex = 2;
            foodlist.Text = "Food List";
            foodlist.Click += foodlist_Click;
            // 
            // favoritefoodlist
            // 
            favoritefoodlist.AutoSize = true;
            favoritefoodlist.BackColor = Color.PeachPuff;
            favoritefoodlist.Font = new Font("Segoe Print", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            favoritefoodlist.Location = new Point(475, 149);
            favoritefoodlist.Name = "favoritefoodlist";
            favoritefoodlist.Size = new Size(202, 30);
            favoritefoodlist.TabIndex = 3;
            favoritefoodlist.Text = "My Favorite Food List";
            favoritefoodlist.Click += favoritefoodlist_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.PeachPuff;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FoodcheckedListBox
            // 
            FoodcheckedListBox.BackColor = Color.PeachPuff;
            FoodcheckedListBox.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            FoodcheckedListBox.FormattingEnabled = true;
            FoodcheckedListBox.Location = new Point(223, 184);
            FoodcheckedListBox.Name = "FoodcheckedListBox";
            FoodcheckedListBox.Size = new Size(200, 236);
            FoodcheckedListBox.TabIndex = 5;
            FoodcheckedListBox.SelectedIndexChanged += FoodcheckedListBox_SelectedIndexChanged;
            // 
            // MyfavoritefoodListBox
            // 
            MyfavoritefoodListBox.BackColor = Color.PeachPuff;
            MyfavoritefoodListBox.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MyfavoritefoodListBox.FormattingEnabled = true;
            MyfavoritefoodListBox.ItemHeight = 26;
            MyfavoritefoodListBox.Location = new Point(475, 184);
            MyfavoritefoodListBox.Name = "MyfavoritefoodListBox";
            MyfavoritefoodListBox.Size = new Size(218, 238);
            MyfavoritefoodListBox.TabIndex = 6;
            MyfavoritefoodListBox.SelectedIndexChanged += MyfavoritefoodListBox_SelectedIndexChanged;
            // 
            // Select
            // 
            Select.BackColor = Color.PeachPuff;
            Select.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Select.Location = new Point(44, 229);
            Select.Name = "Select";
            Select.Size = new Size(149, 29);
            Select.TabIndex = 7;
            Select.Text = "Select";
            Select.UseVisualStyleBackColor = false;
            Select.Click += Select_Click;
            // 
            // add
            // 
            add.BackColor = Color.PeachPuff;
            add.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = SystemColors.ActiveCaptionText;
            add.Location = new Point(223, 461);
            add.Name = "add";
            add.Size = new Size(199, 29);
            add.TabIndex = 8;
            add.Text = "Add";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.BackColor = Color.PeachPuff;
            remove.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(705, 184);
            remove.Name = "remove";
            remove.Size = new Size(199, 29);
            remove.TabIndex = 10;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // clearall
            // 
            clearall.BackColor = Color.PeachPuff;
            clearall.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearall.ForeColor = SystemColors.ActiveCaptionText;
            clearall.Location = new Point(705, 229);
            clearall.Name = "clearall";
            clearall.Size = new Size(199, 29);
            clearall.TabIndex = 11;
            clearall.Text = "Clear All";
            clearall.UseVisualStyleBackColor = false;
            clearall.Click += clearall_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 584);
            Controls.Add(clearall);
            Controls.Add(remove);
            Controls.Add(add);
            Controls.Add(Select);
            Controls.Add(MyfavoritefoodListBox);
            Controls.Add(FoodcheckedListBox);
            Controls.Add(comboBox1);
            Controls.Add(favoritefoodlist);
            Controls.Add(foodlist);
            Controls.Add(Cuisine);
            Controls.Add(Simplefavoritefoodpicker);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Simplefavoritefoodpicker;
        private Label Cuisine;
        private Label foodlist;
        private Label favoritefoodlist;
        private ComboBox comboBox1;
        private CheckedListBox FoodcheckedListBox;
        private ListBox MyfavoritefoodListBox;
        private Button Select;
        private Button add;
        private Button remove;
        private Button clearall;
    }
}
