namespace Library
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            Giving = new DataGridViewTextBoxColumn();
            DateFinish = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            checkBox1 = new CheckBox();
            label7 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(244, 69);
            button2.TabIndex = 11;
            button2.Text = "Мои книги";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(292, 12);
            button4.Name = "button4";
            button4.Size = new Size(169, 69);
            button4.TabIndex = 14;
            button4.Text = "Меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(508, 102);
            label1.Name = "label1";
            label1.Size = new Size(340, 62);
            label1.TabIndex = 15;
            label1.Text = "Выбрать книгу";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, PublishingHouse, YearPublication, ReadingRoom, Giving, DateFinish });
            dataGridView1.Location = new Point(241, 181);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1159, 226);
            dataGridView1.TabIndex = 16;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 6;
            NameBook.Name = "NameBook";
            NameBook.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // PublishingHouse
            // 
            PublishingHouse.HeaderText = "Издательство";
            PublishingHouse.MinimumWidth = 6;
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Width = 125;
            // 
            // YearPublication
            // 
            YearPublication.HeaderText = "Год издания";
            YearPublication.MinimumWidth = 6;
            YearPublication.Name = "YearPublication";
            YearPublication.Width = 125;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Resizable = DataGridViewTriState.True;
            ReadingRoom.Width = 125;
            // 
            // Giving
            // 
            Giving.HeaderText = "Выдан";
            Giving.MinimumWidth = 6;
            Giving.Name = "Giving";
            Giving.Width = 125;
            // 
            // DateFinish
            // 
            DateFinish.HeaderText = "Дата возврата";
            DateFinish.MinimumWidth = 6;
            DateFinish.Name = "DateFinish";
            DateFinish.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 432);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 23;
            label2.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 438);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 480);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 29;
            label3.Text = "Автор";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 486);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 531);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(560, 27);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(161, 585);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 27);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(187, 632);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(560, 27);
            textBox5.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 527);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 35;
            label4.Text = "Издательство";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 581);
            label5.Name = "label5";
            label5.Size = new Size(143, 31);
            label5.TabIndex = 36;
            label5.Text = "Год издания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 628);
            label6.Name = "label6";
            label6.Size = new Size(169, 31);
            label6.TabIndex = 37;
            label6.Text = "Читальный зал";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(888, 438);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 35);
            checkBox1.TabIndex = 38;
            checkBox1.Text = "Выдан";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(888, 482);
            label7.Name = "label7";
            label7.Size = new Size(163, 31);
            label7.TabIndex = 39;
            label7.Text = "Дата возврата";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1057, 486);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 27);
            textBox6.TabIndex = 40;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 755);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Name = "Form8";
            Text = "Выбрать книгу";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button4;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn ReadingRoom;
        private DataGridViewTextBoxColumn Giving;
        private DataGridViewTextBoxColumn DateFinish;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox textBox6;
    }
}