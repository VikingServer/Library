namespace Library
{
    partial class AdminBookManagementForm
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
            panelNav = new Panel();
            btnMenu = new Button();
            btnMakeCertificate = new Button();
            btnLogout = new Button();
            btnAddHall = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnLoadTableBooks = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            btnUpdateTable = new Button();
            btnWriteOff = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            tbReadingRoom = new TextBox();
            tbYearPublication = new TextBox();
            tbPublishingHouse = new TextBox();
            tbBookAuthor = new TextBox();
            tbNameBook = new TextBox();
            labelReadingRoom = new Label();
            labelBookAuthor = new Label();
            labelPublishingHouse = new Label();
            labelBookAuthor = new Label();
            labelNameBook = new Label();
            panelData = new Panel();
            dataGridView1 = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelForm.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnMenu);
            panelNav.Controls.Add(btnMakeCertificate);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnAddHall);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(340, 1134);
            panelNav.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(0, 136);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(340, 52);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Меню";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnMakeCertificate
            // 
            btnMakeCertificate.BackColor = Color.Transparent;
            btnMakeCertificate.FlatAppearance.BorderSize = 0;
            btnMakeCertificate.FlatStyle = FlatStyle.Flat;
            btnMakeCertificate.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMakeCertificate.ForeColor = Color.White;
            btnMakeCertificate.Location = new Point(0, 224);
            btnMakeCertificate.Name = "btnMakeCertificate";
            btnMakeCertificate.Size = new Size(340, 52);
            btnMakeCertificate.TabIndex = 6;
            btnMakeCertificate.Text = "Сделать справку";
            btnMakeCertificate.TextAlign = ContentAlignment.MiddleLeft;
            btnMakeCertificate.UseVisualStyleBackColor = false;
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
            // btnAddHall
            // 
            btnAddHall.BackColor = Color.Transparent;
            btnAddHall.FlatAppearance.BorderSize = 0;
            btnAddHall.FlatStyle = FlatStyle.Flat;
            btnAddHall.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddHall.ForeColor = Color.White;
            btnAddHall.Location = new Point(0, 312);
            btnAddHall.Name = "btnAddHall";
            btnAddHall.Size = new Size(340, 52);
            btnAddHall.TabIndex = 2;
            btnAddHall.Text = "Добавить зал";
            btnAddHall.TextAlign = ContentAlignment.MiddleLeft;
            btnAddHall.UseVisualStyleBackColor = false;
            btnAddHall.Click += btnAddHall_Click;
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
            labelNavTitle.Text = "Операции с \r\nкнигами";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnLoadTableBooks);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(340, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1888, 84);
            panelHeader.TabIndex = 1;
            // 
            // btnLoadTableBooks
            // 
            btnLoadTableBooks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadTableBooks.BackColor = Color.FromArgb(52, 152, 219);
            btnLoadTableBooks.FlatAppearance.BorderSize = 0;
            btnLoadTableBooks.FlatStyle = FlatStyle.Flat;
            btnLoadTableBooks.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadTableBooks.ForeColor = Color.White;
            btnLoadTableBooks.Location = new Point(1528, 32);
            btnLoadTableBooks.Name = "button1";
            btnLoadTableBooks.Size = new Size(338, 52);
            btnLoadTableBooks.TabIndex = 27;
            btnLoadTableBooks.Text = "Загрузить таблицу книг";
            btnLoadTableBooks.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(402, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Управление книгами";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(panelForm);
            panelContent.Controls.Add(panelData);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(340, 84);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1888, 1050);
            panelContent.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(btnUpdateTable);
            panelForm.Controls.Add(btnWriteOff);
            panelForm.Controls.Add(btnEditBook);
            panelForm.Controls.Add(btnAddBook);
            panelForm.Controls.Add(tbReadingRoom);
            panelForm.Controls.Add(tbYearPublication);
            panelForm.Controls.Add(tbPublishingHouse);
            panelForm.Controls.Add(tbBookAuthor);
            panelForm.Controls.Add(tbNameBook);
            panelForm.Controls.Add(labelReadingRoom);
            panelForm.Controls.Add(labelBookAuthor);
            panelForm.Controls.Add(labelPublishingHouse);
            panelForm.Controls.Add(labelBookAuthor);
            panelForm.Controls.Add(labelNameBook);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 525);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(22, 21, 22, 21);
            panelForm.Size = new Size(1888, 525);
            panelForm.TabIndex = 0;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateTable.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdateTable.FlatAppearance.BorderSize = 0;
            btnUpdateTable.FlatStyle = FlatStyle.Flat;
            btnUpdateTable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateTable.ForeColor = Color.White;
            btnUpdateTable.Location = new Point(1517, 21);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(346, 67);
            btnUpdateTable.TabIndex = 26;
            btnUpdateTable.Text = "Обновить таблицу";
            btnUpdateTable.UseVisualStyleBackColor = false;
            // 
            // btnWriteOff
            // 
            btnWriteOff.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnWriteOff.BackColor = Color.FromArgb(231, 76, 60);
            btnWriteOff.FlatAppearance.BorderSize = 0;
            btnWriteOff.FlatStyle = FlatStyle.Flat;
            btnWriteOff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnWriteOff.ForeColor = Color.White;
            btnWriteOff.Location = new Point(1517, 304);
            btnWriteOff.Name = "btnWriteOff";
            btnWriteOff.Size = new Size(338, 52);
            btnWriteOff.TabIndex = 25;
            btnWriteOff.Text = "Списать книгу";
            btnWriteOff.UseVisualStyleBackColor = false;
            // 
            // btnEditBook
            // 
            btnEditBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditBook.BackColor = Color.FromArgb(52, 152, 219);
            btnEditBook.FlatAppearance.BorderSize = 0;
            btnEditBook.FlatStyle = FlatStyle.Flat;
            btnEditBook.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditBook.ForeColor = Color.White;
            btnEditBook.Location = new Point(1517, 222);
            btnEditBook.Name = "btnEdit";
            btnEditBook.Size = new Size(338, 52);
            btnEditBook.TabIndex = 24;
            btnEditBook.Text = "Изменить данные";
            btnEditBook.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBook.BackColor = Color.FromArgb(52, 152, 219);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(1517, 140);
            btnAddBook.Name = "btnAdd";
            btnAddBook.Size = new Size(338, 52);
            btnAddBook.TabIndex = 9;
            btnAddBook.Text = "Добавить книгу";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // tbReadingRoom
            // 
            tbReadingRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbReadingRoom.Location = new Point(225, 313);
            tbReadingRoom.Name = "textBox5";
            tbReadingRoom.Size = new Size(1066, 43);
            tbReadingRoom.TabIndex = 23;
            // 
            // tbYearPublication
            // 
            tbYearPublication.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbYearPublication.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbYearPublication.Location = new Point(225, 240);
            tbYearPublication.Name = "textBox4";
            tbYearPublication.Size = new Size(1066, 43);
            tbYearPublication.TabIndex = 22;
            // 
            // tbPublishingHouse
            // 
            tbPublishingHouse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPublishingHouse.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbPublishingHouse.Location = new Point(225, 167);
            tbPublishingHouse.Margin = new Padding(5);
            tbPublishingHouse.Name = "textBox3";
            tbPublishingHouse.Size = new Size(1066, 43);
            tbPublishingHouse.TabIndex = 21;
            // 
            // tbBookAuthor
            // 
            tbBookAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbBookAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbBookAuthor.Location = new Point(225, 94);
            tbBookAuthor.Name = "textBox2";
            tbBookAuthor.Size = new Size(1066, 43);
            tbBookAuthor.TabIndex = 20;
            // 
            // tbNameBook
            // 
            tbNameBook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNameBook.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbNameBook.Location = new Point(225, 21);
            tbNameBook.Name = "textBox1";
            tbNameBook.Size = new Size(1066, 43);
            tbNameBook.TabIndex = 19;
            // 
            // labelReadingRoom
            // 
            labelReadingRoom.AutoSize = true;
            labelReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelReadingRoom.Location = new Point(22, 319);
            labelReadingRoom.Name = "label6";
            labelReadingRoom.Size = new Size(202, 37);
            labelReadingRoom.TabIndex = 18;
            labelReadingRoom.Text = "Читальный зал";
            // 
            // labelYearPublication
            // 
            labelBookAuthor.AutoSize = true;
            labelBookAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBookAuthor.Location = new Point(22, 246);
            labelBookAuthor.Name = "label5";
            labelBookAuthor.Size = new Size(171, 37);
            labelBookAuthor.TabIndex = 17;
            labelBookAuthor.Text = "Год издания";
            // 
            // labelPublishingHouse
            // 
            labelPublishingHouse.AutoSize = true;
            labelPublishingHouse.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPublishingHouse.Location = new Point(22, 173);
            labelPublishingHouse.Name = "label4";
            labelPublishingHouse.Size = new Size(184, 37);
            labelPublishingHouse.TabIndex = 16;
            labelPublishingHouse.Text = "Издательство";
            // 
            // labelYearPublication
            // 
            labelBookAuthor.AutoSize = true;
            labelBookAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelBookAuthor.Location = new Point(22, 100);
            labelBookAuthor.Name = "label3";
            labelBookAuthor.Size = new Size(91, 37);
            labelBookAuthor.TabIndex = 15;
            labelBookAuthor.Text = "Автор";
            // 
            // labelNameBook
            // 
            labelNameBook.AutoSize = true;
            labelNameBook.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameBook.Location = new Point(22, 27);
            labelNameBook.Name = "label2";
            labelNameBook.Size = new Size(136, 37);
            labelNameBook.TabIndex = 14;
            labelNameBook.Text = "Название";
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridView1);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(22, 21, 22, 21);
            panelData.Size = new Size(1888, 525);
            panelData.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, PublishingHouse, YearPublication, ReadingRoom });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(22, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1844, 483);
            dataGridView1.TabIndex = 0;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 6;
            NameBook.Name = "NameBook";
            NameBook.Width = 300;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 250;
            // 
            // PublishingHouse
            // 
            PublishingHouse.HeaderText = "Издательство";
            PublishingHouse.MinimumWidth = 6;
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Width = 250;
            // 
            // YearPublication
            // 
            YearPublication.HeaderText = "Год издания";
            YearPublication.MinimumWidth = 6;
            YearPublication.Name = "YearPublication";
            YearPublication.Width = 150;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Width = 200;
            // 
            // AdminBookManagementForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "AdminBookManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Управление книгами";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnLogout;
        private Button btnAddHall;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelData;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn ReadingRoom;
        private Panel panelForm;
        private Button btnUpdateTable;
        private Button btnWriteOff;
        private Button btnEditBook;
        private Button btnAddBook;
        private TextBox tbReadingRoom;
        private TextBox tbYearPublication;
        private TextBox tbPublishingHouse;
        private TextBox tbBookAuthor;
        private TextBox tbNameBook;
        private Label labelReadingRoom;
        private Label labelYearPublication;
        private Label labelPublishingHouse;
        private Label labelBookAuthor;
        private Label labelNameBook;
        private Button btnLoadTableBooks;
        private Button btnMakeCertificate;
        private Button btnMenu;
    }
}