namespace Login1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.student = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.faculty = new System.Windows.Forms.RadioButton();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.user_name);
            this.groupBox1.Controls.Add(this.Pass_word);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.faculty);
            this.groupBox1.Controls.Add(this.admin);
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(151, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select_one";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student.Location = new System.Drawing.Point(198, 57);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(72, 15);
            this.student.TabIndex = 0;
            this.student.TabStop = true;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(39, 57);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(58, 15);
            this.admin.TabIndex = 1;
            this.admin.TabStop = true;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // faculty
            // 
            this.faculty.AutoSize = true;
            this.faculty.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty.Location = new System.Drawing.Point(348, 57);
            this.faculty.Name = "faculty";
            this.faculty.Size = new System.Drawing.Size(72, 15);
            this.faculty.TabIndex = 2;
            this.faculty.TabStop = true;
            this.faculty.Text = "Faculty";
            this.faculty.UseVisualStyleBackColor = true;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(79, 116);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(67, 15);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(79, 177);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(173, 174);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.Size = new System.Drawing.Size(140, 22);
            this.Pass_word.TabIndex = 5;
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(173, 109);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(140, 22);
            this.user_name.TabIndex = 6;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(198, 227);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox Pass_word;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.RadioButton faculty;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.RadioButton student;
        private System.Windows.Forms.Label label1;
    }
}

