namespace SimpleFavoriteCartoonFormApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            cartoonpictureBox = new PictureBox();
            view = new Button();
            clear = new Button();
            ((System.ComponentModel.ISupportInitialize)cartoonpictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(81, 31);
            label1.Name = "label1";
            label1.Size = new Size(549, 35);
            label1.TabIndex = 0;
            label1.Text = "SIMPLE FAVORITE CARTOON CHARACTER PICKER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Moccasin;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(61, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 26);
            label2.TabIndex = 1;
            label2.Text = "Select an Item";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Moccasin;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(484, 100);
            label3.Name = "label3";
            label3.Size = new Size(58, 26);
            label3.TabIndex = 2;
            label3.Text = "Image";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.BurlyWood;
            comboBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.ForestGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(48, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 34);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cartoonpictureBox
            // 
            cartoonpictureBox.BackColor = Color.Moccasin;
            cartoonpictureBox.Location = new Point(330, 145);
            cartoonpictureBox.Name = "cartoonpictureBox";
            cartoonpictureBox.Size = new Size(322, 271);
            cartoonpictureBox.TabIndex = 4;
            cartoonpictureBox.TabStop = false;
            cartoonpictureBox.Click += cartoonpictureBox_Click;
            // 
            // view
            // 
            view.BackColor = Color.Moccasin;
            view.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            view.ForeColor = Color.ForestGreen;
            view.Location = new Point(48, 195);
            view.Name = "view";
            view.Size = new Size(151, 49);
            view.TabIndex = 5;
            view.Text = "View";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.Moccasin;
            clear.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clear.ForeColor = Color.ForestGreen;
            clear.Location = new Point(48, 344);
            clear.Name = "clear";
            clear.Size = new Size(151, 46);
            clear.TabIndex = 6;
            clear.Text = "Clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 635);
            Controls.Add(clear);
            Controls.Add(view);
            Controls.Add(cartoonpictureBox);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cartoonpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private PictureBox cartoonpictureBox;
        private Button view;
        private Button clear;
    }
}
