namespace WindowsFormsApp1
{
    partial class Autorization
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
            this.Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(252, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(280, 304);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(154, 54);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Войти";
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(268, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Silver;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login.Location = new System.Drawing.Point(324, 111);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(69, 24);
            this.Login.TabIndex = 4;
            this.Login.Text = "Логин";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Silver;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(324, 179);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 24);
            this.Password.TabIndex = 5;
            this.Password.Text = "Пароль";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(289, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 28);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Регистрация";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Hanger_Library;
            this.ClientSize = new System.Drawing.Size(733, 442);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Name = "Autorization";
            this.Text = "Autorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}