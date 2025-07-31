namespace Library
{
    partial class Synopsis
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
            btnAddHall = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnLoadTable = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            btnPrint = new Button();
            btnUpdateTable = new Button();
            textBoxFilePath = new TextBox();
            labelFilePath = new Label();
            textBoxReadingRoom = new TextBox();
            labelReadingRoom = new Label();
            textBoxAuthor = new TextBox();
            labelAuthor = new Label();
            panelData = new Panel();
            dataGridView1 = new DataGridView();
            Author = new DataGridViewTextBoxColumn();
            Count = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            btnSaveFile = new Button();
            btnSetFile = new Button();
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
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnBookOperations);
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
            btnMenu.TabIndex = 9;
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
            btnLogout.Size = new Size(340, 69);
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
            // btnAddHall
            // 
            btnAddHall.BackColor = Color.Transparent;
            btnAddHall.FlatAppearance.BorderSize = 0;
            btnAddHall.FlatStyle = FlatStyle.Flat;
            btnAddHall.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddHall.ForeColor = Color.White;
            btnAddHall.Location = new Point(0, 224);
            btnAddHall.Name = "btnAddHall";
            btnAddHall.Size = new Size(340, 52);
            btnAddHall.TabIndex = 3;
            btnAddHall.Text = "Добавить зал";
            btnAddHall.TextAlign = ContentAlignment.MiddleLeft;
            btnAddHall.UseVisualStyleBackColor = false;
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
            labelNavTitle.Text = "Справка";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnLoadTable);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(340, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1888, 84);
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
            btnLoadTable.Location = new Point(1528, 19);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(338, 52);
            btnLoadTable.TabIndex = 28;
            btnLoadTable.Text = "Загрузить таблицу";
            btnLoadTable.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(173, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Справка";
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
            panelForm.Controls.Add(btnSetFile);
            panelForm.Controls.Add(btnSaveFile);
            panelForm.Controls.Add(btnPrint);
            panelForm.Controls.Add(btnUpdateTable);
            panelForm.Controls.Add(textBoxFilePath);
            panelForm.Controls.Add(labelFilePath);
            panelForm.Controls.Add(textBoxReadingRoom);
            panelForm.Controls.Add(labelReadingRoom);
            panelForm.Controls.Add(textBoxAuthor);
            panelForm.Controls.Add(labelAuthor);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 525);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(22, 21, 22, 21);
            panelForm.Size = new Size(1888, 525);
            panelForm.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrint.BackColor = Color.FromArgb(52, 152, 219);
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(1517, 104);
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
            btnUpdateTable.Location = new Point(1517, 21);
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
            textBoxFilePath.Location = new Point(225, 167);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(887, 43);
            textBoxFilePath.TabIndex = 26;
            // 
            // labelFilePath
            // 
            labelFilePath.AutoSize = true;
            labelFilePath.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFilePath.Location = new Point(22, 170);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(177, 37);
            labelFilePath.TabIndex = 25;
            labelFilePath.Text = "Путь к файлу";
            // 
            // textBoxReadingRoom
            // 
            textBoxReadingRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReadingRoom.Location = new Point(225, 94);
            textBoxReadingRoom.Name = "textBoxReadingRoom";
            textBoxReadingRoom.Size = new Size(1066, 43);
            textBoxReadingRoom.TabIndex = 24;
            // 
            // labelReadingRoom
            // 
            labelReadingRoom.AutoSize = true;
            labelReadingRoom.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelReadingRoom.Location = new Point(22, 97);
            labelReadingRoom.Name = "labelReadingRoom";
            labelReadingRoom.Size = new Size(202, 37);
            labelReadingRoom.TabIndex = 23;
            labelReadingRoom.Text = "Читальный зал";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAuthor.Location = new Point(225, 21);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(1066, 43);
            textBoxAuthor.TabIndex = 22;
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(22, 24);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(91, 37);
            labelAuthor.TabIndex = 21;
            labelAuthor.Text = "Автор";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Author, Count, ReadingRoom });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(22, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1844, 483);
            dataGridView1.TabIndex = 0;
            // 
            // Author
            // 
            Author.HeaderText = "Автор";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 300;
            // 
            // Count
            // 
            Count.HeaderText = "Количество книг";
            Count.MinimumWidth = 6;
            Count.Name = "Count";
            Count.Width = 200;
            // 
            // ReadingRoom
            // 
            ReadingRoom.HeaderText = "Читальный зал";
            ReadingRoom.MinimumWidth = 6;
            ReadingRoom.Name = "ReadingRoom";
            ReadingRoom.Width = 300;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveFile.BackColor = Color.FromArgb(52, 152, 219);
            btnSaveFile.FlatAppearance.BorderSize = 0;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveFile.ForeColor = Color.White;
            btnSaveFile.Location = new Point(1110, 216);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(181, 43);
            btnSaveFile.TabIndex = 28;
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // btnSetFile
            // 
            btnSetFile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSetFile.BackColor = Color.FromArgb(52, 152, 219);
            btnSetFile.FlatAppearance.BorderSize = 0;
            btnSetFile.FlatStyle = FlatStyle.Flat;
            btnSetFile.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSetFile.ForeColor = Color.White;
            btnSetFile.Location = new Point(1110, 167);
            btnSetFile.Name = "btnSetFile";
            btnSetFile.Size = new Size(181, 43);
            btnSetFile.TabIndex = 29;
            btnSetFile.Text = "Выбрать";
            btnSetFile.UseVisualStyleBackColor = false;
            // 
            // Synopsis
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Справка";
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
        private Button btnBookOperations;
        private Button btnAddHall;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelData;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn ReadingRoom;
        private Panel panelForm;
        private TextBox textBoxAuthor;
        private Label labelAuthor;
        private TextBox textBoxReadingRoom;
        private Label labelReadingRoom;
        private TextBox textBoxFilePath;
        private Label labelFilePath;
        private Button btnUpdateTable;
        private Button btnPrint;
        private Button btnMenu;
        private Button btnLoadTable;
        private SaveFileDialog saveFileDialog1;
        private Button btnSaveFile;
        private Button btnSetFile;
    }
}