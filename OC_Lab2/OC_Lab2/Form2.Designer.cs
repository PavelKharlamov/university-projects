namespace OC_Lab2
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.buttonChoiceColor = new System.Windows.Forms.Button();
            this.labelStandartColor = new System.Windows.Forms.Label();
            this.labelSelectedColor = new System.Windows.Forms.Label();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonSelectedColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.KvDraw = new System.Windows.Forms.Button();
            this.KrDraw = new System.Windows.Forms.Button();
            this.SnowflakeButton = new System.Windows.Forms.Button();
            this.CircleDraw = new System.Windows.Forms.Button();
            this.Lastic = new System.Windows.Forms.Button();
            this.DrawBar = new System.Windows.Forms.TrackBar();
            this.drawPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBar)).BeginInit();
            this.drawPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.создатьToolStripMenuItem.Text = "Создать...";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolsPanel.Controls.Add(this.buttonClear);
            this.toolsPanel.Controls.Add(this.buttonChoiceColor);
            this.toolsPanel.Controls.Add(this.labelStandartColor);
            this.toolsPanel.Controls.Add(this.labelSelectedColor);
            this.toolsPanel.Controls.Add(this.buttonRed);
            this.toolsPanel.Controls.Add(this.buttonBlue);
            this.toolsPanel.Controls.Add(this.buttonGreen);
            this.toolsPanel.Controls.Add(this.buttonYellow);
            this.toolsPanel.Controls.Add(this.buttonSelectedColor);
            this.toolsPanel.Controls.Add(this.groupBox1);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 28);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(212, 772);
            this.toolsPanel.TabIndex = 1;
            // 
            // buttonChoiceColor
            // 
            this.buttonChoiceColor.Location = new System.Drawing.Point(12, 445);
            this.buttonChoiceColor.Name = "buttonChoiceColor";
            this.buttonChoiceColor.Size = new System.Drawing.Size(178, 31);
            this.buttonChoiceColor.TabIndex = 8;
            this.buttonChoiceColor.Text = "Выбрать другой цвет";
            this.buttonChoiceColor.UseVisualStyleBackColor = true;
            this.buttonChoiceColor.Click += new System.EventHandler(this.buttonChoiceColor_Click);
            // 
            // labelStandartColor
            // 
            this.labelStandartColor.AutoSize = true;
            this.labelStandartColor.Location = new System.Drawing.Point(37, 371);
            this.labelStandartColor.Name = "labelStandartColor";
            this.labelStandartColor.Size = new System.Drawing.Size(139, 17);
            this.labelStandartColor.TabIndex = 7;
            this.labelStandartColor.Text = "Стандартные цвета";
            // 
            // labelSelectedColor
            // 
            this.labelSelectedColor.AutoSize = true;
            this.labelSelectedColor.Location = new System.Drawing.Point(7, 336);
            this.labelSelectedColor.Name = "labelSelectedColor";
            this.labelSelectedColor.Size = new System.Drawing.Size(123, 17);
            this.labelSelectedColor.TabIndex = 6;
            this.labelSelectedColor.Text = "Выбранный цвет:";
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(10, 396);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(27, 23);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(110, 396);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(27, 23);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.Lime;
            this.buttonGreen.Location = new System.Drawing.Point(163, 396);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(27, 23);
            this.buttonGreen.TabIndex = 3;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(59, 396);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(27, 23);
            this.buttonYellow.TabIndex = 2;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonSelectedColor
            // 
            this.buttonSelectedColor.BackColor = System.Drawing.Color.White;
            this.buttonSelectedColor.Location = new System.Drawing.Point(136, 335);
            this.buttonSelectedColor.Name = "buttonSelectedColor";
            this.buttonSelectedColor.Size = new System.Drawing.Size(27, 23);
            this.buttonSelectedColor.TabIndex = 1;
            this.buttonSelectedColor.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.DrawBar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(212, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размер кисти";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.KvDraw);
            this.flowLayoutPanel1.Controls.Add(this.KrDraw);
            this.flowLayoutPanel1.Controls.Add(this.SnowflakeButton);
            this.flowLayoutPanel1.Controls.Add(this.CircleDraw);
            this.flowLayoutPanel1.Controls.Add(this.Lastic);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 71);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(204, 257);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кисти";
            // 
            // KvDraw
            // 
            this.KvDraw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.KvDraw.Location = new System.Drawing.Point(4, 21);
            this.KvDraw.Margin = new System.Windows.Forms.Padding(4);
            this.KvDraw.Name = "KvDraw";
            this.KvDraw.Size = new System.Drawing.Size(194, 38);
            this.KvDraw.TabIndex = 4;
            this.KvDraw.Text = "Квадрат";
            this.KvDraw.UseVisualStyleBackColor = false;
            this.KvDraw.Click += new System.EventHandler(this.KvDraw_Click);
            // 
            // KrDraw
            // 
            this.KrDraw.Location = new System.Drawing.Point(4, 67);
            this.KrDraw.Margin = new System.Windows.Forms.Padding(4);
            this.KrDraw.Name = "KrDraw";
            this.KrDraw.Size = new System.Drawing.Size(194, 38);
            this.KrDraw.TabIndex = 5;
            this.KrDraw.Text = "Вертикальная линия";
            this.KrDraw.UseVisualStyleBackColor = true;
            this.KrDraw.Click += new System.EventHandler(this.KrDraw_Click);
            // 
            // SnowflakeButton
            // 
            this.SnowflakeButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SnowflakeButton.Location = new System.Drawing.Point(4, 113);
            this.SnowflakeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SnowflakeButton.Name = "SnowflakeButton";
            this.SnowflakeButton.Size = new System.Drawing.Size(194, 36);
            this.SnowflakeButton.TabIndex = 8;
            this.SnowflakeButton.Text = "Снежинка";
            this.SnowflakeButton.UseVisualStyleBackColor = true;
            this.SnowflakeButton.Click += new System.EventHandler(this.SnowflakeButton_Click);
            // 
            // CircleDraw
            // 
            this.CircleDraw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CircleDraw.Location = new System.Drawing.Point(4, 157);
            this.CircleDraw.Margin = new System.Windows.Forms.Padding(4);
            this.CircleDraw.Name = "CircleDraw";
            this.CircleDraw.Size = new System.Drawing.Size(194, 42);
            this.CircleDraw.TabIndex = 7;
            this.CircleDraw.Text = "Круг";
            this.CircleDraw.UseVisualStyleBackColor = false;
            this.CircleDraw.Click += new System.EventHandler(this.CircleDraw_Click);
            // 
            // Lastic
            // 
            this.Lastic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Lastic.Location = new System.Drawing.Point(4, 207);
            this.Lastic.Margin = new System.Windows.Forms.Padding(4);
            this.Lastic.Name = "Lastic";
            this.Lastic.Size = new System.Drawing.Size(194, 41);
            this.Lastic.TabIndex = 1;
            this.Lastic.Text = "Ластик";
            this.Lastic.UseVisualStyleBackColor = true;
            this.Lastic.Click += new System.EventHandler(this.Lastic_Click);
            // 
            // DrawBar
            // 
            this.DrawBar.AutoSize = false;
            this.DrawBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrawBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.DrawBar.Location = new System.Drawing.Point(4, 19);
            this.DrawBar.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBar.Maximum = 70;
            this.DrawBar.Minimum = 7;
            this.DrawBar.Name = "DrawBar";
            this.DrawBar.Size = new System.Drawing.Size(204, 52);
            this.DrawBar.SmallChange = 2;
            this.DrawBar.TabIndex = 0;
            this.DrawBar.Tag = "";
            this.DrawBar.Value = 7;
            this.DrawBar.Scroll += new System.EventHandler(this.DrawBar_Scroll);
            // 
            // drawPanel
            // 
            this.drawPanel.AutoScroll = true;
            this.drawPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.drawPanel.Controls.Add(this.pictureBox1);
            this.drawPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPanel.Location = new System.Drawing.Point(212, 28);
            this.drawPanel.Margin = new System.Windows.Forms.Padding(4);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(943, 772);
            this.drawPanel.TabIndex = 2;
            this.drawPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawPanel_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 197);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 498);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(178, 45);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Очистить лист";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 772);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 800);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(867, 625);
            this.Name = "Form2";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawBar)).EndInit();
            this.drawPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel toolsPanel;
        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button Lastic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button KvDraw;
        private System.Windows.Forms.Button KrDraw;
        private System.Windows.Forms.Button SnowflakeButton;
        private System.Windows.Forms.Button CircleDraw;
        private System.Windows.Forms.TrackBar DrawBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonSelectedColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelSelectedColor;
        private System.Windows.Forms.Label labelStandartColor;
        private System.Windows.Forms.Button buttonChoiceColor;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}