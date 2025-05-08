namespace Library
{
    partial class Form5
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
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            Mark = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Reader = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(38, 23);
            button4.Name = "button4";
            button4.Size = new Size(201, 69);
            button4.TabIndex = 16;
            button4.Text = "Добавить читателя";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(275, 23);
            button1.Name = "button1";
            button1.Size = new Size(169, 69);
            button1.TabIndex = 17;
            button1.Text = "Меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(478, 125);
            label1.Name = "label1";
            label1.Size = new Size(505, 62);
            label1.TabIndex = 18;
            label1.Text = "Выдать/принять книгу";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, ReadingRoom, PublishingHouse, YearPublication, Mark, StartDate, FinishDate, Reader });
            dataGridView1.Location = new Point(67, 202);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1491, 229);
            dataGridView1.TabIndex = 19;
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
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Resizable = DataGridViewTriState.True;
            ReadingRoom.Width = 125;
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
            // Mark
            // 
            Mark.HeaderText = "Метка";
            Mark.MinimumWidth = 6;
            Mark.Name = "Mark";
            Mark.Width = 125;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Дата выдачи";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.Width = 125;
            // 
            // FinishDate
            // 
            FinishDate.HeaderText = "Дата возврата";
            FinishDate.MinimumWidth = 6;
            FinishDate.Name = "FinishDate";
            FinishDate.Width = 125;
            // 
            // Reader
            // 
            Reader.HeaderText = "Читатель";
            Reader.MinimumWidth = 6;
            Reader.Name = "Reader";
            Reader.Width = 125;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(1234, 463);
            button2.Name = "button2";
            button2.Size = new Size(142, 90);
            button2.TabIndex = 20;
            button2.Text = "Обновить таблицу";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 481);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 21;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 522);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 22;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 563);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 23;
            label4.Text = "Издательство";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 606);
            label5.Name = "label5";
            label5.Size = new Size(143, 31);
            label5.TabIndex = 24;
            label5.Text = "Год издания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 646);
            label6.Name = "label6";
            label6.Size = new Size(169, 31);
            label6.TabIndex = 25;
            label6.Text = "Читальный зал";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(187, 487);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 528);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 27);
            textBox2.TabIndex = 27;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 567);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(560, 27);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(216, 610);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(560, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(242, 650);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(560, 27);
            textBox5.TabIndex = 30;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(848, 481);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 35);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "Выдан";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(848, 534);
            label7.Name = "label7";
            label7.Size = new Size(148, 31);
            label7.TabIndex = 32;
            label7.Text = "Дата выдачи";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1017, 538);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(147, 27);
            textBox6.TabIndex = 33;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(848, 588);
            label8.Name = "label8";
            label8.Size = new Size(163, 31);
            label8.TabIndex = 34;
            label8.Text = "Дата возврата";
            label8.Click += label8_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1017, 592);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(147, 27);
            textBox7.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(848, 644);
            label9.Name = "label9";
            label9.Size = new Size(108, 31);
            label9.TabIndex = 36;
            label9.Text = "Читатель";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(962, 648);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(560, 27);
            textBox8.TabIndex = 37;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 747);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button4);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ReadingRoom;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn Mark;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Reader;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
    }
}