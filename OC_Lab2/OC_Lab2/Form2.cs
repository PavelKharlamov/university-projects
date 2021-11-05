using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OC_Lab2
{
    public partial class Form2 : Form
    {
        ///<summary>
        ///Цвет заливки по умолчанию
        ///</summary>
        Color DefaultColor
        {
            get { return Color.White; }
        }

        int _x;          //текущая x координата мыши
        int _y;          //текущая y координата мыши
        bool _mouseClicked = false;  // мышь заката, состояние актуально для рисования кистью
        
        /// <summary>
        /// Выбранный цвет, пока задан константой, в дальнейшем - из цветовой палитры
        /// </summary>
        Color SelectedColor
        {
            get { return colorDialog1.Color; }

            set
            {
                colorDialog1.Color = value;
                if (_selectedBrush != null)
                {
                    _selectedBrush.BrushColor = colorDialog1.Color;
                    buttonSelectedColor.BackColor = SelectedColor;
                }
            }
        }

        Color LasticColor
        {
            get { return Color.White; }
        }

        /// <summary>
        /// Выбранный размер кисти задается положением ползунка
        /// </summary>
        int SelectedSize
        {
            get { return DrawBar.Value; }

            set
            {
                DrawBar.Value = value;

                if(_selectedBrush != null)
                {
                    _selectedBrush.Size = DrawBar.Value;
                }                   
            }
        }
        Brush _selectedBrush;            //выбранная кисть

        public Form2()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
            buttonSelectedColor.BackColor = SelectedColor;
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
        }


        ///<summary>
        ///Создать пустую область рисования
        ///</summary>
        ///<param name="width">Ширина области</param>
        ///<param name="height">Высота области</param>
        void CreateBlank(int width, int height)
        {
            //сохраняем старую картинку
            var oldImage = pictureBox1.Image;
            //создаем новый Bitmap
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //производим попиксельное закрашивание
            //Битмап - обычный двумерный массив точек, поэтому проходим его за два цикла:
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }

            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();     //освобождаем ресурсы, занятые старой картинкой
            }
        }

        private void KvDraw_Click(object sender, EventArgs e) // Квадрат
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

            KvDraw.BackColor = SystemColors.ActiveCaption;

            KrDraw.BackColor = SystemColors.ControlLight;
            Lastic.BackColor = SystemColors.ControlLight;
            SnowflakeButton.BackColor = SystemColors.ControlLight;
            CircleDraw.BackColor = SystemColors.ControlLight;
        }

        private void KrDraw_Click(object sender, EventArgs e) // Перо
        {
            _selectedBrush = new KrBrush(SelectedColor, SelectedSize);

            KrDraw.BackColor = SystemColors.ActiveCaption;

            KvDraw.BackColor = SystemColors.ControlLight;
            Lastic.BackColor = SystemColors.ControlLight;
            SnowflakeButton.BackColor = SystemColors.ControlLight;
            CircleDraw.BackColor = SystemColors.ControlLight;
        }

        private void Lastic_Click(object sender, EventArgs e) // Ластик
        {
            _selectedBrush = new LasticBrush(LasticColor, SelectedSize);

            Lastic.BackColor = SystemColors.ActiveCaption;

            KrDraw.BackColor = SystemColors.ControlLight;
            KvDraw.BackColor = SystemColors.ControlLight;
            SnowflakeButton.BackColor = SystemColors.ControlLight;
            CircleDraw.BackColor = SystemColors.ControlLight;
        }

        private void SnowflakeButton_Click(object sender, EventArgs e) // Снежинка
        {
            _selectedBrush = new SnowflakeBrush(SelectedColor, SelectedSize);

            SnowflakeButton.BackColor = SystemColors.ActiveCaption;

            KrDraw.BackColor = SystemColors.ControlLight;
            KvDraw.BackColor = SystemColors.ControlLight;
            Lastic.BackColor = SystemColors.ControlLight;
            CircleDraw.BackColor = SystemColors.ControlLight;
        }

        private void CircleDraw_Click(object sender, EventArgs e) // Круг
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);

            CircleDraw.BackColor = SystemColors.ActiveCaption;

            KvDraw.BackColor = SystemColors.ControlLight;
            KrDraw.BackColor = SystemColors.ControlLight;
            Lastic.BackColor = SystemColors.ControlLight;
            SnowflakeButton.BackColor = SystemColors.ControlLight;
        }


        ///<summary>
        ///Обработчик события при нажатии кнопки мыши
        ///</summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
            {
                if ( _selectedBrush == null)
                {
                    //кисть не выбрана, выходим
                    return;
                }
                //в противном случае, рисуем точку на поверхности
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
                //фиксируем тот факт, что мышка ещё нажата, для отслеживания
                _mouseClicked = true;
            }
            ///<summary>
            ///Обработчик события при отжатии кнопки мыши
            ///</summary>
             private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
            {
                _mouseClicked = false;
            }
            ///<summary>
            ///Обработчик перемещений мыши
            ///</summary>
            ///<param name="e">Параметры перемещения, в том числе координаты</param>
             private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
            {
                //не даем выйти мыши за границы области, отсекаем отрицательные координаты
                _x = e.X > 0 ? e.X : 0;
                _y = e.Y > 0 ? e.Y : 0;
                if (_mouseClicked)
                {
                    //если мышь зажата, то рисуем
                    _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                    pictureBox1.Refresh();
                }
             }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            buttonSelectedColor.BackColor = Color.Yellow;
            SelectedColor = Color.Yellow;

            if(Lastic.BackColor == SystemColors.ActiveCaption)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            buttonSelectedColor.BackColor = Color.Green;
            SelectedColor = Color.Green;

            if (Lastic.BackColor == SystemColors.ActiveCaption)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            buttonSelectedColor.BackColor = Color.Blue;
            SelectedColor = Color.Blue;

            if (Lastic.BackColor == SystemColors.ActiveCaption)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            buttonSelectedColor.BackColor = Color.Red;
            SelectedColor = Color.Red;

            if (Lastic.BackColor == SystemColors.ActiveCaption)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void buttonChoiceColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedColor = colorDialog1.Color;
            }

            if (Lastic.BackColor == SystemColors.ActiveCaption)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);

                KvDraw.BackColor = SystemColors.ActiveCaption;

                KrDraw.BackColor = SystemColors.ControlLight;
                Lastic.BackColor = SystemColors.ControlLight;
                SnowflakeButton.BackColor = SystemColors.ControlLight;
                CircleDraw.BackColor = SystemColors.ControlLight;
            }
        }

        private void DrawBar_Scroll(object sender, EventArgs e)
        {
            SelectedSize = DrawBar.Value;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreate form = new FormCreate();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
                saveFileDialog1.FileName = form.FileName;
                openFileDialog1.FileName = form.FileName;
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Users\\Pavel\\Pictures";
            openFileDialog1.Filter = "jpg files (*.jpg) | *.jpg |bmp files (*.bmp) | *.bmp |png files (*.png) | *.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FormCreate form = new FormCreate();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Bitmap save = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(save, new Rectangle(0, 0, save.Width, save.Height));

            saveFileDialog1.InitialDirectory = "C:\\Users\\Pavel\\Pictures"; // директория по умолчанию
            saveFileDialog1.Filter = "jpg files (*.jpg) | *.jpg |bmp files (*.bmp) | *.bmp |png files (*.png) | *.png"; // заданные расширения

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1) // .jpg
                {
                    MessageBox.Show("Изображение успешно сохранено в формате .jpg");
                    save.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                }

                if (saveFileDialog1.FilterIndex == 2) // .bmp
                {
                    MessageBox.Show("Изображение успешно сохранено в формате .bmp");
                    save.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                }

                if (saveFileDialog1.FilterIndex == 3) // .png
                {
                    MessageBox.Show("Изображение успешно сохранено в формате .png");
                    save.Save(saveFileDialog1.FileName, ImageFormat.Png);
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // выход из приложения
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo info = new FormInfo();
            info.ShowDialog(); // показывает окно с информацией
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CreateBlank(pictureBox1.Width, pictureBox1.Height); // очищает поле, создает новый лист к прежними размерами
        }
    }   
}
