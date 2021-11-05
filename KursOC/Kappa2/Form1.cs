using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Kappa2
{
    public partial class Form1 : Form
    {

        int f = 0; // переключатель режима (по умолчанию выключен)

        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelInfo.Show(); // панель с информацией о курсовой работе
            panelAction.Hide(); // скрываем пока панель с действиями

            buttonD.Show(); // кнопка "Далее" пока видна
            buttonOK.Hide(); // а кнопку "ОК" скрываем. Она нужна для панели Action
            buttonBack.Hide(); // кнопку "Назад" тоже пока скрываем

            linkGoogleDrive.Show(); // показываем ссылку
        }

        private void linkGoogleDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/1DJGtoE0g6EEde-togQ-ZNyFUJtuHG03x?usp=sharing");
        }

        private void buttonExit_Click(object sender, EventArgs e) // кнопка "Выход"
        {
            Environment.Exit(0); // закрываем программу
        }

        private void button1_Click(object sender, EventArgs e) // переход к панели Action
        {
            panelAction.Show(); // показываем панель Action
            buttonD.Hide(); // прячем панель с информацией о курсовой
            linkGoogleDrive.Hide(); // прячем ссылку
            buttonOK.Show(); // показываем кнопку "OK"
            buttonBack.Show(); // показываем кнопку "Назад"            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelInfo.Show(); // показываем панель с информацией о курсовой работе
            panelAction.Hide(); // скрываем панель с действиями

            buttonD.Show(); // кнопка "Работа с папкой" видна
            linkGoogleDrive.Show(); // ссылка видна
            buttonOK.Hide(); // кнопку "ОК" скрываем
            buttonBack.Hide(); // кнопку "Назад" скрываем
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            radioRandom.Checked = false; // сбрасываем все radioButton
            radioSort.Checked = false;
            radioBack.Checked = false;

            textBox1.BackColor = Color.Empty; // очищаем поле "Путь"
            textBox1.Text = "";

            f = 0; // возвращаем переключатель в первоначальное положение
        }

        private void radioRandom_CheckedChanged(object sender, EventArgs e) // режим Перемешивания файлов в папке
        {
            RadioButton random = sender as RadioButton; // чтобы окно проводника не выскакивало каждый раз, когда меняется значение в radioRandom, нужно поставить заглушку
            if (random != null)
            {
                if (random.Checked) // только когда radioRandom выбран выполняется действие
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // если выбран данный режим, то открывается окно проводника, где нужно выбрать нужную папку
                    {
                        textBox1.BackColor = Color.LawnGreen; // когда папка выбрана, строка "Путь" меняет цвет на зелёный (всё корректно)
                        textBox1.Text = folderBrowserDialog1.SelectedPath; // и отображает путь к указанной папке



                        if (f == 0 || f == 2 || f == 3) // если никакой их режимов не выбран или выбран другой режим
                        {
                            f = 1; // то переключаем на режим Перемешивания
                        }
                    }

                    else
                    {
                        radioRandom.Checked = false; // сбрасываем все radioButton
                        f = 0; // возвращаем переключатель в первоначальное положение
                    }
                }
            }              
        }

        private void radioSort_CheckedChanged(object sender, EventArgs e) // режим Нумерации файлов в папке
        {
            RadioButton sort = sender as RadioButton;
            if (sort != null)
            {
                if (sort.Checked)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // если выбран данный режим, то открывается окно проводника, где нужно выбрать нужную папку
                    {
                        textBox1.BackColor = Color.LawnGreen; // когда папка выбрана, строка "Путь" меняет цвет на зелёный (всё корректно)
                        textBox1.Text = folderBrowserDialog1.SelectedPath; // и отображает путь к указанной папке

                        if (f == 0 || f == 1 || f == 3) // если никакой их режимов не выбран или выбран другой режим
                        {
                            f = 2; // то переключаем на режим Нумерации
                        }
                    }

                    else
                    {
                        radioSort.Checked = false;
                        f = 0;
                    }
                }
            }           
        }

        private void radioBack_CheckedChanged(object sender, EventArgs e) // режим Возврата первоначальных имён файлов
        {
            RadioButton back = sender as RadioButton;
            if (back != null)
            {
                if (back.Checked)
                {
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) // если выбран данный режим, то открывается окно проводника, где нужно выбрать нужную папку
                    {
                        textBox1.BackColor = Color.LawnGreen; // когда папка выбрана, строка "Путь" меняет цвет на зелёный (всё корректно)
                        textBox1.Text = folderBrowserDialog1.SelectedPath; // и отображает путь к указанной папке

                        if (f == 0 || f == 1 || f == 2) // если никакой их режимов не выбран или выбран другой режим
                        {
                            f = 3; // то переключаем на режим Возврата к исходным значениям
                        }
                    }

                    else
                    {
                        radioBack.Checked = false;
                        f = 0;
                    }
                }
            }          
        }

        private void buttonOK_Click(object sender, EventArgs e) // кнопка ОК, запускающая выбранный режим
        {
            if (textBox1.Text == "") // если в поле "Путь" пусто
            {
                MessageBox.Show("Выберите нужное действие и укажите путь!"); // то выводим предупреждающее сообщение
            }

            else
            {
                if (Directory.Exists(textBox1.Text) == false) // проверяем, существует ли заданная папка
                {
                    MessageBox.Show("Папка не найдена!"); // если нет, то выводим сообщение. Дальнейшие действия с файлами не производятся
                }

                else // если папка найдена, то действуем
                {
                    if (f == 1) // режим Перемешивания файлов
                    {

                        int m = Directory.GetFiles(textBox1.Text).Length; // определяем количество файлов в заданной папке и их имена (с расширением)

                        Random r = new Random(); // включаем режим рандома, чтобы перемешать файлы
                        bool rComplete = false; // переключатель, который определяет, были ли уже перемешаны файлы
                        bool nComplete = false; // переключатель, который определяем, были ли уже пронумерованы файлы                       

                        IEnumerable<FileInfo> filesToRename = Directory.GetFiles(textBox1.Text).Select(f => new FileInfo(f)); // получаем информацию о файлах           

                        if (m == 0) // если файлов в папке нет
                        {
                            MessageBox.Show("Файлы не обнаружены!"); // то выводим сообщение. При этом дальнейшие действия не выполняются
                        }

                        else
                        {
                            if (m > 9999) // если файлов в папке больше 9999
                            {
                                MessageBox.Show("Извините\n" +
                                                "Файлов в заданной папке слишком много (больше 9999).\n" +
                                                "Процесс нумерации невозможен.");
                            }

                            else // иначе выполняем режим Перемешивания
                            {
                                foreach (FileInfo file in filesToRename) // запускаем оператор для работы с файлами
                                {
                                    string newFileFullPath = null; // задаем переменную, которая в дальнейшем будет хранить путь к файлу

                                    string patternSort = @"^\d+. "; // задаем шаблон, по которому будет определяться, пронумерованы ли уже файлы в папке (по режиму Нумерации)

                                    Regex regexSort = new Regex(patternSort);
                                    Match matchSort = regexSort.Match(Path.GetFileNameWithoutExtension(file.Name));

                                    if (matchSort.Success) // если есть совпадения (по режиму Нумерации)
                                    {
                                        nComplete = true; // то меняем значения переключателя, говоря о том, что входящие файлы пронумерованы
                                    }

                                    else
                                    {
                                        string pattern = @"^R\d+. "; // задаем шаблон, по которому будет определяться, перемешаны ли уже файлы в папке

                                        Regex regex = new Regex(pattern);
                                        Match match = regex.Match(Path.GetFileNameWithoutExtension(file.Name)); // проверяем имя файла на совпадение с шаблоном

                                        if (match.Success) // если файлы уже перемешаны
                                        {
                                            rComplete = true; // то ставим переключатель в положение True (перемешивание не требуется)
                                        }

                                        else // иначе, перемешиваем файлы
                                        {
                                            int p = r.Next(1000, 9999); // генерируем рандомные значения
                                            string newFileName = $@"R{p}. {Path.GetFileNameWithoutExtension(file.Name)}{file.Extension}"; // задаем новый шаблон имени файла (само название и расширение файла остается нетронутым. Добавляется только индекс в начале имени файла)
                                            newFileFullPath = Path.Combine(file.DirectoryName, newFileName); // комбинируем путь к файлу
                                            File.Move(file.FullName, newFileFullPath); // переименовываем файл
                                        }
                                    }
                                }

                                if (nComplete == true)
                                {
                                    MessageBox.Show("Файлы пронумерованы.\n" +
                                                    "Чтобы перемешать, верните их в исходное состояние.");
                                }

                                else
                                {
                                    if (rComplete == true) // если переключатель в положении True
                                    {
                                        MessageBox.Show("Файлы уже перемешаны."); // то выводим сообщение. Файлы при этом не перемешиваются заново
                                    }

                                    else // иначе, перемешиваем файлы
                                    {
                                        MessageBox.Show("Готово! Файлы успешно перемешаны."); // и выводим сообщение, что всё Готово
                                    }                                   
                                }
                            }
                        }                       
                    }

                    if (f == 2) // режим Нумерации файлов
                    {
                        int m = Directory.GetFiles(textBox1.Text).Length; // определяем количество файлов в заданной папке
                        double p = 0.000; // переменная для нумерации
                        bool nComplete = false; // переключатель, который определяет, были ли уже пронумерованы файлы
                        bool rComplete = false; // переключатель, который определяет, были ли уже перемешаны файлы                        

                        IEnumerable<FileInfo> filesToRename = Directory.GetFiles(textBox1.Text).Select(f => new FileInfo(f)); // получаем информацию о файлах           

                        if (m == 0) // если файлов в папке нет
                        {
                            MessageBox.Show("Файлы не обнаружены!"); // то выводим сообщение. При этом дальнейшие действия не выполняются
                        }

                        else
                        {
                            if (m > 9999) // если файлов в папке больше 9999, то выводим сообщение
                            {
                                MessageBox.Show("Извините\n" +
                                                "Файлов в заданной папке слишком много (больше 9999).\n" +
                                                "Процесс нумерации невозможен.");
                            }

                            else // иначе, выполняем режим Нумерации
                            {
                                foreach (FileInfo file in filesToRename) // запускаем оператор для работы с файлами
                                {
                                    string newFileFullPath = null; // задаем переменную, которая в дальнейшем будет хранить путь к файлу

                                    string patternRandom = @"^R\d+. "; // задаем шаблон, по которому будет определяться, перемешаны ли уже файлы в папке (по режиму рандома)

                                    Regex regexRandom = new Regex(patternRandom);
                                    Match matchRandom = regexRandom.Match(Path.GetFileNameWithoutExtension(file.Name)); // проверяем имя файла на совпадение с шаблоном (по режиму рандома)

                                    if (matchRandom.Success) // если есть совпадения (по режиму Перемешивания)
                                    {
                                        rComplete = true; // меням значение переключателя, говоря о том, что файлы уже подвергались режиму Перемешивания
                                    }

                                    else
                                    {
                                        string pattern = @"^\d+. "; // задаем шаблон, по которому будет определяться, пронумерованы ли уже файлы в папке

                                        Regex regex = new Regex(pattern);
                                        Match match = regex.Match(Path.GetFileNameWithoutExtension(file.Name)); // проверяем имя файла на совпадение с шаблоном

                                        if (match.Success) // если файлы уже пронумерованы
                                        {
                                            nComplete = true; // то ставим переключатель в положение True (нумерация не требуется)
                                        }

                                        else // иначе, нумеруем файлы
                                        {
                                            p += 0.001;
                                            p = Math.Round(p, 3);
                                       
                                            string q = Convert.ToString(p);

                                            // проверяем полученные значения. Когда разряд числа меняется, к нему в конце приписывается ноль, чтобы нумерация не сбивалась
                                            if (q.Length < 6) // 0.001
                                            {
                                                if (q.Length < 5) // 0.01
                                                {
                                                    if (q.Length < 4) // 0.1
                                                    {
                                                        if (q.Length < 3) // 1
                                                        {
                                                            q += "000";
                                                        }

                                                        else
                                                        {
                                                            q += "00";
                                                            q = q.Remove(1, 1); // убираем ненужную запятую
                                                        }
                                                    }

                                                    else
                                                    {
                                                        q += "0";
                                                        q = q.Remove(1, 1); // убираем ненужную запятую
                                                    }
                                                }

                                                else
                                                {
                                                    q = q.Remove(1, 1); // убираем ненужную запятую
                                                }
                                            }                                           

                                            string newFileName = $@"{q}. {Path.GetFileNameWithoutExtension(file.Name)}{file.Extension}"; // задаем новый шаблон имени файла (само название и расширение файла остается нетронутым. Добавляется только номер в начале имени файла)
                                            newFileFullPath = Path.Combine(file.DirectoryName, newFileName); // комбинируем путь к файлу
                                            File.Move(file.FullName, newFileFullPath); // переименовываем файл
                                        }
                                    }
                                }

                                if (rComplete == true) // если файлы были уже Перемешаны, то выводим сообщение. При этом другие сообщения блокируются
                                {
                                        MessageBox.Show("Файлы перемешаны.\n" +
                                                        "Чтобы пронумеровать, верните их в исходное состояние.");
                                }

                                else
                                {
                                    if (nComplete == true) // если переключатель в положении True
                                    {
                                        MessageBox.Show("Файлы уже пронумерованы."); // то выводим сообщение. Файлы при этом не перемешиваются заново.
                                    }

                                    else // иначе, нумеруем файлы
                                    {
                                            MessageBox.Show("Готово! Файлы успешно пронумерованы."); // и выводим сообщение, что всё Готово
                                    }
                                    
                                }
                            }
                        }                       
                    }

                    if (f == 3) // режим Возврата к исходным именам файлов
                    {
                        int m = Directory.GetFiles(textBox1.Text).Length; // определяем количество файлов в заданной папке
                        int brComplete = 0; // переключатель, который определяет, были ли уже имена файлов возвращены в исходное состояние после Перемешивания
                        int bnComplete = 0; // переключатель, который определяет, были ли уже имена файлов возвращены в исходное состояние после Нумерации

                        IEnumerable<FileInfo> filesToRename = Directory.GetFiles(textBox1.Text).Select(f => new FileInfo(f)); // получаем информацию о файлах

                        if (m == 0) // если файлов в папке нет
                        {
                            MessageBox.Show("Файлы не обнаружены!"); // то выводим сообщение. При этом дальнейшие действия не выполняются
                        }

                        else
                        {
                            if (m > 9999) // если файлов в папке больше 9999, то выводим сообщение
                            {
                                MessageBox.Show("Извините\n" +
                                                "Файлов в заданной папке слишком много (больше 9999).\n" +
                                                "Процесс нумерации невозможен.");
                            }

                            else // иначе, выполняем режим Возврата
                            {
                                foreach (FileInfo file in filesToRename) // запускаем оператор, для работы с файлами
                                {
                                    string newFileFullPath = null; // задаем переменную, которая в дальнейшем будет хранить путь к файлу

                                    string patternRandom = @"^R\d+. "; // задаем шаблон, по которому будет определяться, перемешаны ли уже файлы в папке (по режиму Перемешивания)
                                    string patternSort = @"^\d+. "; // задаем шаблон, по которому будет определяться, пронумерованы ли уже файлы в папке (по режиму Нумерации)

                                    Regex regexRandom = new Regex(patternRandom);
                                    Match matchRandom = regexRandom.Match(Path.GetFileNameWithoutExtension(file.Name)); // проверяем имя файла на совпадение с шаблоном (по режиму Перемешивания)

                                    Regex regexSort = new Regex(patternSort);
                                    Match matchSort = regexSort.Match(Path.GetFileNameWithoutExtension(file.Name));

                                    if (matchRandom.Success) // если есть совпадения (по режиму Перемешивания)
                                    {
                                        string oldName = Path.GetFileNameWithoutExtension(file.Name); // то задаем переменную, содержащую имя файла

                                        string newFileName = $@"{oldName.Remove(0, 7)}{file.Extension}"; // задаем шаблон с новым именем файла, в котором удаляем первые 7 символов (индекс Перемешивания)
                                        newFileFullPath = Path.Combine(file.DirectoryName, newFileName); // комбинируем путь к файлу

                                        File.Move(file.FullName, newFileFullPath); // переименовываем файл
                                    }

                                    else // если совпадений нет (по режиму Перемешивания)
                                    {
                                        brComplete = 1; // то ставим переключатель в положение 1, которое означает, что файлы не подвергались Перемешиванию
                                    }

                                    if (matchSort.Success) // если есть совпадения (по режиму Нумерации)
                                    {
                                        string oldName = Path.GetFileNameWithoutExtension(file.Name); // то задаем переменную, содержащую имя файла

                                        string newFileName = $@"{oldName.Remove(0, 6)}{file.Extension}"; // задаем шаблон с новым именем файла, в котором удаляем первые 6 символов (индекс Нумерации)
                                        newFileFullPath = Path.Combine(file.DirectoryName, newFileName); // комбинируем путь к файлу

                                        File.Move(file.FullName, newFileFullPath); // переименовываем файл
                                    }

                                    else
                                    {
                                        bnComplete = 1; // то ставим переключатель в положение 1, которое означает, что файлы не подвергались Нумерации
                                    }
                                }

                                if (brComplete == 1 && bnComplete == 1) // если оба переключателя в положении 1 (нет совпадений)
                                {
                                    MessageBox.Show("В заданной папке всё нормально. Исправлять нечего."); // то выводим сообщение. При этом никаких действий переименовывания файлов по шаблону не происходит
                                }

                                else // иначе выводим сообщение, что всё Готово. При этом выполняются все действия переименовывания файлов по шаблону
                                {
                                    MessageBox.Show("Готово! Все файлы возвращены в исходное состояние.");
                                }
                            }
                        }                       
                    }
                }

                radioRandom.Checked = false; // сбрасываем все radioButton
                radioSort.Checked = false;
                radioBack.Checked = false;

                textBox1.BackColor = Color.Empty; // очищаем поле "Путь"
                textBox1.Text = "";

                f = 0; // возвращаем переключатель в первоначальное положение
            }           
        }
    }
}