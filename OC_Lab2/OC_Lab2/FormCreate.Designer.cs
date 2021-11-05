namespace OC_Lab2
{
    partial class FormCreate
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
            this.labelCreateName = new System.Windows.Forms.Label();
            this.labelCreateWidth = new System.Windows.Forms.Label();
            this.labelCreateHeight = new System.Windows.Forms.Label();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.textBoxCreateWidth = new System.Windows.Forms.TextBox();
            this.textBoxCreateHeight = new System.Windows.Forms.TextBox();
            this.buttonCreateOK = new System.Windows.Forms.Button();
            this.buttonCreateCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreateName
            // 
            this.labelCreateName.AutoSize = true;
            this.labelCreateName.Location = new System.Drawing.Point(22, 24);
            this.labelCreateName.Name = "labelCreateName";
            this.labelCreateName.Size = new System.Drawing.Size(86, 17);
            this.labelCreateName.TabIndex = 0;
            this.labelCreateName.Text = "Имя файла:";
            // 
            // labelCreateWidth
            // 
            this.labelCreateWidth.AutoSize = true;
            this.labelCreateWidth.Location = new System.Drawing.Point(22, 64);
            this.labelCreateWidth.Name = "labelCreateWidth";
            this.labelCreateWidth.Size = new System.Drawing.Size(63, 17);
            this.labelCreateWidth.TabIndex = 1;
            this.labelCreateWidth.Text = "Ширина:";
            // 
            // labelCreateHeight
            // 
            this.labelCreateHeight.AutoSize = true;
            this.labelCreateHeight.Location = new System.Drawing.Point(218, 66);
            this.labelCreateHeight.Name = "labelCreateHeight";
            this.labelCreateHeight.Size = new System.Drawing.Size(61, 17);
            this.labelCreateHeight.TabIndex = 2;
            this.labelCreateHeight.Text = "Высота:";
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.Location = new System.Drawing.Point(124, 21);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(235, 22);
            this.textBoxCreateName.TabIndex = 3;
            // 
            // textBoxCreateWidth
            // 
            this.textBoxCreateWidth.Location = new System.Drawing.Point(91, 61);
            this.textBoxCreateWidth.Name = "textBoxCreateWidth";
            this.textBoxCreateWidth.Size = new System.Drawing.Size(74, 22);
            this.textBoxCreateWidth.TabIndex = 4;
            // 
            // textBoxCreateHeight
            // 
            this.textBoxCreateHeight.Location = new System.Drawing.Point(285, 64);
            this.textBoxCreateHeight.Name = "textBoxCreateHeight";
            this.textBoxCreateHeight.Size = new System.Drawing.Size(74, 22);
            this.textBoxCreateHeight.TabIndex = 5;
            // 
            // buttonCreateOK
            // 
            this.buttonCreateOK.Location = new System.Drawing.Point(77, 108);
            this.buttonCreateOK.Name = "buttonCreateOK";
            this.buttonCreateOK.Size = new System.Drawing.Size(88, 43);
            this.buttonCreateOK.TabIndex = 6;
            this.buttonCreateOK.Text = "OK";
            this.buttonCreateOK.UseVisualStyleBackColor = true;
            this.buttonCreateOK.Click += new System.EventHandler(this.buttonCreateOK_Click);
            // 
            // buttonCreateCancel
            // 
            this.buttonCreateCancel.Location = new System.Drawing.Point(205, 108);
            this.buttonCreateCancel.Name = "buttonCreateCancel";
            this.buttonCreateCancel.Size = new System.Drawing.Size(88, 43);
            this.buttonCreateCancel.TabIndex = 7;
            this.buttonCreateCancel.Text = "Закрыть";
            this.buttonCreateCancel.UseVisualStyleBackColor = true;
            this.buttonCreateCancel.Click += new System.EventHandler(this.buttonCreateCancel_Click);
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 163);
            this.Controls.Add(this.buttonCreateCancel);
            this.Controls.Add(this.buttonCreateOK);
            this.Controls.Add(this.textBoxCreateHeight);
            this.Controls.Add(this.textBoxCreateWidth);
            this.Controls.Add(this.textBoxCreateName);
            this.Controls.Add(this.labelCreateHeight);
            this.Controls.Add(this.labelCreateWidth);
            this.Controls.Add(this.labelCreateName);
            this.Name = "FormCreate";
            this.Text = "Создать изображение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateName;
        private System.Windows.Forms.Label labelCreateWidth;
        private System.Windows.Forms.Label labelCreateHeight;
        private System.Windows.Forms.TextBox textBoxCreateName;
        private System.Windows.Forms.TextBox textBoxCreateWidth;
        private System.Windows.Forms.TextBox textBoxCreateHeight;
        private System.Windows.Forms.Button buttonCreateOK;
        private System.Windows.Forms.Button buttonCreateCancel;
    }
}