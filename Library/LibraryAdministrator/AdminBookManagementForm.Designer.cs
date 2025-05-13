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
            btnMakeCertificate = new Button();
            btnLogout = new Button();
            btnAddHall = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            button1 = new Button();
            labelTitle = new Label();
            panelContent = new Panel();
            panelForm = new Panel();
            btnUpdateTable = new Button();
            btnWriteOff = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panelData = new Panel();
            dataGridView1 = new DataGridView();
            NameBook = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            PublishingHouse = new DataGridViewTextBoxColumn();
            YearPublication = new DataGridViewTextBoxColumn();
            ReadingRoom = new DataGridViewTextBoxColumn();
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
            panelNav.Controls.Add(btnAddHall);
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
            btnAddHall.Click += button2_Click;
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
            panelHeader.Controls.Add(button1);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(340, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1888, 84);
            panelHeader.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(52, 152, 219);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1528, 32);
            button1.Name = "button1";
            button1.Size = new Size(338, 52);
            button1.TabIndex = 27;
            button1.Text = "Загрузить таблицу книг";
            button1.UseVisualStyleBackColor = false;
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
            panelForm.Controls.Add(btnEdit);
            panelForm.Controls.Add(btnAdd);
            panelForm.Controls.Add(textBox5);
            panelForm.Controls.Add(textBox4);
            panelForm.Controls.Add(textBox3);
            panelForm.Controls.Add(textBox2);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(label3);
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
            // btnEdit
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
            // btnAdd
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
            btnAdd.Text = "Добавить книгу";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(225, 313);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(1066, 43);
            textBox5.TabIndex = 23;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(225, 240);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(1066, 43);
            textBox4.TabIndex = 22;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(225, 167);
            textBox3.Margin = new Padding(5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(1066, 43);
            textBox3.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(225, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1066, 43);
            textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(225, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1066, 43);
            textBox1.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 319);
            label6.Name = "label6";
            label6.Size = new Size(202, 37);
            label6.TabIndex = 18;
            label6.Text = "Читальный зал";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 246);
            label5.Name = "label5";
            label5.Size = new Size(171, 37);
            label5.TabIndex = 17;
            label5.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 173);
            label4.Name = "label4";
            label4.Size = new Size(184, 37);
            label4.TabIndex = 16;
            label4.Text = "Издательство";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 100);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 15;
            label3.Text = "Автор";
            // 
            // label2
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
            // BookManagementLibraryAdministratorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "Form2";
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
        private Button btnEdit;
        private Button btnAdd;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button btnMakeCertificate;
        private Button btnMenu;
    }
}