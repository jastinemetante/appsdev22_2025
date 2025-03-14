namespace SimpleFormsAppWithCheckedListBox
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
            movieCheckedList = new CheckedListBox();
            movielistBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            add = new Button();
            delete = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // movieCheckedList
            // 
            movieCheckedList.FormattingEnabled = true;
            movieCheckedList.Location = new Point(63, 141);
            movieCheckedList.Name = "movieCheckedList";
            movieCheckedList.Size = new Size(129, 166);
            movieCheckedList.TabIndex = 0;
            movieCheckedList.SelectedIndexChanged += movieCheckedList_SelectedIndexChanged;
            // 
            // movielistBox
            // 
            movielistBox.FormattingEnabled = true;
            movielistBox.ItemHeight = 15;
            movielistBox.Location = new Point(262, 141);
            movielistBox.Name = "movielistBox";
            movielistBox.Size = new Size(120, 169);
            movielistBox.TabIndex = 1;
            movielistBox.SelectedIndexChanged += movielistBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(63, 51);
            label1.Name = "label1";
            label1.Size = new Size(285, 21);
            label1.TabIndex = 2;
            label1.Text = "SIMPLE FAVORITE MOVIE PICKER APP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(63, 103);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 3;
            label2.Text = "Movies/Series List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(262, 103);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 4;
            label3.Text = "My list";
            label3.Click += label3_Click;
            // 
            // add
            // 
            add.Location = new Point(63, 324);
            add.Name = "add";
            add.Size = new Size(129, 27);
            add.TabIndex = 5;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Location = new Point(403, 141);
            delete.Name = "delete";
            delete.Size = new Size(90, 30);
            delete.TabIndex = 6;
            delete.Text = "Remove";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.Location = new Point(403, 185);
            clear.Name = "clear";
            clear.Size = new Size(90, 33);
            clear.TabIndex = 7;
            clear.Text = "Clear All";
            clear.UseVisualStyleBackColor = true;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(613, 450);
            Controls.Add(clear);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(movielistBox);
            Controls.Add(movieCheckedList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox movieCheckedList;
        private ListBox movielistBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button add;
        private Button delete;
        private Button clear;
    }
}
