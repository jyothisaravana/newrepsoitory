namespace Login
{
    partial class Form1
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
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Faculty = new System.Windows.Forms.RadioButton();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.User_name = new System.Windows.Forms.TextBox();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Box1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.Login);
            this.Box1.Controls.Add(this.Pass_word);
            this.Box1.Controls.Add(this.User_name);
            this.Box1.Controls.Add(this.Password);
            this.Box1.Controls.Add(this.Username);
            this.Box1.Controls.Add(this.Faculty);
            this.Box1.Controls.Add(this.Student);
            this.Box1.Controls.Add(this.Admin);
            this.Box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(170, 69);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(503, 301);
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            this.Box1.Text = "Select_one";
            this.Box1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.Location = new System.Drawing.Point(61, 36);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(72, 24);
            this.Admin.TabIndex = 0;
            this.Admin.TabStop = true;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Student.Location = new System.Drawing.Point(178, 36);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(84, 24);
            this.Student.TabIndex = 1;
            this.Student.TabStop = true;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            this.Student.CheckedChanged += new System.EventHandler(this.Student_CheckedChanged);
            // 
            // Faculty
            // 
            this.Faculty.AutoSize = true;
            this.Faculty.Location = new System.Drawing.Point(352, 36);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(78, 24);
            this.Faculty.TabIndex = 2;
            this.Faculty.TabStop = true;
            this.Faculty.Text = "Faculty";
            this.Faculty.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(61, 118);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(61, 156);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // User_name
            // 
            this.User_name.Location = new System.Drawing.Point(178, 117);
            this.User_name.Name = "User_name";
            this.User_name.Size = new System.Drawing.Size(168, 26);
            this.User_name.TabIndex = 5;
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(178, 158);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.Size = new System.Drawing.Size(168, 26);
            this.Pass_word.TabIndex = 6;
            // 
            // Login
            // 
            this.Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Login.Location = new System.Drawing.Point(218, 225);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(84, 37);
            this.Login.TabIndex = 7;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.RadioButton Admin;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox Pass_word;
        private System.Windows.Forms.TextBox User_name;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.RadioButton Faculty;
        private System.Windows.Forms.RadioButton Student;
    }
}

