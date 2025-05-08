namespace Library
{
    partial class Form13
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(608, 95);
            label1.Name = "label1";
            label1.Size = new Size(221, 62);
            label1.TabIndex = 1;
            label1.Text = "Читатель";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(160, 219);
            button2.Name = "button2";
            button2.Size = new Size(252, 98);
            button2.TabIndex = 13;
            button2.Text = "Выбрать книгу";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(564, 219);
            button1.Name = "button1";
            button1.Size = new Size(252, 98);
            button1.TabIndex = 14;
            button1.Text = "Мои книги";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(961, 219);
            button3.Name = "button3";
            button3.Size = new Size(252, 98);
            button3.TabIndex = 15;
            button3.Text = "Информация о библиотеке";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 762);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Name = "Form13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}