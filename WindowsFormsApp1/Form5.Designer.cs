namespace WindowsFormsApp1
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "СМЕНА ПАРОЛЯ";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(88, 143);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(201, 20);
            this.LoginTextBox.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Silver;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Login.Location = new System.Drawing.Point(147, 98);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 24);
            this.Login.TabIndex = 5;
            this.Login.Text = "Логин";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(88, 230);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(201, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Password.Location = new System.Drawing.Point(147, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 24);
            this.Password.TabIndex = 7;
            this.Password.Text = "Пароль";
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Open.Location = new System.Drawing.Point(102, 279);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(154, 54);
            this.Open.TabIndex = 8;
            this.Open.Text = "СМЕНА ПАРОЛЯ";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(301, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button button1;
    }
}