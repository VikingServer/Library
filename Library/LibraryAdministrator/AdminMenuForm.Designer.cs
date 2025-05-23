﻿namespace Library
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            panelNav = new Panel();
            btnLogout = new Button();
            btnHelp = new Button();
            btnAddHall = new Button();
            btnBookOperations = new Button();
            labelNavTitle = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelContent = new Panel();
            dataGridView1 = new DataGridView();
            DayOfWeek = new DataGridViewTextBoxColumn();
            OpeningHours = new DataGridViewTextBoxColumn();
            labWorkingSchedule = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelNav.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btnLogout.Click += btnLogout_Click;
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
            btnHelp.Click += btnHelp_Click;
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
            btnAddHall.Click += btnAddHall_Click;
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
            labelTitle.Size = new Size(536, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Администратор библиотеки";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(dataGridView1);
            panelContent.Controls.Add(labWorkingSchedule);
            panelContent.Controls.Add(label1);
            panelContent.Controls.Add(pictureBox1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(340, 84);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(22, 21, 22, 21);
            panelContent.Size = new Size(1888, 1050);
            panelContent.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DayOfWeek, OpeningHours });
            dataGridView1.Location = new Point(890, 88);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 31;
            dataGridView1.Size = new Size(335, 355);
            dataGridView1.TabIndex = 7;
            // 
            // DayOfWeek
            // 
            DayOfWeek.HeaderText = "День недели";
            DayOfWeek.MinimumWidth = 40;
            DayOfWeek.Name = "DayOfWeek";
            DayOfWeek.ReadOnly = true;
            DayOfWeek.Width = 150;
            // 
            // OpeningHours
            // 
            OpeningHours.HeaderText = "Часы работы";
            OpeningHours.Name = "OpeningHours";
            OpeningHours.ReadOnly = true;
            OpeningHours.Width = 142;
            // 
            // labWorkingSchedule
            // 
            labWorkingSchedule.AutoSize = true;
            labWorkingSchedule.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labWorkingSchedule.Location = new Point(890, 21);
            labWorkingSchedule.Name = "labWorkingSchedule";
            labWorkingSchedule.Size = new Size(207, 37);
            labWorkingSchedule.TabIndex = 6;
            labWorkingSchedule.Text = "График работы";
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
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Controls.Add(panelNav);
            Name = "AdminMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Панель администратора";
            WindowState = FormWindowState.Maximized;
            panelNav.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Label labWorkingSchedule;
        private DataGridViewTextBoxColumn DayOfWeek;
        private DataGridViewTextBoxColumn OpeningHours;
    }
}