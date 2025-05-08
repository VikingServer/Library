namespace Library
{
    partial class Form6
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(25, 26);
            button4.Name = "button4";
            button4.Size = new Size(201, 69);
            button4.TabIndex = 17;
            button4.Text = "Выдать/принять книгу";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(263, 26);
            button1.Name = "button1";
            button1.Size = new Size(169, 69);
            button1.TabIndex = 18;
            button1.Text = "Меню";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(450, 115);
            label1.Name = "label1";
            label1.Size = new Size(437, 62);
            label1.TabIndex = 19;
            label1.Text = "Добавить читателя";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, ReadingRoom, PublishingHouse, YearPublication, Mark, StartDate, FinishDate, Reader });
            dataGridView1.Location = new Point(12, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1491, 229);
            dataGridView1.TabIndex = 20;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Фамилия";
            NameBook.MinimumWidth = 6;
            NameBook.Name = "NameBook";
            NameBook.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Имя";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Отчество";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Resizable = DataGridViewTriState.True;
            ReadingRoom.Width = 125;
            // 
            // PublishingHouse
            // 
            PublishingHouse.HeaderText = "Номер телефона";
            PublishingHouse.MinimumWidth = 6;
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Width = 125;
            // 
            // YearPublication
            // 
            YearPublication.HeaderText = "Серия";
            YearPublication.MinimumWidth = 6;
            YearPublication.Name = "YearPublication";
            YearPublication.Width = 125;
            // 
            // Mark
            // 
            Mark.HeaderText = "Номер";
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
            FinishDate.HeaderText = "Кем выдан";
            FinishDate.MinimumWidth = 6;
            FinishDate.Name = "FinishDate";
            FinishDate.Width = 125;
            // 
            // Reader
            // 
            Reader.HeaderText = "Адрес регистрации";
            Reader.MinimumWidth = 6;
            Reader.Name = "Reader";
            Reader.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 433);
            label2.Name = "label2";
            label2.Size = new Size(109, 31);
            label2.TabIndex = 22;
            label2.Text = "Фамилия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 437);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 481);
            label3.Name = "label3";
            label3.Size = new Size(59, 31);
            label3.TabIndex = 28;
            label3.Text = "Имя";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 487);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 27);
            textBox2.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 527);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 30;
            label4.Text = "Отчество";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 533);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(560, 27);
            textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(212, 582);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(475, 27);
            textBox4.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 578);
            label5.Name = "label5";
            label5.Size = new Size(190, 31);
            label5.TabIndex = 33;
            label5.Text = "Номер телефона";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(777, 431);
            label6.Name = "label6";
            label6.Size = new Size(79, 31);
            label6.TabIndex = 34;
            label6.Text = "Серия";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(862, 435);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(104, 27);
            textBox5.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1003, 431);
            label7.Name = "label7";
            label7.Size = new Size(85, 31);
            label7.TabIndex = 36;
            label7.Text = "Номер";
            label7.Click += label7_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1094, 435);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(198, 27);
            textBox6.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(778, 527);
            label8.Name = "label8";
            label8.Size = new Size(127, 31);
            label8.TabIndex = 38;
            label8.Text = "Кем выдан";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(932, 533);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(649, 27);
            textBox7.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(778, 483);
            label9.Name = "label9";
            label9.Size = new Size(148, 31);
            label9.TabIndex = 40;
            label9.Text = "Дата выдачи";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(932, 489);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(104, 27);
            textBox8.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(778, 576);
            label10.Name = "label10";
            label10.Size = new Size(219, 31);
            label10.TabIndex = 42;
            label10.Text = "Адрес регистрации";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(1003, 580);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(649, 27);
            textBox9.TabIndex = 43;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(495, 635);
            button2.Name = "button2";
            button2.Size = new Size(142, 90);
            button2.TabIndex = 44;
            button2.Text = "Обновить таблицу";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(932, 635);
            button3.Name = "button3";
            button3.Size = new Size(142, 90);
            button3.TabIndex = 45;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(714, 635);
            button5.Name = "button5";
            button5.Size = new Size(142, 90);
            button5.TabIndex = 46;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 752);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button4);
            Name = "Form6";
            Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Label label10;
        private TextBox textBox9;
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
        private Button button3;
        private Button button5;
    }
}