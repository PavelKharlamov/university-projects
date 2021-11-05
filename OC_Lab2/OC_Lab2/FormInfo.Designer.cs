namespace OC_Lab2
{
    partial class FormInfo
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
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo2
            // 
            this.labelInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Location = new System.Drawing.Point(96, 92);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(134, 30);
            this.labelInfo2.TabIndex = 1;
            this.labelInfo2.Text = "Новосибирск, 2018";
            // 
            // labelInfo1
            // 
            this.labelInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Location = new System.Drawing.Point(3, 0);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(320, 92);
            this.labelInfo1.TabIndex = 0;
            this.labelInfo1.Text = "Харламов П.К.\r\nИБ-51\r\nОС. Лабораторная работа №2";
            // 
            // tableLayoutPanelInfo
            // 
            this.tableLayoutPanelInfo.ColumnCount = 2;
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.5F));
            this.tableLayoutPanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.5F));
            this.tableLayoutPanelInfo.Controls.Add(this.labelInfo1, 0, 0);
            this.tableLayoutPanelInfo.Controls.Add(this.labelInfo2, 0, 1);
            this.tableLayoutPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInfo.Name = "tableLayoutPanelInfo";
            this.tableLayoutPanelInfo.RowCount = 2;
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.22951F));
            this.tableLayoutPanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.77049F));
            this.tableLayoutPanelInfo.Size = new System.Drawing.Size(342, 122);
            this.tableLayoutPanelInfo.TabIndex = 2;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 122);
            this.Controls.Add(this.tableLayoutPanelInfo);
            this.MaximumSize = new System.Drawing.Size(360, 169);
            this.MinimumSize = new System.Drawing.Size(360, 169);
            this.Name = "FormInfo";
            this.Text = "О программе";
            this.tableLayoutPanelInfo.ResumeLayout(false);
            this.tableLayoutPanelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInfo;
    }
}