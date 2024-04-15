namespace PetManageEnd
{
    partial class UserModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            label3 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxPass = new TextBox();
            label7 = new Label();
            label8 = new Label();
            guna2ComboBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            dateTimePickerDate = new DateTimePicker();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonCancel = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 17);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(757, 87);
            label1.TabIndex = 1;
            label1.Text = "User Registation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 130);
            label2.Name = "label2";
            label2.Size = new Size(200, 76);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(247, 135);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(466, 55);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(247, 178);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(466, 55);
            textBoxAddress.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 173);
            label3.Name = "label3";
            label3.Size = new Size(252, 76);
            label3.TabIndex = 4;
            label3.Text = "Address:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(247, 221);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(466, 55);
            textBoxPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 216);
            label4.Name = "label4";
            label4.Size = new Size(209, 76);
            label4.TabIndex = 6;
            label4.Text = "Phone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(82, 259);
            label5.Name = "label5";
            label5.Size = new Size(158, 76);
            label5.TabIndex = 8;
            label5.Text = "Role:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 302);
            label6.Name = "label6";
            label6.Size = new Size(379, 76);
            label6.TabIndex = 10;
            label6.Text = "Date of birth:";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(247, 353);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(466, 55);
            textBoxPass.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(82, 345);
            label7.Name = "label7";
            label7.Size = new Size(288, 76);
            label7.TabIndex = 12;
            label7.Text = "Password:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 388);
            label8.Name = "label8";
            label8.Size = new Size(135, 76);
            label8.TabIndex = 14;
            label8.Text = "Uid:";
            // 
            // guna2ComboBoxRole
            // 
            guna2ComboBoxRole.BackColor = Color.Transparent;
            guna2ComboBoxRole.CustomizableEdges = customizableEdges3;
            guna2ComboBoxRole.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxRole.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxRole.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxRole.Font = new Font("Segoe UI", 10F);
            guna2ComboBoxRole.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBoxRole.ItemHeight = 20;
            guna2ComboBoxRole.Items.AddRange(new object[] { "Administrator", "Cashier", "Employee" });
            guna2ComboBoxRole.Location = new Point(247, 264);
            guna2ComboBoxRole.Name = "guna2ComboBoxRole";
            guna2ComboBoxRole.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBoxRole.Size = new Size(466, 26);
            guna2ComboBoxRole.TabIndex = 15;
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(247, 310);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(466, 55);
            dateTimePickerDate.TabIndex = 16;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 192, 192);
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.ForeColor = SystemColors.ButtonHighlight;
            buttonSave.Location = new Point(247, 392);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(111, 31);
            buttonSave.TabIndex = 17;
            buttonSave.Text = " Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.FromArgb(255, 192, 128);
            buttonUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(424, 392);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(111, 31);
            buttonUpdate.TabIndex = 18;
            buttonUpdate.Text = " Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += button2_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = SystemColors.ActiveBorder;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = SystemColors.ButtonHighlight;
            buttonCancel.Location = new Point(601, 392);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 31);
            buttonCancel.TabIndex = 19;
            buttonCancel.Text = " Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = Properties.Resources.delete;
            guna2Button1.Location = new Point(757, 17);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(43, 41);
            guna2Button1.TabIndex = 20;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // UserModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Button1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(dateTimePickerDate);
            Controls.Add(guna2ComboBoxRole);
            Controls.Add(label8);
            Controls.Add(textBoxPass);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxPhone);
            Controls.Add(label4);
            Controls.Add(textBoxAddress);
            Controls.Add(label3);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModule";
            StartPosition = FormStartPosition.Manual;
            Text = "UserModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxRole;
        private Label label8;
        private TextBox textBoxPass;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxAddress;
        private Label label3;
        private Button buttonCancel;
        private Button buttonUpdate;
        private Button buttonSave;
        private DateTimePicker dateTimePickerDate;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}