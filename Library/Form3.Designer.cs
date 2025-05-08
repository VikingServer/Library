namespace Library
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            NameReadingRoom = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
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
            label1.Location = new Point(438, 113);
            label1.Name = "label1";
            label1.Size = new Size(563, 62);
            label1.TabIndex = 1;
            label1.Text = "Добавить читальный зал";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameReadingRoom });
            dataGridView1.Location = new Point(429, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(572, 138);
            dataGridView1.TabIndex = 2;
            // 
            // NameReadingRoom
            // 
            NameReadingRoom.HeaderText = "Название";
            NameReadingRoom.MinimumWidth = 500;
            NameReadingRoom.Name = "NameReadingRoom";
            NameReadingRoom.Width = 500;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(27, 21);
            button2.Name = "button2";
            button2.Size = new Size(244, 69);
            button2.TabIndex = 14;
            button2.Text = "Добавить книгу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.HotTrack;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(312, 21);
            button4.Name = "button4";
            button4.Size = new Size(169, 69);
            button4.TabIndex = 15;
            button4.Text = "Меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(881, 488);
            button1.Name = "button1";
            button1.Size = new Size(169, 76);
            button1.TabIndex = 16;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 488);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 17;
            label2.Text = "Название";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 494);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(560, 27);
            textBox1.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(881, 592);
            button3.Name = "button3";
            button3.Size = new Size(169, 76);
            button3.TabIndex = 25;
            button3.Text = "Изменить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.HotTrack;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.WindowText;
            button5.Location = new Point(881, 685);
            button5.Name = "button5";
            button5.Size = new Size(169, 76);
            button5.TabIndex = 26;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.HotTrack;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.WindowText;
            button6.Location = new Point(1144, 520);
            button6.Name = "button6";
            button6.Size = new Size(200, 148);
            button6.TabIndex = 27;
            button6.Text = "Обновить таблицу";
            button6.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1388, 773);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button3;
        private Button button2;
        private DataGridViewTextBoxColumn NameReadingRoom;
        private Button button4;
        private Label label2;
        private TextBox textBox1;
        private Button button5;
        private Button button6;
    }
}