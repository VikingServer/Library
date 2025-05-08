namespace Library
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            panelNav = new Panel();
            btnLogout = new Button();
            btnHelp = new Button();
            btnAddHall = new Button();
            btnBookOperations = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            label1 = new Label();
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
            panelNav.Controls.Add(btnHelp);
            panelNav.Controls.Add(btnAddHall);
            panelNav.Controls.Add(btnBookOperations);
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
            // btnHelp
            // 
            btnHelp.BackColor = Color.Transparent;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(0, 349);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(337, 58);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Сделать справку";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += button3_Click;
            // 
            // btnAddHall
            // 
            btnAddHall.BackColor = Color.Transparent;
            btnAddHall.FlatAppearance.BorderSize = 0;
            btnAddHall.FlatStyle = FlatStyle.Flat;
            btnAddHall.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddHall.ForeColor = Color.White;
            btnAddHall.Location = new Point(0, 271);
            btnAddHall.Name = "btnAddHall";
            btnAddHall.Size = new Size(340, 52);
            btnAddHall.TabIndex = 2;
            btnAddHall.Text = "Добавить зал";
            btnAddHall.TextAlign = ContentAlignment.MiddleLeft;
            btnAddHall.UseVisualStyleBackColor = false;
            btnAddHall.Click += button1_Click;
            // 
            // btnBookOperations
            // 
            btnBookOperations.BackColor = Color.Transparent;
            btnBookOperations.FlatAppearance.BorderSize = 0;
            btnBookOperations.FlatStyle = FlatStyle.Flat;
            btnBookOperations.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBookOperations.ForeColor = Color.White;
            btnBookOperations.Location = new Point(0, 188);
            btnBookOperations.Name = "btnBookOperations";
            btnBookOperations.Size = new Size(340, 52);
            btnBookOperations.TabIndex = 1;
            btnBookOperations.Text = "Операции с книгами";
            btnBookOperations.TextAlign = ContentAlignment.MiddleLeft;
            btnBookOperations.UseVisualStyleBackColor = false;
            btnBookOperations.Click += button2_Click;
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
            labelNavTitle.Text = "Меню \r\nадминистратора";
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
            labelTitle.Size = new Size(536, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Администратор библиотеки";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(340, 84);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(22, 21, 22, 21);
            panelContent.Size = new Size(1888, 1050);
            panelContent.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 488);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 1;
            label1.Text = "label1";
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
            // Form10
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "Form10";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Панель администратора";
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
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelContent;
        private PictureBox pictureBox1;
        private Label labelNavTitle;
        private Button btnBookOperations;
        private Button btnAddHall;
        private Button btnHelp;
        private Button btnLogout;
        private Label label1;
    }
}