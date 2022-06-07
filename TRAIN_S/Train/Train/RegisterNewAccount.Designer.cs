namespace Train
{
    partial class RegisterNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewAccount));
            this.lblUN = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblpd = new System.Windows.Forms.Label();
            this.lblconfirmPassword = new System.Windows.Forms.Label();
            this.lbldateOfBirth = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.textUN = new System.Windows.Forms.TextBox();
            this.textPD = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.textCP = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.rdbtnmale = new System.Windows.Forms.RadioButton();
            this.rdbtnfemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnreset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUN
            // 
            this.lblUN.AutoSize = true;
            this.lblUN.Enabled = false;
            this.lblUN.Location = new System.Drawing.Point(56, 93);
            this.lblUN.Name = "lblUN";
            this.lblUN.Size = new System.Drawing.Size(89, 20);
            this.lblUN.TabIndex = 1;
            this.lblUN.Text = "User Name";
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(56, 146);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(48, 20);
            this.lblE.TabIndex = 2;
            this.lblE.Text = "Email";
            // 
            // lblpd
            // 
            this.lblpd.AutoSize = true;
            this.lblpd.Location = new System.Drawing.Point(56, 194);
            this.lblpd.Name = "lblpd";
            this.lblpd.Size = new System.Drawing.Size(78, 20);
            this.lblpd.TabIndex = 5;
            this.lblpd.Text = "Password";
            // 
            // lblconfirmPassword
            // 
            this.lblconfirmPassword.AutoSize = true;
            this.lblconfirmPassword.Location = new System.Drawing.Point(12, 245);
            this.lblconfirmPassword.Name = "lblconfirmPassword";
            this.lblconfirmPassword.Size = new System.Drawing.Size(137, 20);
            this.lblconfirmPassword.TabIndex = 4;
            this.lblconfirmPassword.Text = "Confirm Password";
            // 
            // lbldateOfBirth
            // 
            this.lbldateOfBirth.AutoSize = true;
            this.lbldateOfBirth.Location = new System.Drawing.Point(43, 296);
            this.lbldateOfBirth.Name = "lbldateOfBirth";
            this.lbldateOfBirth.Size = new System.Drawing.Size(102, 20);
            this.lbldateOfBirth.TabIndex = 3;
            this.lbldateOfBirth.Text = "Date Of Birth";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(47, 407);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(118, 41);
            this.btnback.TabIndex = 6;
            this.btnback.Text = "Previous";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnconfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconfirm.Location = new System.Drawing.Point(220, 407);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(139, 41);
            this.btnconfirm.TabIndex = 7;
            this.btnconfirm.Text = "Register";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // textUN
            // 
            this.textUN.Location = new System.Drawing.Point(173, 93);
            this.textUN.Name = "textUN";
            this.textUN.Size = new System.Drawing.Size(186, 26);
            this.textUN.TabIndex = 9;
            // 
            // textPD
            // 
            this.textPD.Location = new System.Drawing.Point(173, 194);
            this.textPD.Name = "textPD";
            this.textPD.PasswordChar = '*';
            this.textPD.Size = new System.Drawing.Size(186, 26);
            this.textPD.TabIndex = 11;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(173, 146);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(186, 26);
            this.txtE.TabIndex = 10;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.BackColor = System.Drawing.Color.Chartreuse;
            this.lbltitle.Location = new System.Drawing.Point(76, 29);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(38, 20);
            this.lbltitle.TabIndex = 12;
            this.lbltitle.Text = "Title";
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(173, 239);
            this.textCP.Name = "textCP";
            this.textCP.PasswordChar = '*';
            this.textCP.Size = new System.Drawing.Size(186, 26);
            this.textCP.TabIndex = 13;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(60, 353);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(63, 20);
            this.lblgender.TabIndex = 14;
            this.lblgender.Text = "Gender";
            // 
            // rdbtnmale
            // 
            this.rdbtnmale.AutoSize = true;
            this.rdbtnmale.Location = new System.Drawing.Point(173, 349);
            this.rdbtnmale.Name = "rdbtnmale";
            this.rdbtnmale.Size = new System.Drawing.Size(68, 24);
            this.rdbtnmale.TabIndex = 15;
            this.rdbtnmale.TabStop = true;
            this.rdbtnmale.Text = "Male";
            this.rdbtnmale.UseVisualStyleBackColor = true;
            this.rdbtnmale.CheckedChanged += new System.EventHandler(this.rdbtnmale_CheckedChanged);
            // 
            // rdbtnfemale
            // 
            this.rdbtnfemale.AutoSize = true;
            this.rdbtnfemale.Location = new System.Drawing.Point(272, 351);
            this.rdbtnfemale.Name = "rdbtnfemale";
            this.rdbtnfemale.Size = new System.Drawing.Size(87, 24);
            this.rdbtnfemale.TabIndex = 16;
            this.rdbtnfemale.TabStop = true;
            this.rdbtnfemale.Text = "Female";
            this.rdbtnfemale.UseVisualStyleBackColor = true;
            this.rdbtnfemale.CheckedChanged += new System.EventHandler(this.rdbtnfemale_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 26);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(1953, 1, 1, 13, 24, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnreset.Location = new System.Drawing.Point(407, 407);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(86, 41);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(657, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 38);
            this.label1.TabIndex = 21;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(694, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rdbtnfemale);
            this.Controls.Add(this.rdbtnmale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.textCP);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.textPD);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.textUN);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.lblpd);
            this.Controls.Add(this.lblconfirmPassword);
            this.Controls.Add(this.lbldateOfBirth);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblUN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register for a new account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUN;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblpd;
        private System.Windows.Forms.Label lblconfirmPassword;
        private System.Windows.Forms.Label lbldateOfBirth;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.TextBox textUN;
        private System.Windows.Forms.TextBox textPD;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton rdbtnmale;
        private System.Windows.Forms.RadioButton rdbtnfemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label label1;
    }
}