namespace Library
{
    partial class Form12
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
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            CountOfReader = new DataGridViewTextBoxColumn();
            CountNewReader = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label4 = new Label();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            Reader = new DataGridViewTextBoxColumn();
            Book = new DataGridViewTextBoxColumn();
            NameBook = new DataGridViewTextBoxColumn();
            CountOfBook = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(37, 36);
            button4.Name = "button4";
            button4.Size = new Size(201, 69);
            button4.TabIndex = 17;
            button4.Text = "Добавить читателя";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(268, 36);
            button1.Name = "button1";
            button1.Size = new Size(201, 69);
            button1.TabIndex = 18;
            button1.Text = "Выдать/принять книгу";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(519, 36);
            button2.Name = "button2";
            button2.Size = new Size(201, 69);
            button2.TabIndex = 19;
            button2.Text = "Меню";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(698, 175);
            label1.Name = "label1";
            label1.Size = new Size(125, 62);
            label1.TabIndex = 20;
            label1.Text = "Учет";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CountOfReader, CountNewReader });
            dataGridView1.Location = new Point(37, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(304, 256);
            dataGridView1.TabIndex = 21;
            // 
            // CountOfReader
            // 
            CountOfReader.HeaderText = "Количество читателей";
            CountOfReader.MinimumWidth = 6;
            CountOfReader.Name = "CountOfReader";
            CountOfReader.Resizable = DataGridViewTriState.True;
            CountOfReader.Width = 125;
            // 
            // CountNewReader
            // 
            CountNewReader.HeaderText = "Количество новых читателей";
            CountNewReader.MinimumWidth = 6;
            CountNewReader.Name = "CountNewReader";
            CountNewReader.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 602);
            label2.Name = "label2";
            label2.Size = new Size(63, 31);
            label2.TabIndex = 23;
            label2.Text = "Дата";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 606);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 24;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(636, 656);
            button3.Name = "button3";
            button3.Size = new Size(381, 69);
            button3.TabIndex = 25;
            button3.Text = "Печать";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(362, 602);
            label4.Name = "label4";
            label4.Size = new Size(149, 31);
            label4.TabIndex = 26;
            label4.Text = "Путь к файлу";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(517, 608);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 27);
            textBox3.TabIndex = 27;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Book, NameBook, CountOfBook });
            dataGridView2.Location = new Point(377, 254);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(685, 256);
            dataGridView2.TabIndex = 28;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Reader });
            dataGridView3.Location = new Point(1097, 254);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(328, 256);
            dataGridView3.TabIndex = 29;
            // 
            // Reader
            // 
            Reader.HeaderText = "Читатели без книги";
            Reader.MinimumWidth = 6;
            Reader.Name = "Reader";
            Reader.Width = 125;
            // 
            // Book
            // 
            Book.HeaderText = "Книга";
            Book.MinimumWidth = 6;
            Book.Name = "Book";
            Book.Width = 125;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 6;
            NameBook.Name = "NameBook";
            NameBook.Width = 125;
            // 
            // CountOfBook
            // 
            CountOfBook.HeaderText = "Количество выдачи книги";
            CountOfBook.MinimumWidth = 6;
            CountOfBook.Name = "CountOfBook";
            CountOfBook.Width = 125;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 762);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Name = "Form12";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Button button3;
        private Label label4;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn CountOfReader;
        private DataGridViewTextBoxColumn CountNewReader;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn Reader;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn CountOfBook;
    }
}