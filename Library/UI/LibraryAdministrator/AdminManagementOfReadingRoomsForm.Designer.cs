namespace Library
{
    partial class AdminManagementOfReadingRoomsForm
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
            btnMakeCertificate = new Button();
            btnLogout = new Button();
            btnBookOperations = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            btnLoadTable = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            btnUpdateTable = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            panelData = new Panel();
            dataGridView1 = new DataGridView();
            NameReadingRoom = new DataGridViewTextBoxColumn();
            btnMenu = new Button();
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
            panelNav.Controls.Add(btnBookOperations);
            panelNav.Controls.Add(labelNavTitle);
            panelNav.Dock = DockStyle.Left;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(340, 1134);
            panelNav.TabIndex = 0;
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
            labelNavTitle.Size = new Size(340, 136);
            labelNavTitle.TabIndex = 0;
            labelNavTitle.Text = "Добавление читального зала";
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
            btnLoadTable.Location = new Point(1528, 32);
            btnLoadTable.Name = "btnLoadTable";
            btnLoadTable.Size = new Size(338, 52);
            btnLoadTable.TabIndex = 27;
            btnLoadTable.Text = "Загрузить таблицу залов";
            btnLoadTable.UseVisualStyleBackColor = false;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(41, 128, 185);
            labelTitle.Location = new Point(22, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(621, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Управление читальными залами";
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
            panelForm.Controls.Add(btnDelete);
            panelForm.Controls.Add(btnEdit);
            panelForm.Controls.Add(btnAdd);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(label2);
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
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1517, 304);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(338, 52);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEditBook
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.BackColor = Color.FromArgb(52, 152, 219);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(1517, 222);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(338, 52);
            btnEdit.TabIndex = 24;
            btnEdit.Text = "Изменить данные";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.FromArgb(52, 152, 219);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(1517, 140);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(338, 52);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Добавить зал";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbNameBook
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(225, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1066, 43);
            textBox1.TabIndex = 19;
            // 
            // labelNameBook
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 27);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 14;
            label2.Text = "Название";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameReadingRoom });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(22, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1844, 483);
            dataGridView1.TabIndex = 0;
            // 
            // NameReadingRoom
            // 
            NameReadingRoom.HeaderText = "Название читального зала";
            NameReadingRoom.MinimumWidth = 500;
            NameReadingRoom.Name = "NameReadingRoom";
            NameReadingRoom.Width = 500;
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
            // ManagementOfReadingRooms
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Управление читальными залами";
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
        private Label labelNavTitle;
        private Panel panelHeader;
        private Button btnLoadTable;
        private Label labelTitle;
        private Panel panelContent;
        private Panel panelData;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NameReadingRoom;
        private Panel panelForm;
        private Button btnUpdateTable;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TextBox textBox1;
        private Label label2;
        private Button btnMakeCertificate;
        private Button btnMenu;
    }
}