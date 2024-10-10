namespace WinFormsApp1
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
            treeView1 = new TreeView();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(50, 180);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(284, 300);
            treeView1.TabIndex = 0;
            treeView1.DoubleClick += TreeView1_DoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(600, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += TextBox1_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(50, 95);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 5;
            button1.Text = "Начать поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(600, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 30);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Путь начала поиска";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 7;
            label2.Text = "Искомое выражение";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 60);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 11;
            label3.Text = "Файлов проверено:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 60);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 12;
            label4.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 60);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 13;
            label5.Text = "Совпадений:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 60);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 14;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 98;
            label7.Text = "Время поиска:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 140);
            label8.Name = "label8";
            label8.Size = new Size(166, 15);
            label8.TabIndex = 99;
            label8.Text = "Текущая директория поиска:";
            // 
            // button2
            // 
            button2.Location = new Point(250, 95);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 8;
            button2.Text = "Остановить поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(450, 95);
            button3.Name = "button3";
            button3.Size = new Size(150, 23);
            button3.TabIndex = 9;
            button3.Text = "Продолжить поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(650, 95);
            button4.Name = "button4";
            button4.Size = new Size(150, 23);
            button4.TabIndex = 10;
            button4.Text = "Прервать поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 600);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(treeView1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Name = "Form1";
            Text = "Поисковик";
            Load += Form1_Load;
            Resize += Form1_Resize;
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parameters.ParametersSave(textBox1.Text, textBox2.Text);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '/') return;
            else
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            treeView1.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 325);
            label3.Location = new Point(50, this.ClientSize.Height - 90);
            label4.Location = new Point(175, this.ClientSize.Height - 90);
            label5.Location = new Point(50, this.ClientSize.Height - 115);
            label6.Location = new Point(175, this.ClientSize.Height - 115);
            label7.Location = new Point(50, this.ClientSize.Height - 65);
            string[] param = Parameters.ParametersLoad();
            textBox1.Text = param[0];
            textBox2.Text = param[1];
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            treeView1.Size = new Size(this.ClientSize.Width - 100, this.ClientSize.Height - 325);
            label3.Location = new Point(50, this.ClientSize.Height - 90);
            label4.Location = new Point(175, this.ClientSize.Height - 90);
            label5.Location = new Point(50, this.ClientSize.Height - 115);
            label6.Location = new Point(175, this.ClientSize.Height - 115);
            label7.Location = new Point(50, this.ClientSize.Height - 65);
        }

        #endregion

        public TreeView treeView1;
        private TextBox textBox1;
        public Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public Button button2;
        public Button button3;
        public Button button4;
    }
}