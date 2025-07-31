namespace Library
{
    partial class LibrarianBookKeeping
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
            btnLogout = new Button();
            btnBookOperations = new Button();
            btnAddReader = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnLoadTable = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            btnSetFile = new Button();
            btnSaveFile = new Button();
            btnPrint = new Button();
            btnUpdateTable = new Button();
            textBoxFilePath = new TextBox();
            labelFilePath = new Label();
            labelDate = new Label();
            panelData = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewReaders = new DataGridView();
            CountOfReader = new DataGridViewTextBoxColumn();
            CountNewReader = new DataGridViewTextBoxColumn();
            dataGridViewBooks = new DataGridView();
            Book = new DataGridViewTextBoxColumn();
            NameBook = new DataGridViewTextBoxColumn();
            CountOfBook = new DataGridViewTextBoxColumn();
            dataGridViewReadersWithoutBooks = new DataGridView();
            Reader = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            dateTimePicker1 = new DateTimePicker();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelForm.SuspendLayout();
            panelData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadersWithoutBooks).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnMenu);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnBookOperations);
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
            // 
            // btnBookOperations
            // 
            btnBookOperations.BackColor = Color.Transparent;
            btnBookOperations.FlatAppearance.BorderSize = 0;
            btnBookOperations.FlatStyle = FlatStyle.Flat;
            btnBookOperations.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBookOperations.ForeColor = Color.White;
            btnBookOperations.Location = new Point(0, 312);
            btnBookOperations.Name = "btnBookOperations";
            btnBookOperations.Size = new Size(340, 52);
            btnBookOperations.TabIndex = 2;
            btnBookOperations.Text = "Операции с книгами";
            btnBookOperations.TextAlign = ContentAlignment.MiddleLeft;
            btnBookOperations.UseVisualStyleBackColor = false;
            // 
            // btnAddReader
            // 
            btnAddReader.BackColor = Color.Transparent;
            btnAddReader.FlatAppearance.BorderSize = 0;
            btnAddReader.FlatStyle = FlatStyle.Flat;
            btnAddReader.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddReader.ForeColor = Color.White;
            btnAddReader.Location = new Point(0, 224);
            btnAddReader.Name = "btnAddReader";
            btnAddReader.Size = new Size(340, 52);
            btnAddReader.TabIndex = 3;
            btnAddReader.Text = "Добавить читателя";
            btnAddReader.TextAlign = ContentAlignment.MiddleLeft;
            btnAddReader.UseVisualStyleBackColor = false;
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
            labelNavTitle.Text = "Учет книг";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnLoadTable);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(356, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1872, 84);
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
            btnLoadTable.Location = new Point(1512, 19);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(338, 52);
            btnLoadTable.TabIndex = 28;
            btnLoadTable.Text = "Загрузить данные";
            btnLoadTable.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(196, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Учет книг";
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
            panelForm.Controls.Add(dateTimePicker1);
            panelForm.Controls.Add(btnSetFile);
            panelForm.Controls.Add(btnSaveFile);
            panelForm.Controls.Add(btnPrint);
            panelForm.Controls.Add(btnUpdateTable);
            panelForm.Controls.Add(textBoxFilePath);
            panelForm.Controls.Add(labelFilePath);
            panelForm.Controls.Add(labelDate);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 525);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(22, 21, 22, 21);
            panelForm.Size = new Size(1872, 525);
            panelForm.TabIndex = 0;
            // 
            // btnSetFile
            // 
            btnSetFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetFile.BackColor = Color.FromArgb(52, 152, 219);
            btnSetFile.FlatAppearance.BorderSize = 0;
            btnSetFile.FlatStyle = FlatStyle.Flat;
            btnSetFile.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetFile.ForeColor = Color.White;
            btnSetFile.Location = new Point(1113, 151);
            btnSetFile.Name = "btnSetFile";
            btnSetFile.Size = new Size(181, 43);
            btnSetFile.TabIndex = 29;
            btnSetFile.Text = "Выбрать";
            btnSetFile.UseVisualStyleBackColor = false;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveFile.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveFile.FlatAppearance.BorderSize = 0;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFile.ForeColor = Color.White;
            btnSaveFile.Location = new Point(1113, 200);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(181, 43);
            btnSaveFile.TabIndex = 28;
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(52, 152, 219);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1501, 104);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(346, 67);
            btnPrint.TabIndex = 27;
            btnPrint.Text = "Печать";
            btnPrint.UseVisualStyleBackColor = false;
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
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFilePath.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFilePath.Location = new Point(228, 151);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(887, 43);
            textBoxFilePath.TabIndex = 26;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilePath.Location = new Point(25, 154);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(177, 37);
            labelFilePath.TabIndex = 25;
            labelFilePath.Text = "Путь к файлу";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(22, 24);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(75, 37);
            labelDate.TabIndex = 23;
            labelDate.Text = "Дата";
            // 
            // panelData
            // 
            panelData.Controls.Add(tableLayoutPanel1);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(22, 21, 22, 21);
            panelData.Size = new Size(1872, 525);
            panelData.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(dataGridViewReaders, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewBooks, 1, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewReadersWithoutBooks, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(22, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1828, 483);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewReaders
            // 
            dataGridViewReaders.BackgroundColor = Color.White;
            dataGridViewReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReaders.Columns.AddRange(new DataGridViewColumn[] { CountOfReader, CountNewReader });
            dataGridViewReaders.Dock = DockStyle.Fill;
            dataGridViewReaders.Location = new Point(3, 3);
            dataGridViewReaders.Name = "dataGridViewReaders";
            dataGridViewReaders.RowHeadersWidth = 51;
            dataGridViewReaders.RowTemplate.Height = 29;
            dataGridViewReaders.Size = new Size(451, 477);
            dataGridViewReaders.TabIndex = 0;
            // 
            // CountOfReader
            // 
            CountOfReader.HeaderText = "Количество читателей";
            CountOfReader.MinimumWidth = 200;
            CountOfReader.Name = "CountOfReader";
            CountOfReader.Width = 200;
            // 
            // CountNewReader
            // 
            CountNewReader.HeaderText = "Количество новых читателей";
            CountNewReader.MinimumWidth = 200;
            CountNewReader.Name = "CountNewReader";
            CountNewReader.Width = 200;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.BackgroundColor = Color.White;
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Columns.AddRange(new DataGridViewColumn[] { Book, NameBook, CountOfBook });
            dataGridViewBooks.Dock = DockStyle.Fill;
            dataGridViewBooks.Location = new Point(460, 3);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.RowHeadersWidth = 51;
            dataGridViewBooks.RowTemplate.Height = 29;
            dataGridViewBooks.Size = new Size(908, 477);
            dataGridViewBooks.TabIndex = 1;
            // 
            // Book
            // 
            Book.HeaderText = "Книга";
            Book.MinimumWidth = 150;
            Book.Name = "Book";
            Book.Width = 150;
            // 
            // NameBook
            // 
            NameBook.HeaderText = "Название";
            NameBook.MinimumWidth = 300;
            NameBook.Name = "NameBook";
            NameBook.Width = 300;
            // 
            // CountOfBook
            // 
            CountOfBook.HeaderText = "Количество выдачи";
            CountOfBook.MinimumWidth = 200;
            CountOfBook.Name = "CountOfBook";
            CountOfBook.Width = 200;
            // 
            // dataGridViewReadersWithoutBooks
            // 
            dataGridViewReadersWithoutBooks.BackgroundColor = Color.White;
            dataGridViewReadersWithoutBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadersWithoutBooks.Columns.AddRange(new DataGridViewColumn[] { Reader });
            dataGridViewReadersWithoutBooks.Dock = DockStyle.Fill;
            dataGridViewReadersWithoutBooks.Location = new Point(1374, 3);
            dataGridViewReadersWithoutBooks.Name = "dataGridViewReadersWithoutBooks";
            dataGridViewReadersWithoutBooks.RowHeadersWidth = 51;
            dataGridViewReadersWithoutBooks.RowTemplate.Height = 29;
            dataGridViewReadersWithoutBooks.Size = new Size(451, 477);
            dataGridViewReadersWithoutBooks.TabIndex = 2;
            // 
            // Reader
            // 
            Reader.HeaderText = "Читатели без книги";
            Reader.MinimumWidth = 300;
            Reader.Name = "Reader";
            Reader.Width = 300;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(225, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(266, 43);
            dateTimePicker1.TabIndex = 30;
            // 
            // LibrarianBookKeeping
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "LibrarianBookKeeping";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Учет книг";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelData.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadersWithoutBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnMenu;
        private Button btnLogout;
        private Button btnBookOperations;
        private Button btnAddReader;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Button btnLoadTable;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelForm;
        private Button btnPrint;
        private Button btnUpdateTable;
        private TextBox textBoxFilePath;
        private Label labelFilePath;
        private Label labelDate;
        private Panel panelData;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewReaders;
        private DataGridViewTextBoxColumn CountOfReader;
        private DataGridViewTextBoxColumn CountNewReader;
        private DataGridView dataGridViewBooks;
        private DataGridViewTextBoxColumn Book;
        private DataGridViewTextBoxColumn NameBook;
        private DataGridViewTextBoxColumn CountOfBook;
        private DataGridView dataGridViewReadersWithoutBooks;
        private DataGridViewTextBoxColumn Reader;
        private SaveFileDialog saveFileDialog1;
        private Button btnSaveFile;
        private Button btnSetFile;
        private OpenFileDialog openFileDialog1;
        private DateTimePicker dateTimePicker1;
    }
}