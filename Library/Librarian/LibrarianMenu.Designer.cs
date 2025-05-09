namespace Library
{
    partial class LibrarianMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianMenu));
            panelNav = new Panel();
            btnLogout = new Button();
            btnAccounting = new Button();
            btnAddReader = new Button();
            btnAddBook = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            labInfLibrary = new Label();
            pictureBox1 = new PictureBox();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnAccounting);
            panelNav.Controls.Add(btnAddReader);
            panelNav.Controls.Add(btnAddBook);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(340, 1134);
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
            btnLogout.Location = new Point(0, 1065);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(340, 69);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccounting
            // 
            btnAccounting.BackColor = Color.Transparent;
            btnAccounting.FlatAppearance.BorderSize = 0;
            btnAccounting.FlatStyle = FlatStyle.Flat;
            btnAccounting.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccounting.ForeColor = Color.White;
            btnAccounting.Location = new Point(0, 349);
            btnAccounting.Name = "btnAccounting";
            btnAccounting.Size = new Size(340, 52);
            btnAccounting.TabIndex = 3;
            btnAccounting.Text = "Учет";
            btnAccounting.TextAlign = ContentAlignment.MiddleLeft;
            btnAccounting.UseVisualStyleBackColor = false;
            btnAccounting.Click += btnAccounting_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.BackColor = Color.Transparent;
            btnAddReader.FlatAppearance.BorderSize = 0;
            btnAddReader.FlatStyle = FlatStyle.Flat;
            btnAddReader.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddReader.ForeColor = Color.White;
            btnAddReader.Location = new Point(0, 271);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(340, 52);
            btnAddReader.TabIndex = 2;
            btnAddReader.Text = "Добавить читателя";
            btnAddReader.TextAlign = ContentAlignment.MiddleLeft;
            btnAddReader.UseVisualStyleBackColor = false;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.Transparent;
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(0, 188);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(340, 52);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Работа с книгами";
            btnAddBook.TextAlign = ContentAlignment.MiddleLeft;
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // labelNavTitle
            // 
            labelNavTitle.Dock = DockStyle.Top;
            labelNavTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNavTitle.ForeColor = Color.White;
            labelNavTitle.Location = new Point(0, 0);
            labelNavTitle.Name = "labelNavTitle";
            labelNavTitle.Padding = new Padding(11, 21, 0, 21);
            labelNavTitle.Size = new Size(340, 136);
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
            panelHeader.Size = new Size(1888, 84);
            panelHeader.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(280, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Библиотекарь";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(labInfLibrary);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(340, 84);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(22, 21, 22, 21);
            panelContent.Size = new Size(1888, 1050);
            panelContent.TabIndex = 2;
            // 
            // labInfLibrary
            // 
            labInfLibrary.AutoSize = true;
            labInfLibrary.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labInfLibrary.Location = new Point(22, 488);
            labInfLibrary.Name = "labInfLibrary";
            labInfLibrary.Size = new Size(359, 37);
            labInfLibrary.TabIndex = 1;
            labInfLibrary.Text = "Информация о библиотеке";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(720, 422);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LibrarianMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "LibrarianMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Панель библиотекаря";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnLogout;
        private Button btnAccounting;
        private Button btnAddReader;
        private Button btnAddBook;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Label labInfLibrary;
        private PictureBox pictureBox1;
    }
}