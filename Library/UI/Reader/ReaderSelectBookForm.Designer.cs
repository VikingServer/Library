namespace Library
{
    partial class ReaderSelectBookForm
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
            btnMyBooks = new Button();
            btnMenu = new Button();
            btnLogout = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnLoadTable = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnSelectBook = new Button();
            labelReturnDate = new Label();
            checkBoxIssued = new CheckBox();
            textBoxReadingRoom = new TextBox();
            labelReadingRoom = new Label();
            textBoxYear = new TextBox();
            labelYear = new Label();
            textBoxPublisher = new TextBox();
            labelPublisher = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            textBoxTitle = new TextBox();
            labelTitleBook = new Label();
            panelData = new Panel();
            dataGridViewBooks = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            Giving = new DataGridViewTextBoxColumn();
            DateFinish = new DataGridViewTextBoxColumn();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelForm.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnMyBooks);
            panelNav.Controls.Add(btnMenu);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(356, 856);
            panelNav.TabIndex = 0;
            // 
            // btnMyBooks
            // 
            btnMyBooks.BackColor = Color.Transparent;
            btnMyBooks.FlatAppearance.BorderSize = 0;
            btnMyBooks.FlatStyle = FlatStyle.Flat;
            btnMyBooks.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMyBooks.ForeColor = Color.White;
            btnMyBooks.Location = new Point(0, 224);
            btnMyBooks.Name = "btnMyBooks";
            btnMyBooks.Size = new Size(356, 55);
            btnMyBooks.TabIndex = 8;
            btnMyBooks.Text = "Мои книги";
            btnMyBooks.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBooks.UseVisualStyleBackColor = false;
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
            btnMenu.Size = new Size(356, 55);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Меню";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 787);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(356, 69);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // labelNavTitle
            // 
            labelNavTitle.Dock = DockStyle.Top;
            labelNavTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNavTitle.ForeColor = Color.White;
            labelNavTitle.Location = new Point(0, 0);
            labelNavTitle.Name = "labelNavTitle";
            labelNavTitle.Padding = new Padding(12, 22, 0, 22);
            labelNavTitle.Size = new Size(356, 105);
            labelNavTitle.TabIndex = 0;
            labelNavTitle.Text = "Выбор книги";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnLoadTable);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(356, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1506, 88);
            panelHeader.TabIndex = 1;
            // 
            // btnSearchBook
            // 
            btnLoadTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadTable.BackColor = Color.FromArgb(52, 152, 219);
            btnLoadTable.FlatAppearance.BorderSize = 0;
            btnLoadTable.FlatStyle = FlatStyle.Flat;
            btnLoadTable.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadTable.ForeColor = Color.White;
            btnLoadTable.Location = new Point(1143, 36);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(338, 52);
            btnLoadTable.TabIndex = 28;
            btnLoadTable.Text = "Загрузить таблицу книг";
            btnLoadTable.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(25, 22);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(260, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Выбор книги";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(panelForm);
            panelContent.Controls.Add(panelData);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(356, 88);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1506, 768);
            panelContent.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(dateTimePicker1);
            panelForm.Controls.Add(btnSelectBook);
            panelForm.Controls.Add(labelReturnDate);
            panelForm.Controls.Add(checkBoxIssued);
            panelForm.Controls.Add(textBoxReadingRoom);
            panelForm.Controls.Add(labelReadingRoom);
            panelForm.Controls.Add(textBoxYear);
            panelForm.Controls.Add(labelYear);
            panelForm.Controls.Add(textBoxPublisher);
            panelForm.Controls.Add(labelPublisher);
            panelForm.Controls.Add(textBoxAuthor);
            panelForm.Controls.Add(labelAuthor);
            panelForm.Controls.Add(textBoxTitle);
            panelForm.Controls.Add(labelTitleBook);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 315);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(25, 22, 25, 22);
            panelForm.Size = new Size(1506, 453);
            panelForm.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(309, 395);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(281, 43);
            dateTimePicker1.TabIndex = 42;
            // 
            // btnSelectBook
            // 
            btnSelectBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectBook.BackColor = Color.FromArgb(52, 152, 219);
            btnSelectBook.FlatAppearance.BorderSize = 0;
            btnSelectBook.FlatStyle = FlatStyle.Flat;
            btnSelectBook.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectBook.ForeColor = Color.White;
            btnSelectBook.Location = new Point(1143, 14);
            btnSelectBook.Name = "btnSelectBook";
            btnSelectBook.Size = new Size(338, 55);
            btnSelectBook.TabIndex = 41;
            btnSelectBook.Text = "Выбрать книгу";
            btnSelectBook.UseVisualStyleBackColor = false;
            // 
            // labelReturnDate
            // 
            labelReturnDate.AutoSize = true;
            labelReturnDate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelReturnDate.Location = new Point(75, 401);
            labelReturnDate.Name = "labelReturnDate";
            labelReturnDate.Size = new Size(193, 37);
            labelReturnDate.TabIndex = 39;
            labelReturnDate.Text = "Дата возврата";
            // 
            // checkBoxIssued
            // 
            checkBoxIssued.AutoSize = true;
            checkBoxIssued.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIssued.Location = new Point(1035, 14);
            checkBoxIssued.Name = "checkBoxIssued";
            checkBoxIssued.Size = new Size(115, 41);
            checkBoxIssued.TabIndex = 38;
            checkBoxIssued.Text = "Выдан";
            checkBoxIssued.UseVisualStyleBackColor = true;
            // 
            // textBoxReadingRoom
            // 
            textBoxReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingRoom.Location = new Point(309, 318);
            textBoxReadingRoom.Name = "textBoxReadingRoom";
            textBoxReadingRoom.Size = new Size(641, 43);
            textBoxReadingRoom.TabIndex = 30;
            // 
            // labelReadingRoom
            // 
            labelReadingRoom.AutoSize = true;
            labelReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelReadingRoom.Location = new Point(75, 324);
            labelReadingRoom.Name = "labelReadingRoom";
            labelReadingRoom.Size = new Size(202, 37);
            labelReadingRoom.TabIndex = 37;
            labelReadingRoom.Text = "Читальный зал";
            // 
            // textBoxYear
            // 
            textBoxYear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYear.Location = new Point(309, 242);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(641, 43);
            textBoxYear.TabIndex = 29;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelYear.Location = new Point(75, 248);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(171, 37);
            labelYear.TabIndex = 36;
            labelYear.Text = "Год издания";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPublisher.Location = new Point(309, 165);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(641, 43);
            textBoxPublisher.TabIndex = 28;
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPublisher.Location = new Point(75, 171);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(184, 37);
            labelPublisher.TabIndex = 35;
            labelPublisher.Text = "Издательство";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAuthor.Location = new Point(309, 94);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(641, 43);
            textBoxAuthor.TabIndex = 27;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(75, 94);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(91, 37);
            labelAuthor.TabIndex = 22;
            labelAuthor.Text = "Автор";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(309, 18);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(641, 43);
            textBoxTitle.TabIndex = 26;
            // 
            // labelTitleBook
            // 
            labelTitleBook.AutoSize = true;
            labelTitleBook.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleBook.Location = new Point(75, 18);
            labelTitleBook.Name = "labelTitleBook";
            labelTitleBook.Size = new Size(136, 37);
            labelTitleBook.TabIndex = 21;
            labelTitleBook.Text = "Название";
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridViewBooks);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(25, 22, 25, 22);
            panelData.Size = new Size(1506, 315);
            panelData.TabIndex = 0;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, PublishingHouse, YearPublication, ReadingRoom, Giving, DateFinish });
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(25, 22);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.Size = new Size(1456, 271);
            dataGridViewBooks.TabIndex = 0;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 150;
            NameBook.Name = "NameBook";
            NameBook.Width = 150;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 120;
            Author.Name = "Author";
            Author.Width = 120;
            // 
            // PublishingHouse
            // 
            PublishingHouse.HeaderText = "Издательство";
            PublishingHouse.MinimumWidth = 120;
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Width = 120;
            // 
            // YearPublication
            // 
            YearPublication.HeaderText = "Год издания";
            YearPublication.MinimumWidth = 100;
            YearPublication.Name = "YearPublication";
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 120;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Width = 120;
            // 
            // Giving
            // 
            Giving.HeaderText = "Выдан";
            Giving.MinimumWidth = 80;
            Giving.Name = "Giving";
            Giving.Width = 80;
            // 
            // DateFinish
            // 
            DateFinish.HeaderText = "Дата возврата";
            DateFinish.MinimumWidth = 120;
            DateFinish.Name = "DateFinish";
            DateFinish.Width = 120;
            // 
            // ReaderSelectBookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1862, 856);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "ReaderSelectBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Выбор книги";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnMyBooks;
        private Button btnMenu;
        private Button btnLogout;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelForm;
        private Panel panelData;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn ReadingRoom;
        private DataGridViewTextBoxColumn Giving;
        private DataGridViewTextBoxColumn DateFinish;
        private TextBox textBoxTitle;
        private Label labelTitleBook;
        private TextBox textBoxAuthor;
        private Label labelAuthor;
        private TextBox textBoxPublisher;
        private Label labelPublisher;
        private TextBox textBoxYear;
        private Label labelYear;
        private TextBox textBoxReadingRoom;
        private Label labelReadingRoom;
        private CheckBox checkBoxIssued;
        private Label labelReturnDate;
        private Button btnSelectBook;
        private DateTimePicker dateTimePicker1;
        private Button btnLoadTable;
    }
}