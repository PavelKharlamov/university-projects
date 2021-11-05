namespace FormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_PersonnelDepartment = new System.Windows.Forms.Label();
            this.label_Authorization = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Authorization = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PersonnelDepartment
            // 
            this.label_PersonnelDepartment.AutoSize = true;
            this.label_PersonnelDepartment.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_PersonnelDepartment.Location = new System.Drawing.Point(93, 40);
            this.label_PersonnelDepartment.Name = "label_PersonnelDepartment";
            this.label_PersonnelDepartment.Size = new System.Drawing.Size(362, 49);
            this.label_PersonnelDepartment.TabIndex = 0;
            this.label_PersonnelDepartment.Text = "ОТДЕЛ КАДРОВ";
            // 
            // label_Authorization
            // 
            this.label_Authorization.AutoSize = true;
            this.label_Authorization.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Authorization.Location = new System.Drawing.Point(164, 109);
            this.label_Authorization.Name = "label_Authorization";
            this.label_Authorization.Size = new System.Drawing.Size(205, 38);
            this.label_Authorization.TabIndex = 1;
            this.label_Authorization.Text = "Авторизация";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Password.Location = new System.Drawing.Point(16, 278);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(109, 33);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Пароль:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.Location = new System.Drawing.Point(29, 226);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(96, 33);
            this.label_Login.TabIndex = 2;
            this.label_Login.Text = "Логин:";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(156, 234);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(252, 22);
            this.textBox_Login.TabIndex = 4;
            this.textBox_Login.TextChanged += new System.EventHandler(this.textBox_Login_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(156, 286);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(252, 22);
            this.textBox_Password.TabIndex = 5;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // button_Authorization
            // 
            this.button_Authorization.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Authorization.Location = new System.Drawing.Point(102, 361);
            this.button_Authorization.Name = "button_Authorization";
            this.button_Authorization.Size = new System.Drawing.Size(130, 58);
            this.button_Authorization.TabIndex = 6;
            this.button_Authorization.Text = "ВОЙТИ";
            this.button_Authorization.UseVisualStyleBackColor = true;
            this.button_Authorization.Click += new System.EventHandler(this.button_Authorization_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(342, 361);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(130, 58);
            this.button_Exit.TabIndex = 7;
            this.button_Exit.Text = "ВЫХОД";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(561, 441);
            this.ControlBox = false;
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_Authorization);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_Authorization);
            this.Controls.Add(this.label_PersonnelDepartment);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(579, 488);
            this.MinimumSize = new System.Drawing.Size(579, 488);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PersonnelDepartment;
        private System.Windows.Forms.Label label_Authorization;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Authorization;
        private System.Windows.Forms.Button button_Exit;
    }
}

