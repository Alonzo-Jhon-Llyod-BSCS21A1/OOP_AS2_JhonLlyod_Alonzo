namespace Alonzo
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            userBox = new TextBox();
            passBox = new TextBox();
            button1 = new Button();
            label2 = new Label();
            abc = new Label();
            cba = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 129);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 65);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "USERNAME:";
            label4.Click += label4_Click;
            // 
            // userBox
            // 
            userBox.Location = new Point(159, 62);
            userBox.Name = "userBox";
            userBox.Size = new Size(130, 23);
            userBox.TabIndex = 4;
            userBox.TextChanged += textBox1_TextChanged;
            // 
            // passBox
            // 
            passBox.Location = new Point(159, 126);
            passBox.Name = "passBox";
            passBox.Size = new Size(130, 23);
            passBox.TabIndex = 5;
            passBox.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(136, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "ENTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 9);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 7;
            label2.Text = "FORMS";
            label2.Click += label2_Click;
            // 
            // abc
            // 
            abc.AutoSize = true;
            abc.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            abc.Location = new Point(191, 88);
            abc.Name = "abc";
            abc.Size = new Size(54, 12);
            abc.TabIndex = 8;
            abc.Text = "USERNAME:";
            abc.Click += label5_Click;
            // 
            // cba
            // 
            cba.AutoSize = true;
            cba.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cba.Location = new Point(191, 152);
            cba.Name = "cba";
            cba.Size = new Size(54, 12);
            cba.TabIndex = 9;
            cba.Text = "USERNAME:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 251);
            Controls.Add(cba);
            Controls.Add(abc);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox userBox;
        private TextBox passBox;
        private Button button1;
        private Label label2;
        private Label abc;
        private Label cba;
    }
}
