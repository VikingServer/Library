namespace Library
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            button4 = new Button();
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
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(513, 90);
            label1.Name = "label1";
            label1.Size = new Size(365, 62);
            label1.TabIndex = 0;
            label1.Text = "Добавить книгу";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(920, 448);
            button1.Name = "button1";
            button1.Size = new Size(169, 76);
            button1.TabIndex = 9;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(45, 12);
            button2.Name = "button2";
            button2.Size = new Size(244, 69);
            button2.TabIndex = 10;
            button2.Text = "Добавить читальный зал";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, PublishingHouse, YearPublication, ReadingRoom });
            dataGridView1.Location = new Point(259, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(901, 226);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(319, 12);
            button4.Name = "button4";
            button4.Size = new Size(169, 69);
            button4.TabIndex = 13;
            button4.Text = "Меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 470);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 14;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(45, 520);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 15;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(45, 568);
            label4.Name = "label4";
            label4.Size = new Size(156, 31);
            label4.TabIndex = 16;
            label4.Text = "Издательство";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(45, 615);
            label5.Name = "label5";
            label5.Size = new Size(143, 31);
            label5.TabIndex = 17;
            label5.Text = "Год издания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(45, 657);
            label6.Name = "label6";
            label6.Size = new Size(169, 31);
            label6.TabIndex = 18;
            label6.Text = "Читальный зал";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 476);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(128, 526);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(560, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 572);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(560, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(194, 619);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(560, 27);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(220, 663);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(560, 27);
            textBox5.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(920, 546);
            button3.Name = "button3";
            button3.Size = new Size(169, 76);
            button3.TabIndex = 24;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(920, 635);
            button5.Name = "button5";
            button5.Size = new Size(169, 76);
            button5.TabIndex = 25;
            button5.Text = "Списать";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.WindowText;
            button6.Location = new Point(1129, 498);
            button6.Name = "button6";
            button6.Size = new Size(200, 148);
            button6.TabIndex = 26;
            button6.Text = "Обновить таблицу";
            button6.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 749);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
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
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Добавить книгу";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn ReadingRoom;
        private Button button4;
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
        private Button button3;
        private Button button5;
        private Button button6;
    }
}