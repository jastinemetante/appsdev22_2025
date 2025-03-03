namespace SimpleformApp
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
            firstName = new TextBox();
            label1 = new Label();
            lastName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(85, 80);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += jastine_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(85, 201);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 2;
            lastName.TextChanged += metante_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 183);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(85, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(lastName);
            Controls.Add(label1);
            Controls.Add(firstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstName;
        private Label label1;
        private TextBox lastName;
        private Label label2;
        private Button button1;
    }
}
