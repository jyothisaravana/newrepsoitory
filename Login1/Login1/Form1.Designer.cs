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
            this.Perform_operation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Radio_add = new System.Windows.Forms.RadioButton();
            this.Radio_div = new System.Windows.Forms.RadioButton();
            this.Radio_sub = new System.Windows.Forms.RadioButton();
            this.Radio_mul = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.add_sum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Addition = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.Num_1 = new System.Windows.Forms.TextBox();
            this.Num_2 = new System.Windows.Forms.TextBox();
            this.Clear_field = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.user_name = new System.Windows.Forms.TextBox();
            this.Pass_word = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.faculty = new System.Windows.Forms.RadioButton();
            this.admin = new System.Windows.Forms.RadioButton();
            this.student = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Combo_box = new System.Windows.Forms.ComboBox();
            this.Choice = new System.Windows.Forms.Button();
            this.List_box = new System.Windows.Forms.ListBox();
            this.List_item = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.next);
            this.groupBox1.Controls.Add(this.List_item);
            this.groupBox1.Controls.Add(this.List_box);
            this.groupBox1.Controls.Add(this.Choice);
            this.groupBox1.Controls.Add(this.Combo_box);
            this.groupBox1.Controls.Add(this.Perform_operation);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.add_sum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Addition);
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.Num_1);
            this.groupBox1.Controls.Add(this.Num_2);
            this.groupBox1.Controls.Add(this.Clear_field);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.user_name);
            this.groupBox1.Controls.Add(this.Pass_word);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.faculty);
            this.groupBox1.Controls.Add(this.admin);
            this.groupBox1.Controls.Add(this.student);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1066, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select_one";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Perform_operation
            // 
            this.Perform_operation.Location = new System.Drawing.Point(626, 310);
            this.Perform_operation.Name = "Perform_operation";
            this.Perform_operation.Size = new System.Drawing.Size(75, 23);
            this.Perform_operation.TabIndex = 23;
            this.Perform_operation.Text = "Ok";
            this.Perform_operation.UseVisualStyleBackColor = true;
            this.Perform_operation.Click += new System.EventHandler(this.Perform_operation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Radio_add);
            this.groupBox2.Controls.Add(this.Radio_div);
            this.groupBox2.Controls.Add(this.Radio_sub);
            this.groupBox2.Controls.Add(this.Radio_mul);
            this.groupBox2.Location = new System.Drawing.Point(569, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select_operation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Radio_add
            // 
            this.Radio_add.AutoSize = true;
            this.Radio_add.Location = new System.Drawing.Point(22, 35);
            this.Radio_add.Name = "Radio_add";
            this.Radio_add.Size = new System.Drawing.Size(50, 19);
            this.Radio_add.TabIndex = 18;
            this.Radio_add.TabStop = true;
            this.Radio_add.Text = "Add";
            this.Radio_add.UseVisualStyleBackColor = true;
            this.Radio_add.CheckedChanged += new System.EventHandler(this.radio_add_CheckedChanged);
            // 
            // Radio_div
            // 
            this.Radio_div.AutoSize = true;
            this.Radio_div.Location = new System.Drawing.Point(106, 69);
            this.Radio_div.Name = "Radio_div";
            this.Radio_div.Size = new System.Drawing.Size(75, 19);
            this.Radio_div.TabIndex = 20;
            this.Radio_div.TabStop = true;
            this.Radio_div.Text = "Division";
            this.Radio_div.UseVisualStyleBackColor = true;
            // 
            // Radio_sub
            // 
            this.Radio_sub.AutoSize = true;
            this.Radio_sub.Location = new System.Drawing.Point(92, 35);
            this.Radio_sub.Name = "Radio_sub";
            this.Radio_sub.Size = new System.Drawing.Size(46, 19);
            this.Radio_sub.TabIndex = 17;
            this.Radio_sub.TabStop = true;
            this.Radio_sub.Text = "Sub";
            this.Radio_sub.UseVisualStyleBackColor = true;
            // 
            // Radio_mul
            // 
            this.Radio_mul.AutoSize = true;
            this.Radio_mul.Location = new System.Drawing.Point(22, 70);
            this.Radio_mul.Name = "Radio_mul";
            this.Radio_mul.Size = new System.Drawing.Size(78, 19);
            this.Radio_mul.TabIndex = 16;
            this.Radio_mul.TabStop = true;
            this.Radio_mul.Text = "Multiply";
            this.Radio_mul.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 18);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(103, 19);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // add_sum
            // 
            this.add_sum.Location = new System.Drawing.Point(626, 342);
            this.add_sum.Name = "add_sum";
            this.add_sum.Size = new System.Drawing.Size(100, 22);
            this.add_sum.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Result";
            // 
            // Addition
            // 
            this.Addition.AutoSize = true;
            this.Addition.Location = new System.Drawing.Point(647, 57);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(79, 15);
            this.Addition.TabIndex = 13;
            this.Addition.Text = "Calculations";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(566, 172);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(43, 15);
            this.num2.TabIndex = 12;
            this.num2.Text = "Num2";
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(566, 116);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(42, 15);
            this.num1.TabIndex = 11;
            this.num1.Text = "Num1";
            this.num1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Num_1
            // 
            this.Num_1.Location = new System.Drawing.Point(624, 109);
            this.Num_1.Name = "Num_1";
            this.Num_1.Size = new System.Drawing.Size(100, 22);
            this.Num_1.TabIndex = 10;
            // 
            // Num_2
            // 
            this.Num_2.Location = new System.Drawing.Point(624, 165);
            this.Num_2.Name = "Num_2";
            this.Num_2.Size = new System.Drawing.Size(100, 22);
            this.Num_2.TabIndex = 9;
            // 
            // Clear_field
            // 
            this.Clear_field.Location = new System.Drawing.Point(750, 341);
            this.Clear_field.Name = "Clear_field";
            this.Clear_field.Size = new System.Drawing.Size(75, 23);
            this.Clear_field.TabIndex = 8;
            this.Clear_field.Text = "Clear";
            this.Clear_field.UseVisualStyleBackColor = true;
            this.Clear_field.Click += new System.EventHandler(this.Clear_field_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(198, 227);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // user_name
            // 
            this.user_name.Location = new System.Drawing.Point(173, 109);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(140, 22);
            this.user_name.TabIndex = 6;
            // 
            // Pass_word
            // 
            this.Pass_word.Location = new System.Drawing.Point(173, 174);
            this.Pass_word.Name = "Pass_word";
            this.Pass_word.PasswordChar = '*';
            this.Pass_word.Size = new System.Drawing.Size(140, 22);
            this.Pass_word.TabIndex = 5;
            this.Pass_word.TextChanged += new System.EventHandler(this.Pass_word_TextChanged);
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
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(79, 116);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(67, 15);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
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
            this.admin.CheckedChanged += new System.EventHandler(this.admin_CheckedChanged);
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
            // Combo_box
            // 
            this.Combo_box.FormattingEnabled = true;
            this.Combo_box.Items.AddRange(new object[] {
            "India",
            "Africa",
            "America"});
            this.Combo_box.Location = new System.Drawing.Point(173, 311);
            this.Combo_box.Name = "Combo_box";
            this.Combo_box.Size = new System.Drawing.Size(121, 23);
            this.Combo_box.TabIndex = 24;
            // 
            // Choice
            // 
            this.Choice.Location = new System.Drawing.Point(339, 310);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(129, 54);
            this.Choice.TabIndex = 25;
            this.Choice.Text = "Show Choice";
            this.Choice.UseVisualStyleBackColor = true;
            this.Choice.Click += new System.EventHandler(this.Choice_Click);
            // 
            // List_box
            // 
            this.List_box.FormattingEnabled = true;
            this.List_box.ItemHeight = 15;
            this.List_box.Items.AddRange(new object[] {
            "Cocola",
            "Pepsi",
            "Coffee",
            "Tea"});
            this.List_box.Location = new System.Drawing.Point(173, 383);
            this.List_box.Name = "List_box";
            this.List_box.Size = new System.Drawing.Size(120, 94);
            this.List_box.TabIndex = 26;
            // 
            // List_item
            // 
            this.List_item.Location = new System.Drawing.Point(330, 454);
            this.List_item.Name = "List_item";
            this.List_item.Size = new System.Drawing.Size(90, 23);
            this.List_item.TabIndex = 27;
            this.List_item.Text = "Select";
            this.List_item.UseVisualStyleBackColor = true;
            this.List_item.Click += new System.EventHandler(this.List_item_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(566, 454);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(135, 40);
            this.next.TabIndex = 28;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1104, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox add_sum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Addition;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.TextBox Num_1;
        private System.Windows.Forms.TextBox Num_2;
        private System.Windows.Forms.Button Clear_field;
        private System.Windows.Forms.RadioButton Radio_div;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton Radio_add;
        private System.Windows.Forms.RadioButton Radio_sub;
        private System.Windows.Forms.RadioButton Radio_mul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Perform_operation;
        private System.Windows.Forms.ComboBox Combo_box;
        private System.Windows.Forms.Button Choice;
        private System.Windows.Forms.Button List_item;
        private System.Windows.Forms.ListBox List_box;
        private System.Windows.Forms.Button next;
    }
}

