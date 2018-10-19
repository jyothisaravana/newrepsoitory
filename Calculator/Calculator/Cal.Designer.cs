namespace Calculator
{
    partial class Cal
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
            this.B1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.Clear_box = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(222, 109);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(40, 38);
            this.B1.TabIndex = 0;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 20);
            this.textBox1.TabIndex = 1;
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(285, 109);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(40, 38);
            this.B2.TabIndex = 2;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(466, 109);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(40, 38);
            this.b5.TabIndex = 3;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(409, 109);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(40, 38);
            this.b4.TabIndex = 4;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(348, 109);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(40, 38);
            this.b3.TabIndex = 5;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // equals
            // 
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(428, 178);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(40, 38);
            this.equals.TabIndex = 6;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // b_minus
            // 
            this.b_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_minus.Location = new System.Drawing.Point(348, 178);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(40, 38);
            this.b_minus.TabIndex = 7;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = true;
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
            // 
            // b_plus
            // 
            this.b_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_plus.Location = new System.Drawing.Point(266, 178);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(40, 38);
            this.b_plus.TabIndex = 8;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = true;
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
            // 
            // Clear_box
            // 
            this.Clear_box.Location = new System.Drawing.Point(330, 258);
            this.Clear_box.Name = "Clear_box";
            this.Clear_box.Size = new System.Drawing.Size(119, 38);
            this.Clear_box.TabIndex = 9;
            this.Clear_box.Text = "Clear";
            this.Clear_box.UseVisualStyleBackColor = true;
            this.Clear_box.Click += new System.EventHandler(this.Clear_box_Click);
            // 
            // Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear_box);
            this.Controls.Add(this.b_plus);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.B1);
            this.Name = "Cal";
            this.Text = "Cal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button b_minus;
        private System.Windows.Forms.Button b_plus;
        private System.Windows.Forms.Button Clear_box;
    }
}