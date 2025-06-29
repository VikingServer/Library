namespace Library
{
    partial class LibrarianBookManagmentForm
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
            btnAddReader = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnSearchBook = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            ReturnDateTimePicker = new DateTimePicker();
            IssueDateTimePicker = new DateTimePicker();
            btnUpdateTable = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            textBoxReader = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            checkBoxIssued = new CheckBox();
            textBoxReadingRoom = new TextBox();
            label6 = new Label();
            textBoxYear = new TextBox();
            label5 = new Label();
            textBoxPublisher = new TextBox();
            label4 = new Label();
            textBoxAuthor = new TextBox();
            label3 = new Label();
            textBoxTitle = new TextBox();
            label2 = new Label();
            panelData = new Panel();
            dataGridViewBooks = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            Mark = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            FinishDate = new DataGridViewTextBoxColumn();
            Reader = new DataGridViewTextBoxColumn();
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
            panelNav.Controls.Add(btnMenu);
            panelNav.Controls.Add(btnMakeCertificate);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnAddReader);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(356, 1134);
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
            btnMenu.TabIndex = 8;
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
            btnLogout.Size = new Size(356, 69);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAddReader
            // 
            btnAddReader.BackColor = Color.Transparent;
            btnAddReader.FlatAppearance.BorderSize = 0;
            btnAddReader.FlatStyle = FlatStyle.Flat;
            btnAddReader.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddReader.ForeColor = Color.White;
            btnAddReader.Location = new Point(0, 312);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(340, 52);
            btnAddReader.TabIndex = 2;
            btnAddReader.Text = "Добавить читателя";
            btnAddReader.TextAlign = ContentAlignment.MiddleLeft;
            btnAddReader.UseVisualStyleBackColor = false;
            btnAddReader.Click += btnAddReader_Click;
            // 
            // labelNavTitle
            // 
            labelNavTitle.Dock = DockStyle.Top;
            labelNavTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNavTitle.ForeColor = Color.White;
            labelNavTitle.Location = new Point(0, 0);
            labelNavTitle.Name = "labelNavTitle";
            labelNavTitle.Padding = new Padding(11, 21, 0, 21);
            labelNavTitle.Size = new Size(356, 136);
            labelNavTitle.TabIndex = 0;
            labelNavTitle.Text = "Работа с книгами";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnSearchBook);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(356, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1872, 84);
            panelHeader.TabIndex = 1;
            // 
            // btnSearchBook
            // 
            btnSearchBook.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchBook.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchBook.FlatAppearance.BorderSize = 0;
            btnSearchBook.FlatStyle = FlatStyle.Flat;
            btnSearchBook.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchBook.ForeColor = Color.White;
            btnSearchBook.Location = new Point(1675, 32);
            btnSearchBook.Name = "btnSearchBook";
            btnSearchBook.Size = new Size(175, 52);
            btnSearchBook.TabIndex = 27;
            btnSearchBook.Text = "Поиск";
            btnSearchBook.UseVisualStyleBackColor = false;
            btnSearchBook.Click += btnSearchBook_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(628, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Управление книгами библиотеки";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(panelForm);
            panelContent.Controls.Add(panelData);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(356, 84);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1872, 1050);
            panelContent.TabIndex = 2;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(ReturnDateTimePicker);
            panelForm.Controls.Add(IssueDateTimePicker);
            panelForm.Controls.Add(btnUpdateTable);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnEdit);
            panelForm.Controls.Add(btnAdd);
            panelForm.Controls.Add(textBoxReader);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(checkBoxIssued);
            panelForm.Controls.Add(textBoxReadingRoom);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(textBoxYear);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(textBoxPublisher);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(textBoxAuthor);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(textBoxTitle);
            panelForm.Controls.Add(label2);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 525);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(22, 21, 22, 21);
            panelForm.Size = new Size(1872, 525);
            panelForm.TabIndex = 0;
            // 
            // ReturnDateTimePicker
            // 
            ReturnDateTimePicker.CalendarFont = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDateTimePicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ReturnDateTimePicker.Location = new Point(1365, 166);
            ReturnDateTimePicker.Name = "ReturnDateTimePicker";
            ReturnDateTimePicker.Size = new Size(200, 35);
            ReturnDateTimePicker.TabIndex = 39;
            ReturnDateTimePicker.Value = new DateTime(2025, 5, 8, 22, 19, 29, 0);
            // 
            // IssueDateTimePicker
            // 
            IssueDateTimePicker.CalendarFont = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            IssueDateTimePicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            IssueDateTimePicker.Location = new Point(1365, 94);
            IssueDateTimePicker.Name = "IssueDateTimePicker";
            IssueDateTimePicker.Size = new Size(200, 35);
            IssueDateTimePicker.TabIndex = 38;
            IssueDateTimePicker.Value = new DateTime(2025, 5, 8, 0, 0, 0, 0);
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdateTable.BackColor = Color.FromArgb(52, 152, 219);
            btnUpdateTable.FlatAppearance.BorderSize = 0;
            btnUpdateTable.FlatStyle = FlatStyle.Flat;
            btnUpdateTable.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateTable.ForeColor = Color.White;
            btnUpdateTable.Location = new Point(1501, 21);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(346, 67);
            btnUpdateTable.TabIndex = 26;
            btnUpdateTable.Text = "Обновить таблицу";
            btnUpdateTable.UseVisualStyleBackColor = false;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1501, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(338, 52);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEditBook
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1501, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(338, 52);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Изменить данные";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAddBook
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(52, 152, 219);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1501, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(338, 52);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Добавить книгу";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBoxReader
            // 
            textBoxReader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReader.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReader.Location = new Point(275, 388);
            textBoxReader.Name = "textBoxReader";
            textBoxReader.Size = new Size(322, 43);
            textBoxReader.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(67, 394);
            label9.Name = "label9";
            label9.Size = new Size(129, 37);
            label9.TabIndex = 36;
            label9.Text = "Читатель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1166, 166);
            label8.Name = "label8";
            label8.Size = new Size(193, 37);
            label8.TabIndex = 34;
            label8.Text = "Дата возврата";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1166, 96);
            label7.Name = "label7";
            label7.Size = new Size(175, 37);
            label7.TabIndex = 32;
            label7.Text = "Дата выдачи";
            // 
            // checkBoxIssued
            // 
            checkBoxIssued.AutoSize = true;
            checkBoxIssued.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxIssued.Location = new Point(1166, 17);
            checkBoxIssued.Name = "checkBoxIssued";
            checkBoxIssued.Size = new Size(115, 41);
            checkBoxIssued.TabIndex = 31;
            checkBoxIssued.Text = "Выдан";
            checkBoxIssued.UseVisualStyleBackColor = true;
            checkBoxIssued.CheckedChanged += СheckBoxIssued_CheckedChanged;
            // 
            // textBoxReadingRoom
            // 
            textBoxReadingRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingRoom.Location = new Point(275, 309);
            textBoxReadingRoom.Name = "textBoxReadingRoom";
            textBoxReadingRoom.Size = new Size(322, 43);
            textBoxReadingRoom.TabIndex = 30;
            // 
            // labelReadingRoom
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 315);
            label6.Name = "label6";
            label6.Size = new Size(202, 37);
            label6.TabIndex = 25;
            label6.Text = "Читальный зал";
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxYear.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYear.Location = new Point(275, 236);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(322, 43);
            textBoxYear.TabIndex = 29;
            textBoxYear.KeyPress += TextBoxYear_KeyPress;
            // 
            // labelYearPublication
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(67, 242);
            label5.Name = "label5";
            label5.Size = new Size(171, 37);
            label5.TabIndex = 24;
            label5.Text = "Год издания";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPublisher.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPublisher.Location = new Point(275, 163);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(322, 43);
            textBoxPublisher.TabIndex = 28;
            // 
            // labelPublishingHouse
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 169);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 23;
            label4.Text = "Издательство";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAuthor.Location = new Point(275, 90);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(322, 43);
            textBoxAuthor.TabIndex = 27;
            // 
            // labelYearPublication
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 96);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 22;
            label3.Text = "Автор";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTitle.Location = new Point(275, 17);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(322, 43);
            textBoxTitle.TabIndex = 26;
            // 
            // labelNameBook
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 23);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 21;
            label2.Text = "Название";
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridViewBooks);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(22, 21, 22, 21);
            panelData.Size = new Size(1872, 525);
            panelData.TabIndex = 1;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { NameBook, Author, ReadingRoom, PublishingHouse, YearPublication, Mark, StartDate, FinishDate, Reader });
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(22, 21);
            dataGridViewBooks.MultiSelect = false;
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooks.Size = new Size(1828, 483);
            dataGridViewBooks.TabIndex = 0;
            dataGridViewBooks.SelectionChanged += DataGridViewBooks_SelectionChanged;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 200;
            NameBook.Name = "NameBook";
            NameBook.Width = 200;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 150;
            Author.Name = "Author";
            Author.Width = 150;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 150;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Width = 150;
            // 
            // PublishingHouse
            // 
            PublishingHouse.HeaderText = "Издательство";
            PublishingHouse.MinimumWidth = 150;
            PublishingHouse.Name = "PublishingHouse";
            PublishingHouse.Width = 150;
            // 
            // YearPublication
            // 
            YearPublication.HeaderText = "Год издания";
            YearPublication.MinimumWidth = 120;
            YearPublication.Name = "YearPublication";
            YearPublication.Width = 120;
            // 
            // Mark
            // 
            Mark.HeaderText = "Статус";
            Mark.MinimumWidth = 100;
            Mark.Name = "Mark";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Дата выдачи";
            StartDate.MinimumWidth = 120;
            StartDate.Name = "StartDate";
            StartDate.Width = 120;
            // 
            // FinishDate
            // 
            FinishDate.HeaderText = "Дата возврата";
            FinishDate.MinimumWidth = 120;
            FinishDate.Name = "FinishDate";
            FinishDate.Width = 120;
            // 
            // Reader
            // 
            Reader.HeaderText = "Читатель";
            Reader.MinimumWidth = 200;
            Reader.Name = "Reader";
            Reader.Width = 200;
            // 
            // LibrarianBookManagmentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "LibrarianBookManagmentForm";
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnMenu;
        private Button btnMakeCertificate;
        private Button btnLogout;
        private Button btnAddReader;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Button btnSearchBook;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelForm;
        private Button btnUpdateTable;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox textBoxReader;
        private Label label9;
        private Label label8;
        private Label label7;
        private CheckBox checkBoxIssued;
        private TextBox textBoxReadingRoom;
        private Label label6;
        private TextBox textBoxYear;
        private Label label5;
        private TextBox textBoxPublisher;
        private Label label4;
        private TextBox textBoxAuthor;
        private Label label3;
        private TextBox textBoxTitle;
        private Label label2;
        private Panel panelData;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn ReadingRoom;
        private DataGridViewTextBoxColumn PublishingHouse;
        private DataGridViewTextBoxColumn YearPublication;
        private DataGridViewTextBoxColumn Mark;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn FinishDate;
        private DataGridViewTextBoxColumn Reader;
        private DateTimePicker ReturnDateTimePicker;
        private DateTimePicker IssueDateTimePicker;
    }
}