namespace Lab4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartQuadEquation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.buttonGO = new System.Windows.Forms.Button();
            this.chartSinEquation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxIntegRectanglesQuadEquation = new System.Windows.Forms.TextBox();
            this.labelIntegRectanglesMethod = new System.Windows.Forms.Label();
            this.labelIntegTrapeziumsMethod = new System.Windows.Forms.Label();
            this.textBoxIntegRectanglesSinusEquation = new System.Windows.Forms.TextBox();
            this.labelIntegRectanglesQuadEquation = new System.Windows.Forms.Label();
            this.labelIntegRectanglesSinusEquation = new System.Windows.Forms.Label();
            this.labelIntegTrapeziumsQuadEquation = new System.Windows.Forms.Label();
            this.labelIntegTrapeziumsSinusEquation = new System.Windows.Forms.Label();
            this.textBoxIntegTrapeziumsQuadEquation = new System.Windows.Forms.TextBox();
            this.textBoxIntegTrapeziumsSinusEquation = new System.Windows.Forms.TextBox();
            this.labelStepN = new System.Windows.Forms.Label();
            this.textBoxStepN = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuadEquation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSinEquation)).BeginInit();
            this.SuspendLayout();
            // 
            // chartQuadEquation
            // 
            chartArea3.Name = "ChartArea1";
            this.chartQuadEquation.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartQuadEquation.Legends.Add(legend3);
            this.chartQuadEquation.Location = new System.Drawing.Point(439, 38);
            this.chartQuadEquation.Name = "chartQuadEquation";
            this.chartQuadEquation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Квадратное уравнение";
            this.chartQuadEquation.Series.Add(series3);
            this.chartQuadEquation.Size = new System.Drawing.Size(704, 337);
            this.chartQuadEquation.TabIndex = 0;
            this.chartQuadEquation.Text = "chartQuadEquation";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(50, 39);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(50, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(23, 42);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 17);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(23, 83);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 17);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "B:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(23, 125);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(21, 17);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "C:";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(50, 80);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(50, 22);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(50, 122);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(50, 22);
            this.textBoxC.TabIndex = 6;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(174, 39);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(50, 22);
            this.textBoxX1.TabIndex = 7;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(174, 80);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(50, 22);
            this.textBoxX2.TabIndex = 8;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(139, 42);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(29, 17);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "X1:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(139, 83);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(29, 17);
            this.labelX2.TabIndex = 10;
            this.labelX2.Text = "X2:";
            // 
            // buttonGO
            // 
            this.buttonGO.Location = new System.Drawing.Point(50, 183);
            this.buttonGO.Name = "buttonGO";
            this.buttonGO.Size = new System.Drawing.Size(301, 64);
            this.buttonGO.TabIndex = 11;
            this.buttonGO.Text = "GO";
            this.buttonGO.UseVisualStyleBackColor = true;
            this.buttonGO.Click += new System.EventHandler(this.buttonGO_Click);
            // 
            // chartSinEquation
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSinEquation.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSinEquation.Legends.Add(legend4);
            this.chartSinEquation.Location = new System.Drawing.Point(439, 408);
            this.chartSinEquation.Name = "chartSinEquation";
            this.chartSinEquation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Sin";
            this.chartSinEquation.Series.Add(series4);
            this.chartSinEquation.Size = new System.Drawing.Size(704, 337);
            this.chartSinEquation.TabIndex = 12;
            this.chartSinEquation.Text = "chartSinEquation";
            // 
            // textBoxIntegRectanglesQuadEquation
            // 
            this.textBoxIntegRectanglesQuadEquation.Location = new System.Drawing.Point(135, 355);
            this.textBoxIntegRectanglesQuadEquation.Name = "textBoxIntegRectanglesQuadEquation";
            this.textBoxIntegRectanglesQuadEquation.ReadOnly = true;
            this.textBoxIntegRectanglesQuadEquation.Size = new System.Drawing.Size(216, 22);
            this.textBoxIntegRectanglesQuadEquation.TabIndex = 13;
            // 
            // labelIntegRectanglesMethod
            // 
            this.labelIntegRectanglesMethod.AutoSize = true;
            this.labelIntegRectanglesMethod.Location = new System.Drawing.Point(23, 301);
            this.labelIntegRectanglesMethod.Name = "labelIntegRectanglesMethod";
            this.labelIntegRectanglesMethod.Size = new System.Drawing.Size(246, 34);
            this.labelIntegRectanglesMethod.TabIndex = 14;
            this.labelIntegRectanglesMethod.Text = "Приближенное значение интеграла\r\nметодом прямоугольгиков";
            // 
            // labelIntegTrapeziumsMethod
            // 
            this.labelIntegTrapeziumsMethod.AutoSize = true;
            this.labelIntegTrapeziumsMethod.Location = new System.Drawing.Point(23, 497);
            this.labelIntegTrapeziumsMethod.Name = "labelIntegTrapeziumsMethod";
            this.labelIntegTrapeziumsMethod.Size = new System.Drawing.Size(246, 34);
            this.labelIntegTrapeziumsMethod.TabIndex = 15;
            this.labelIntegTrapeziumsMethod.Text = "Приближенное значение интеграла\r\nметодом трапеций";
            // 
            // textBoxIntegRectanglesSinusEquation
            // 
            this.textBoxIntegRectanglesSinusEquation.Location = new System.Drawing.Point(135, 395);
            this.textBoxIntegRectanglesSinusEquation.Name = "textBoxIntegRectanglesSinusEquation";
            this.textBoxIntegRectanglesSinusEquation.ReadOnly = true;
            this.textBoxIntegRectanglesSinusEquation.Size = new System.Drawing.Size(216, 22);
            this.textBoxIntegRectanglesSinusEquation.TabIndex = 16;
            // 
            // labelIntegRectanglesQuadEquation
            // 
            this.labelIntegRectanglesQuadEquation.AutoSize = true;
            this.labelIntegRectanglesQuadEquation.Location = new System.Drawing.Point(23, 358);
            this.labelIntegRectanglesQuadEquation.Name = "labelIntegRectanglesQuadEquation";
            this.labelIntegRectanglesQuadEquation.Size = new System.Drawing.Size(106, 17);
            this.labelIntegRectanglesQuadEquation.TabIndex = 17;
            this.labelIntegRectanglesQuadEquation.Text = "Кв. уравнение:";
            // 
            // labelIntegRectanglesSinusEquation
            // 
            this.labelIntegRectanglesSinusEquation.AutoSize = true;
            this.labelIntegRectanglesSinusEquation.Location = new System.Drawing.Point(23, 398);
            this.labelIntegRectanglesSinusEquation.Name = "labelIntegRectanglesSinusEquation";
            this.labelIntegRectanglesSinusEquation.Size = new System.Drawing.Size(32, 17);
            this.labelIntegRectanglesSinusEquation.TabIndex = 18;
            this.labelIntegRectanglesSinusEquation.Text = "Sin:";
            // 
            // labelIntegTrapeziumsQuadEquation
            // 
            this.labelIntegTrapeziumsQuadEquation.AutoSize = true;
            this.labelIntegTrapeziumsQuadEquation.Location = new System.Drawing.Point(23, 558);
            this.labelIntegTrapeziumsQuadEquation.Name = "labelIntegTrapeziumsQuadEquation";
            this.labelIntegTrapeziumsQuadEquation.Size = new System.Drawing.Size(106, 17);
            this.labelIntegTrapeziumsQuadEquation.TabIndex = 19;
            this.labelIntegTrapeziumsQuadEquation.Text = "Кв. уравнение:";
            // 
            // labelIntegTrapeziumsSinusEquation
            // 
            this.labelIntegTrapeziumsSinusEquation.AutoSize = true;
            this.labelIntegTrapeziumsSinusEquation.Location = new System.Drawing.Point(23, 599);
            this.labelIntegTrapeziumsSinusEquation.Name = "labelIntegTrapeziumsSinusEquation";
            this.labelIntegTrapeziumsSinusEquation.Size = new System.Drawing.Size(32, 17);
            this.labelIntegTrapeziumsSinusEquation.TabIndex = 20;
            this.labelIntegTrapeziumsSinusEquation.Text = "Sin:";
            // 
            // textBoxIntegTrapeziumsQuadEquation
            // 
            this.textBoxIntegTrapeziumsQuadEquation.Location = new System.Drawing.Point(135, 555);
            this.textBoxIntegTrapeziumsQuadEquation.Name = "textBoxIntegTrapeziumsQuadEquation";
            this.textBoxIntegTrapeziumsQuadEquation.ReadOnly = true;
            this.textBoxIntegTrapeziumsQuadEquation.Size = new System.Drawing.Size(216, 22);
            this.textBoxIntegTrapeziumsQuadEquation.TabIndex = 21;
            // 
            // textBoxIntegTrapeziumsSinusEquation
            // 
            this.textBoxIntegTrapeziumsSinusEquation.Location = new System.Drawing.Point(135, 596);
            this.textBoxIntegTrapeziumsSinusEquation.Name = "textBoxIntegTrapeziumsSinusEquation";
            this.textBoxIntegTrapeziumsSinusEquation.ReadOnly = true;
            this.textBoxIntegTrapeziumsSinusEquation.Size = new System.Drawing.Size(216, 22);
            this.textBoxIntegTrapeziumsSinusEquation.TabIndex = 22;
            // 
            // labelStepN
            // 
            this.labelStepN.AutoSize = true;
            this.labelStepN.Location = new System.Drawing.Point(269, 42);
            this.labelStepN.Name = "labelStepN";
            this.labelStepN.Size = new System.Drawing.Size(131, 17);
            this.labelStepN.TabIndex = 23;
            this.labelStepN.Text = "Шаг разбиения (N)";
            // 
            // textBoxStepN
            // 
            this.textBoxStepN.Location = new System.Drawing.Point(301, 78);
            this.textBoxStepN.Name = "textBoxStepN";
            this.textBoxStepN.Size = new System.Drawing.Size(50, 22);
            this.textBoxStepN.TabIndex = 24;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(72, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(121, 17);
            this.labelInfo.TabIndex = 25;
            this.labelInfo.Text = "Введите данные:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 770);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxStepN);
            this.Controls.Add(this.labelStepN);
            this.Controls.Add(this.textBoxIntegTrapeziumsSinusEquation);
            this.Controls.Add(this.textBoxIntegTrapeziumsQuadEquation);
            this.Controls.Add(this.labelIntegTrapeziumsSinusEquation);
            this.Controls.Add(this.labelIntegTrapeziumsQuadEquation);
            this.Controls.Add(this.labelIntegRectanglesSinusEquation);
            this.Controls.Add(this.labelIntegRectanglesQuadEquation);
            this.Controls.Add(this.textBoxIntegRectanglesSinusEquation);
            this.Controls.Add(this.labelIntegTrapeziumsMethod);
            this.Controls.Add(this.labelIntegRectanglesMethod);
            this.Controls.Add(this.textBoxIntegRectanglesQuadEquation);
            this.Controls.Add(this.chartSinEquation);
            this.Controls.Add(this.buttonGO);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.chartQuadEquation);
            this.MaximumSize = new System.Drawing.Size(1195, 817);
            this.MinimumSize = new System.Drawing.Size(1195, 817);
            this.Name = "Form1";
            this.Text = "Харламов П.К. ИБ-51. Лабораторная работа №4";
            ((System.ComponentModel.ISupportInitialize)(this.chartQuadEquation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSinEquation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuadEquation;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button buttonGO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSinEquation;
        private System.Windows.Forms.TextBox textBoxIntegRectanglesQuadEquation;
        private System.Windows.Forms.Label labelIntegRectanglesMethod;
        private System.Windows.Forms.Label labelIntegTrapeziumsMethod;
        private System.Windows.Forms.TextBox textBoxIntegRectanglesSinusEquation;
        private System.Windows.Forms.Label labelIntegRectanglesQuadEquation;
        private System.Windows.Forms.Label labelIntegRectanglesSinusEquation;
        private System.Windows.Forms.Label labelIntegTrapeziumsQuadEquation;
        private System.Windows.Forms.Label labelIntegTrapeziumsSinusEquation;
        private System.Windows.Forms.TextBox textBoxIntegTrapeziumsQuadEquation;
        private System.Windows.Forms.TextBox textBoxIntegTrapeziumsSinusEquation;
        private System.Windows.Forms.Label labelStepN;
        private System.Windows.Forms.TextBox textBoxStepN;
        private System.Windows.Forms.Label labelInfo;
    }
}

