namespace Library
{
    partial class ReaderMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderMenuForm));
            panelNav = new Panel();
            btnLogout = new Button();
            btnMyBooks = new Button();
            btnSelectBook = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            dataGridView1 = new DataGridView();
            DayOfWeek = new DataGridViewTextBoxColumn();
            OpeningHours = new DataGridViewTextBoxColumn();
            labWorkingSchedule = new Label();
            labInfLibrary = new Label();
            pictureBox1 = new PictureBox();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnMyBooks);
            panelNav.Controls.Add(btnSelectBook);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(340, 883);
            panelNav.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 811);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(340, 72);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyBooks
            // 
            btnMyBooks.BackColor = Color.Transparent;
            btnMyBooks.FlatAppearance.BorderSize = 0;
            btnMyBooks.FlatStyle = FlatStyle.Flat;
            btnMyBooks.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyBooks.ForeColor = Color.White;
            btnMyBooks.Location = new Point(0, 271);
            btnMyBooks.Name = "btnMyBooks";
            btnMyBooks.Size = new Size(340, 55);
            btnMyBooks.TabIndex = 2;
            btnMyBooks.Text = "Мои книги";
            btnMyBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBooks.UseVisualStyleBackColor = false;
            btnMyBooks.Click += btnMyBooks_Click;
            // 
            // btnSelectBook
            // 
            btnSelectBook.BackColor = Color.Transparent;
            btnSelectBook.FlatAppearance.BorderSize = 0;
            btnSelectBook.FlatStyle = FlatStyle.Flat;
            btnSelectBook.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSelectBook.ForeColor = Color.White;
            btnSelectBook.Location = new Point(0, 188);
            btnSelectBook.Name = "btnSelectBook";
            btnSelectBook.Size = new Size(340, 55);
            btnSelectBook.TabIndex = 1;
            btnSelectBook.Text = "Выбрать книгу";
            btnSelectBook.TextAlign = ContentAlignment.MiddleLeft;
            btnSelectBook.UseVisualStyleBackColor = false;
            btnSelectBook.Click += btnSelectBook_Click;
            // 
            // labelNavTitle
            // 
            labelNavTitle.Dock = DockStyle.Top;
            labelNavTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNavTitle.ForeColor = Color.White;
            labelNavTitle.Location = new Point(0, 0);
            labelNavTitle.Name = "labelNavTitle";
            labelNavTitle.Padding = new Padding(12, 22, 0, 22);
            labelNavTitle.Size = new Size(340, 105);
            labelNavTitle.TabIndex = 0;
            labelNavTitle.Text = "Меню";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(340, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1560, 88);
            panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(25, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(188, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Читатель";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(labWorkingSchedule);
            panelContent.Controls.Add(labInfLibrary);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(340, 88);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25, 22, 25, 22);
            panelContent.Size = new Size(1560, 795);
            panelContent.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DayOfWeek, OpeningHours });
            dataGridView1.Location = new Point(836, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(335, 355);
            dataGridView1.TabIndex = 5;
            // 
            // DayOfWeek
            // 
            DayOfWeek.HeaderText = "День недели";
            DayOfWeek.MinimumWidth = 40;
            DayOfWeek.Name = "DayOfWeek";
            DayOfWeek.ReadOnly = true;
            DayOfWeek.Width = 150;
            // 
            // OpeningHours
            // 
            OpeningHours.HeaderText = "Часы работы";
            OpeningHours.Name = "OpeningHours";
            OpeningHours.ReadOnly = true;
            OpeningHours.Width = 142;
            // 
            // labWorkingSchedule
            // 
            labWorkingSchedule.AutoSize = true;
            labWorkingSchedule.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labWorkingSchedule.Location = new Point(836, 21);
            labWorkingSchedule.Name = "labWorkingSchedule";
            labWorkingSchedule.Size = new Size(207, 37);
            labWorkingSchedule.TabIndex = 4;
            labWorkingSchedule.Text = "График работы";
            // 
            // labInfLibrary
            // 
            labInfLibrary.AutoSize = true;
            labInfLibrary.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labInfLibrary.Location = new Point(22, 489);
            labInfLibrary.Name = "labInfLibrary";
            labInfLibrary.Size = new Size(359, 37);
            labInfLibrary.TabIndex = 3;
            labInfLibrary.Text = "Информация о библиотеке";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(720, 422);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // ReaderMenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1900, 883);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "ReaderMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Панель читателя";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnLogout;
        private Button btnMyBooks;
        private Button btnSelectBook;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Label labInfLibrary;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label labWorkingSchedule;
        private DataGridViewTextBoxColumn DayOfWeek;
        private DataGridViewTextBoxColumn OpeningHours;
    }
}