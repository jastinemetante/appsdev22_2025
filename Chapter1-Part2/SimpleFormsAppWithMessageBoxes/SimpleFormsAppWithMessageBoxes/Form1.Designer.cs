namespace SimpleFormsAppWithMessageBoxes
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
            label2 = new Label();
            middleName = new TextBox();
            label3 = new Label();
            lastName = new TextBox();
            label4 = new Label();
            suffix = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // firstName
            // 
            firstName.Location = new Point(56, 139);
            firstName.Name = "firstName";
            firstName.Size = new Size(238, 23);
            firstName.TabIndex = 0;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(56, 188);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 2;
            label2.Text = "Middle Name";
            label2.Click += label2_Click;
            // 
            // middleName
            // 
            middleName.Location = new Point(56, 219);
            middleName.Name = "middleName";
            middleName.Size = new Size(238, 23);
            middleName.TabIndex = 3;
            middleName.TextChanged += middleName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(56, 268);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(56, 297);
            lastName.Name = "lastName";
            lastName.Size = new Size(238, 23);
            lastName.TabIndex = 5;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 342);
            label4.Name = "label4";
            label4.Size = new Size(38, 17);
            label4.TabIndex = 6;
            label4.Text = "Suffix";
            label4.Click += label4_Click;
            // 
            // suffix
            // 
            suffix.Location = new Point(56, 370);
            suffix.Name = "suffix";
            suffix.Size = new Size(238, 23);
            suffix.TabIndex = 7;
            suffix.TextChanged += suffix_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(56, 442);
            button1.Name = "button1";
            button1.Size = new Size(238, 30);
            button1.TabIndex = 8;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(76, 37);
            label5.Name = "label5";
            label5.Size = new Size(188, 21);
            label5.TabIndex = 9;
            label5.Text = "Simple Form Application";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(324, 545);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(suffix);
            Controls.Add(label4);
            Controls.Add(lastName);
            Controls.Add(label3);
            Controls.Add(middleName);
            Controls.Add(label2);
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
        private Label label2;
        private TextBox middleName;
        private Label label3;
        private TextBox lastName;
        private Label label4;
        private TextBox suffix;
        private Button button1;
        private Label label5;
    }
}
