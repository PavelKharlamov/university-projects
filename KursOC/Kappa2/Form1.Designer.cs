namespace Kappa2
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
            this.panelBegin = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioBack = new System.Windows.Forms.RadioButton();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelСhoice = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioSort = new System.Windows.Forms.RadioButton();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.linkGoogleDrive = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentInfo = new System.Windows.Forms.Label();
            this.labelKursach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSibUPK = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelBegin.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBegin
            // 
            this.panelBegin.Controls.Add(this.buttonBack);
            this.panelBegin.Controls.Add(this.buttonOK);
            this.panelBegin.Controls.Add(this.panelInfo);
            this.panelBegin.Controls.Add(this.buttonExit);
            this.panelBegin.Controls.Add(this.buttonD);
            this.panelBegin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBegin.Location = new System.Drawing.Point(0, 0);
            this.panelBegin.Name = "panelBegin";
            this.panelBegin.Size = new System.Drawing.Size(501, 407);
            this.panelBegin.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(186, 362);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 31);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "< Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(361, 363);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 31);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.panelAction);
            this.panelInfo.Controls.Add(this.linkGoogleDrive);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.labelStudentInfo);
            this.panelInfo.Controls.Add(this.labelKursach);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Controls.Add(this.labelSibUPK);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(501, 340);
            this.panelInfo.TabIndex = 3;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelAction.Controls.Add(this.buttonClear);
            this.panelAction.Controls.Add(this.radioBack);
            this.panelAction.Controls.Add(this.labelPath);
            this.panelAction.Controls.Add(this.labelСhoice);
            this.panelAction.Controls.Add(this.textBox1);
            this.panelAction.Controls.Add(this.radioSort);
            this.panelAction.Controls.Add(this.radioRandom);
            this.panelAction.Location = new System.Drawing.Point(-1, -1);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(501, 340);
            this.panelAction.TabIndex = 5;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(347, 286);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 31);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Сбросить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioBack
            // 
            this.radioBack.AutoSize = true;
            this.radioBack.Location = new System.Drawing.Point(46, 168);
            this.radioBack.Name = "radioBack";
            this.radioBack.Size = new System.Drawing.Size(232, 21);
            this.radioBack.TabIndex = 5;
            this.radioBack.TabStop = true;
            this.radioBack.Text = "Вернуть в исходное состояние\r\n";
            this.radioBack.UseVisualStyleBackColor = true;
            this.radioBack.CheckedChanged += new System.EventHandler(this.radioBack_CheckedChanged);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(43, 236);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(43, 17);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Путь:";
            // 
            // labelСhoice
            // 
            this.labelСhoice.AutoSize = true;
            this.labelСhoice.Location = new System.Drawing.Point(43, 57);
            this.labelСhoice.Name = "labelСhoice";
            this.labelСhoice.Size = new System.Drawing.Size(298, 17);
            this.labelСhoice.TabIndex = 3;
            this.labelСhoice.Text = "Выберите нужное действие и укажите путь:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(401, 22);
            this.textBox1.TabIndex = 2;
            // 
            // radioSort
            // 
            this.radioSort.AutoSize = true;
            this.radioSort.Location = new System.Drawing.Point(46, 123);
            this.radioSort.Name = "radioSort";
            this.radioSort.Size = new System.Drawing.Size(313, 21);
            this.radioSort.TabIndex = 1;
            this.radioSort.TabStop = true;
            this.radioSort.Text = "Пронумеровать файлы в папке по порядку";
            this.radioSort.UseVisualStyleBackColor = true;
            this.radioSort.CheckedChanged += new System.EventHandler(this.radioSort_CheckedChanged);
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(46, 96);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(216, 21);
            this.radioRandom.TabIndex = 0;
            this.radioRandom.TabStop = true;
            this.radioRandom.Text = "Перемешать файлы в папке";
            this.radioRandom.UseVisualStyleBackColor = true;
            this.radioRandom.CheckedChanged += new System.EventHandler(this.radioRandom_CheckedChanged);
            // 
            // linkGoogleDrive
            // 
            this.linkGoogleDrive.AutoSize = true;
            this.linkGoogleDrive.LinkColor = System.Drawing.SystemColors.Highlight;
            this.linkGoogleDrive.Location = new System.Drawing.Point(13, 276);
            this.linkGoogleDrive.Name = "linkGoogleDrive";
            this.linkGoogleDrive.Size = new System.Drawing.Size(363, 17);
            this.linkGoogleDrive.TabIndex = 6;
            this.linkGoogleDrive.TabStop = true;
            this.linkGoogleDrive.Text = "Посмотреть / скачать курсовую работу (Google Диск)";
            this.linkGoogleDrive.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGoogleDrive_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Новосибирск, 2018";
            // 
            // labelStudentInfo
            // 
            this.labelStudentInfo.AutoSize = true;
            this.labelStudentInfo.Location = new System.Drawing.Point(12, 192);
            this.labelStudentInfo.Name = "labelStudentInfo";
            this.labelStudentInfo.Size = new System.Drawing.Size(256, 68);
            this.labelStudentInfo.TabIndex = 3;
            this.labelStudentInfo.Text = "студента III курса\r\nфакультета Экономики и управления\r\nгруппы ИБ-51\r\nХарламова Па" +
    "вла Константиновича";
            // 
            // labelKursach
            // 
            this.labelKursach.AutoSize = true;
            this.labelKursach.Location = new System.Drawing.Point(13, 120);
            this.labelKursach.Name = "labelKursach";
            this.labelKursach.Size = new System.Drawing.Size(462, 51);
            this.labelKursach.TabIndex = 2;
            this.labelKursach.Text = "Курсовая работа\r\nпо теме\r\nФайловый менеджер с функцией переупорядочивания и нумер" +
    "ации";
            this.labelKursach.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSibUPK
            // 
            this.labelSibUPK.AutoSize = true;
            this.labelSibUPK.Location = new System.Drawing.Point(18, 17);
            this.labelSibUPK.Name = "labelSibUPK";
            this.labelSibUPK.Size = new System.Drawing.Size(449, 85);
            this.labelSibUPK.TabIndex = 1;
            this.labelSibUPK.Text = "Частное образовательное учреждение\r\nвысшего профессионального образования\r\nЦентро" +
    "союза Российской Федерации\r\nСИБИРСКИЙ УНИВЕРСИТЕТ ПОТРЕБИТЕЛЬСКОЙ КООПЕРАЦИИ\r\n(С" +
    "ибУПК)";
            this.labelSibUPK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(15, 362);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 31);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(361, 362);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(76, 31);
            this.buttonD.TabIndex = 1;
            this.buttonD.Text = "Далее >";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 407);
            this.Controls.Add(this.panelBegin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(519, 454);
            this.MinimumSize = new System.Drawing.Size(519, 454);
            this.Name = "Form1";
            this.Text = "Курсовая работа";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBegin.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBegin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSibUPK;
        private System.Windows.Forms.Label labelStudentInfo;
        private System.Windows.Forms.Label labelKursach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioSort;
        private System.Windows.Forms.RadioButton radioRandom;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelСhoice;
        private System.Windows.Forms.RadioButton radioBack;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.LinkLabel linkGoogleDrive;
        private System.Windows.Forms.Button buttonClear;
    }
}

