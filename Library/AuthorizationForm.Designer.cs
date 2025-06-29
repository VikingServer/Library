namespace Library
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panelFormContainer = new Panel();
            label4 = new Label();
            btnEntry = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxLogin = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelFormContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 1134);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 420);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 331);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 210);
            label1.Name = "label1";
            label1.Size = new Size(240, 51);
            label1.TabIndex = 0;
            label1.Text = "Библиотека";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panelFormContainer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(506, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1722, 1134);
            panel2.TabIndex = 1;
            // 
            // panelFormContainer
            // 
            panelFormContainer.Anchor = AnchorStyles.None;
            panelFormContainer.Controls.Add(label4);
            panelFormContainer.Controls.Add(btnEntry);
            panelFormContainer.Controls.Add(textBoxPassword);
            panelFormContainer.Controls.Add(label3);
            panelFormContainer.Controls.Add(textBoxLogin);
            panelFormContainer.Controls.Add(label2);
            panelFormContainer.Location = new Point(451, 304);
            panelFormContainer.Name = "panelFormContainer";
            panelFormContainer.Size = new Size(821, 525);
            panelFormContainer.TabIndex = 12;
            // 
            // labelPublishingHouse
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(41, 128, 185);
            label4.Location = new Point(241, 0);
            label4.Name = "label4";
            label4.Size = new Size(303, 51);
            label4.TabIndex = 11;
            label4.Text = "Вход в систему";
            // 
            // btnEntry
            // 
            btnEntry.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEntry.BackColor = Color.FromArgb(41, 128, 185);
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntry.ForeColor = Color.White;
            btnEntry.Location = new Point(180, 388);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(461, 78);
            btnEntry.TabIndex = 10;
            btnEntry.Text = "Войти";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += button2_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(180, 304);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(461, 32);
            textBoxPassword.TabIndex = 4;
            // 
            // labelYearPublication
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 252);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(180, 189);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(461, 32);
            textBoxLogin.TabIndex = 2;
            // 
            // labelNameBook
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 136);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            // 
            // AuthorizationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2228, 1134);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AuthorizationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Библиотека - Вход в систему";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelFormContainer.ResumeLayout(false);
            panelFormContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnEntry;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxLogin;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panelFormContainer;
    }
}