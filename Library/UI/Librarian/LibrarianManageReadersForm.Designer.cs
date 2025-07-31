namespace Library
{
    partial class LibrarianManageReadersForm
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
            btnBookOperations = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnSearchReader = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdateTable = new Button();
            textBoxAddress = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBoxIssuedBy = new TextBox();
            label8 = new Label();
            textBoxDocumentNumber = new TextBox();
            label7 = new Label();
            textBoxDocumentSeries = new TextBox();
            label6 = new Label();
            textBoxPhone = new TextBox();
            label5 = new Label();
            textBoxPatronymic = new TextBox();
            label4 = new Label();
            textBoxFirstName = new TextBox();
            label3 = new Label();
            textBoxLastName = new TextBox();
            label2 = new Label();
            panelData = new Panel();
            dataGridViewReaders = new DataGridView();
            LastName = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            Patronymic = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            DocumentSeries = new DataGridViewTextBoxColumn();
            DocumentNumber = new DataGridViewTextBoxColumn();
            IssuedBy = new DataGridViewTextBoxColumn();
            IssueDate = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelForm.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).BeginInit();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(41, 128, 185);
            panelNav.Controls.Add(btnMenu);
            panelNav.Controls.Add(btnMakeCertificate);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnBookOperations);
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
            btnBookOperations.Click += btnBookOperations_Click;
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
            labelNavTitle.Text = "Добавление читателя";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(btnSearchReader);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(356, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1872, 84);
            panelHeader.TabIndex = 1;
            // 
            // btnSearchReader
            // 
            btnSearchReader.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearchReader.BackColor = Color.FromArgb(52, 152, 219);
            btnSearchReader.FlatAppearance.BorderSize = 0;
            btnSearchReader.FlatStyle = FlatStyle.Flat;
            btnSearchReader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchReader.ForeColor = Color.White;
            btnSearchReader.Location = new Point(1675, 32);
            btnSearchReader.Name = "btnSearchReader";
            btnSearchReader.Size = new Size(175, 52);
            btnSearchReader.TabIndex = 27;
            btnSearchReader.Text = "Поиск";
            btnSearchReader.UseVisualStyleBackColor = false;
            btnSearchReader.Click += btnSearchReader_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(688, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Управление читателями библиотеки";
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
            panelForm.Controls.Add(btnAdd);
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnUpdateTable);
            panelForm.Controls.Add(textBoxAddress);
            panelForm.Controls.Add(label10);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(textBoxIssuedBy);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(textBoxDocumentNumber);
            panelForm.Controls.Add(label7);
            panelForm.Controls.Add(textBoxDocumentSeries);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(textBoxPhone);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(textBoxPatronymic);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(textBoxFirstName);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(textBoxLastName);
            panelForm.Controls.Add(label2);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 525);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(22, 21, 22, 21);
            panelForm.Size = new Size(1872, 525);
            panelForm.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(331, 385);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 43);
            dateTimePicker1.TabIndex = 44;
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
            btnAdd.Text = "Добавить читателя";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1501, 222);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(338, 52);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.Location = new Point(331, 456);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(1051, 43);
            textBoxAddress.TabIndex = 43;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(67, 462);
            label10.Name = "label10";
            label10.Size = new Size(255, 37);
            label10.TabIndex = 42;
            label10.Text = "Адрес регистрации";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(67, 391);
            label9.Name = "label9";
            label9.Size = new Size(175, 37);
            label9.TabIndex = 40;
            label9.Text = "Дата выдачи";
            // 
            // textBoxIssuedBy
            // 
            textBoxIssuedBy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxIssuedBy.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIssuedBy.Location = new Point(331, 312);
            textBoxIssuedBy.Name = "textBoxIssuedBy";
            textBoxIssuedBy.Size = new Size(1051, 43);
            textBoxIssuedBy.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(67, 318);
            label8.Name = "label8";
            label8.Size = new Size(151, 37);
            label8.TabIndex = 38;
            label8.Text = "Кем выдан";
            // 
            // textBoxDocumentNumber
            // 
            textBoxDocumentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDocumentNumber.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDocumentNumber.Location = new Point(1276, 231);
            textBoxDocumentNumber.Name = "textBoxDocumentNumber";
            textBoxDocumentNumber.Size = new Size(106, 43);
            textBoxDocumentNumber.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1044, 237);
            label7.Name = "label7";
            label7.Size = new Size(101, 37);
            label7.TabIndex = 36;
            label7.Text = "Номер";
            // 
            // textBoxDocumentSeries
            // 
            textBoxDocumentSeries.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDocumentSeries.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDocumentSeries.Location = new Point(331, 239);
            textBoxDocumentSeries.Name = "textBoxDocumentSeries";
            textBoxDocumentSeries.Size = new Size(276, 43);
            textBoxDocumentSeries.TabIndex = 35;
            // 
            // labelReadingRoom
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(67, 245);
            label6.Name = "label6";
            label6.Size = new Size(94, 37);
            label6.TabIndex = 34;
            label6.Text = "Серия";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhone.Location = new Point(1276, 20);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(106, 43);
            textBoxPhone.TabIndex = 32;
            // 
            // labelYearPublication
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1044, 23);
            label5.Name = "label5";
            label5.Size = new Size(226, 37);
            label5.TabIndex = 33;
            label5.Text = "Номер телефона";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPatronymic.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatronymic.Location = new Point(331, 166);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(276, 43);
            textBoxPatronymic.TabIndex = 31;
            // 
            // labelPublishingHouse
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(67, 172);
            label4.Name = "label4";
            label4.Size = new Size(130, 37);
            label4.TabIndex = 30;
            label4.Text = "Отчество";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFirstName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(331, 93);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(276, 43);
            textBoxFirstName.TabIndex = 29;
            // 
            // labelYearPublication
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(67, 99);
            label3.Name = "label3";
            label3.Size = new Size(70, 37);
            label3.TabIndex = 28;
            label3.Text = "Имя";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(331, 20);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(276, 43);
            textBoxLastName.TabIndex = 27;
            // 
            // labelNameBook
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 30);
            label2.Name = "label2";
            label2.Size = new Size(130, 37);
            label2.TabIndex = 22;
            label2.Text = "Фамилия";
            // 
            // panelData
            // 
            panelData.Controls.Add(dataGridViewReaders);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Padding = new Padding(22, 21, 22, 21);
            panelData.Size = new Size(1872, 525);
            panelData.TabIndex = 1;
            // 
            // dataGridViewReaders
            // 
            dataGridViewReaders.BackgroundColor = Color.White;
            dataGridViewReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReaders.Columns.AddRange(new DataGridViewColumn[] { LastName, FirstName, Patronymic, Phone, DocumentSeries, DocumentNumber, IssuedBy, IssueDate, Address });
            dataGridViewReaders.Dock = DockStyle.Fill;
            dataGridViewReaders.Location = new Point(22, 21);
            dataGridViewReaders.Name = "dataGridViewReaders";
            dataGridViewReaders.RowHeadersWidth = 51;
            dataGridViewReaders.RowTemplate.Height = 29;
            dataGridViewReaders.Size = new Size(1828, 483);
            dataGridViewReaders.TabIndex = 0;
            dataGridViewReaders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // LastName
            // 
            LastName.HeaderText = "Фамилия";
            LastName.MinimumWidth = 150;
            LastName.Name = "LastName";
            LastName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "Имя";
            FirstName.MinimumWidth = 150;
            FirstName.Name = "FirstName";
            FirstName.Width = 150;
            // 
            // Patronymic
            // 
            Patronymic.HeaderText = "Отчество";
            Patronymic.MinimumWidth = 150;
            Patronymic.Name = "Patronymic";
            Patronymic.Width = 150;
            // 
            // Phone
            // 
            Phone.HeaderText = "Номер телефона";
            Phone.MinimumWidth = 150;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // DocumentSeries
            // 
            DocumentSeries.HeaderText = "Серия";
            DocumentSeries.MinimumWidth = 100;
            DocumentSeries.Name = "DocumentSeries";
            // 
            // DocumentNumber
            // 
            DocumentNumber.HeaderText = "Номер";
            DocumentNumber.MinimumWidth = 100;
            DocumentNumber.Name = "DocumentNumber";
            // 
            // IssuedBy
            // 
            IssuedBy.HeaderText = "Кем выдан";
            IssuedBy.MinimumWidth = 200;
            IssuedBy.Name = "IssuedBy";
            IssuedBy.Width = 200;
            // 
            // IssueDate
            // 
            IssueDate.HeaderText = "Дата выдачи";
            IssueDate.MinimumWidth = 120;
            IssueDate.Name = "IssueDate";
            IssueDate.Width = 120;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес регистрации";
            Address.MinimumWidth = 250;
            Address.Name = "Address";
            Address.Width = 250;
            // 
            // LibrarianManageReadersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "LibrarianManageReadersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Управление читателями";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReaders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNav;
        private Button btnMenu;
        private Button btnMakeCertificate;
        private Button btnLogout;
        private Button btnBookOperations;
        private Label labelNavTitle;
        private Panel panelHeader;
        private Button btnSearchReader;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelForm;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdateTable;
        private TextBox textBoxAddress;
        private Label label10;
        private Label label9;
        private TextBox textBoxIssuedBy;
        private Label label8;
        private TextBox textBoxDocumentNumber;
        private Label label7;
        private TextBox textBoxDocumentSeries;
        private Label label6;
        private TextBox textBoxPhone;
        private Label label5;
        private TextBox textBoxPatronymic;
        private Label label4;
        private TextBox textBoxFirstName;
        private Label label3;
        private TextBox textBoxLastName;
        private Label label2;
        private Panel panelData;
        private DataGridView dataGridViewReaders;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn Patronymic;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn DocumentSeries;
        private DataGridViewTextBoxColumn DocumentNumber;
        private DataGridViewTextBoxColumn IssuedBy;
        private DataGridViewTextBoxColumn IssueDate;
        private DataGridViewTextBoxColumn Address;
        private DateTimePicker dateTimePicker1;
    }
}