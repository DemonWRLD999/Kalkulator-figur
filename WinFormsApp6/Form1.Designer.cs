namespace WinFormsApp6
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(511, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Oblicz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(480, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(277, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 60);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Bok 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 60);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Bok 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 60);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Figura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 241);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 7;
            label4.Text = "Pole";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 297);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "Obwód";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 241);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 9;
            label6.Text = "Obliczanie pola...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(288, 297);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 10;
            label7.Text = "Obliczanie obwodu...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
