namespace PetManageEnd
{
    partial class Form2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label2 = new Label();
            User = new Guna.UI2.WinForms.Guna2TextBox();
            Pass = new Guna.UI2.WinForms.Guna2TextBox();
            button1 = new Button();
            button2 = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(12, 248);
            label1.Name = "label1";
            label1.Size = new Size(269, 45);
            label1.TabIndex = 6;
            label1.Text = "Pet Shop System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(58, 177);
            label3.Name = "label3";
            label3.Size = new Size(191, 45);
            label3.TabIndex = 5;
            label3.Text = "Welcom to ";
            label3.Click += label3_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2CirclePictureBox1.Image = Properties.Resources.Loading;
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.InitialImage = Properties.Resources.Loading;
            guna2CirclePictureBox1.Location = new Point(100, 32);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(92, 86);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 4;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(324, 60);
            label2.Name = "label2";
            label2.Size = new Size(308, 45);
            label2.TabIndex = 7;
            label2.Text = "Login your account";
            // 
            // User
            // 
            User.CustomizableEdges = customizableEdges9;
            User.DefaultText = "UserName";
            User.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            User.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            User.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            User.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            User.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            User.Font = new Font("Segoe UI", 9F);
            User.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            User.IconLeft = Properties.Resources.UserIcon;
            User.Location = new Point(324, 175);
            User.Name = "User";
            User.PasswordChar = '\0';
            User.PlaceholderText = "";
            User.SelectedText = "";
            User.ShadowDecoration.CustomizableEdges = customizableEdges10;
            User.Size = new Size(440, 47);
            User.TabIndex = 0;
            User.TextChanged += guna2TextBox1_TextChanged;
            // 
            // Pass
            // 
            Pass.CustomizableEdges = customizableEdges11;
            Pass.DefaultText = "Password";
            Pass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Pass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Pass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Pass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Pass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass.Font = new Font("Segoe UI", 9F);
            Pass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Pass.IconLeft = Properties.Resources.ClockIcon;
            Pass.Location = new Point(324, 248);
            Pass.Name = "Pass";
            Pass.PasswordChar = '\0';
            Pass.PlaceholderText = "";
            Pass.SelectedText = "";
            Pass.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Pass.Size = new Size(440, 47);
            Pass.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gray;
            button1.Location = new Point(324, 335);
            button1.Name = "button1";
            button1.Size = new Size(129, 37);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Gray;
            button2.Location = new Point(518, 335);
            button2.Name = "button2";
            button2.Size = new Size(246, 37);
            button2.TabIndex = 3;
            button2.Text = "Forget Password?";
            button2.UseVisualStyleBackColor = false;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges13;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.delete;
            guna2Button1.Location = new Point(758, 0);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button1.Size = new Size(43, 41);
            guna2Button1.TabIndex = 4;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Pass);
            Controls.Add(User);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox User;
        private Guna.UI2.WinForms.Guna2TextBox Pass;
        internal Button button1;
        private Button button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}