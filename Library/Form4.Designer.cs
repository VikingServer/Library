namespace Library
{
    partial class Form4
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
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Author = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(29, 12);
            button3.Name = "button3";
            button3.Size = new Size(224, 69);
            button3.TabIndex = 13;
            button3.Text = "Добавить читальный зал";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(293, 12);
            button2.Name = "button2";
            button2.Size = new Size(244, 69);
            button2.TabIndex = 15;
            button2.Text = "Добавить книгу";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(575, 12);
            button4.Name = "button4";
            button4.Size = new Size(169, 69);
            button4.TabIndex = 16;
            button4.Text = "Меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(612, 108);
            label1.Name = "label1";
            label1.Size = new Size(207, 62);
            label1.TabIndex = 17;
            label1.Text = "Справка";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Author, Count, ReadingRoom });
            dataGridView1.Location = new Point(411, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(673, 256);
            dataGridView1.TabIndex = 18;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Count
            // 
            Count.HeaderText = "Количество";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Resizable = DataGridViewTriState.True;
            Count.Width = 125;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Width = 125;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(575, 628);
            button1.Name = "button1";
            button1.Size = new Size(381, 69);
            button1.TabIndex = 19;
            button1.Text = "Печать";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 513);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 27);
            textBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 507);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 22;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(118, 558);
            label3.Name = "label3";
            label3.Size = new Size(169, 31);
            label3.TabIndex = 23;
            label3.Text = "Читальный зал";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 564);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 27);
            textBox2.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(853, 509);
            label4.Name = "label4";
            label4.Size = new Size(149, 31);
            label4.TabIndex = 25;
            label4.Text = "Путь к файлу";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1008, 515);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 27);
            textBox3.TabIndex = 26;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 756);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button4;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ReadingRoom;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Count;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}