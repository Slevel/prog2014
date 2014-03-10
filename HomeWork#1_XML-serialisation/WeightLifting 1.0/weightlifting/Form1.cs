using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using DevExpress.XtraReports.UI;

namespace weightlifting{
    public partial class Form1 : Form    {
        public Form1()        {
            InitializeComponent();
        }

        // Добавление item'a в listbox
        public void add_button_Click(object sender, EventArgs e)        {
            if (textBox_fname.TextLength < 2 || textBox_lname.TextLength < 2)            {  // Имя и Фамилию ввести придётся однозначно
                var res = MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }

            var athlete = new Athlete            {
                first_name = textBox_fname.Text,
                last_name = textBox_lname.Text,
                country = textBox_country.Text,
                bWeight = (int)numericUpDown_bWeight.Value,
                snatch = (int)numericUpDown_snatch.Value,
                clean_jerk = (int)numericUpDown_clean_jerk.Value,
            };

            // Подсчёт результата
            athlete.summary_res = athlete.snatch + athlete.clean_jerk;
            
            // Проверяем пол
            if (radioButton_gmen.Checked)
                athlete.gender = "Муж.";
            else
                athlete.gender = "Жен.";

            // Заносим всё в listbox
            listBox_output.Items.Add(athlete);

            // Зануляемся
            textBox_fname.Text = null;
            textBox_lname.Text = null;
            textBox_country.Text = null;
            numericUpDown_snatch.Value = 0;
            numericUpDown_clean_jerk.Value = 0;
            numericUpDown_bWeight.Value = 65;
        }

        // Удаление одной записи listbox'a
        private void del_button_Click(object sender, EventArgs e)        {
            listBox_output.Items.Remove(listBox_output.SelectedItem);
        }

        // Очистка listbox'a
        private void clear_button_Click(object sender, EventArgs e)        {
            listBox_output.Items.Clear();
        }

        // Открываем файл
        private void openToolStripMenuItem_Click(object sender, EventArgs e)        {
            OpenFileDialog open = new OpenFileDialog() { Filter = "Протокол соревнований|*.xml" };
            var result = open.ShowDialog(this);
            if (result == DialogResult.OK)            {
                if (listBox_output.Items.Count > 1)                {
                    var res = MessageBox.Show("Вы уверены что хотите продолжить? Введённые ранее данные будут утеряны!", "Предупреждение", MessageBoxButtons.YesNo);
                    if (res != DialogResult.Yes)
                        return;
                }
                var xser = new XmlSerializer(typeof(weightlift));
                var file = File.Open(open.FileName, FileMode.Open);
                var l_ath = (weightlift)xser.Deserialize(file);
                file.Close();
                listBox_output.Items.Clear();
                foreach (var Athlete in l_ath.Athletes)     {
                    listBox_output.Items.Add(Athlete);
                }
            }
        }

        // Сохраняемся
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Протокол соревнований|*.xml" };
            var result = save.ShowDialog(this);
            if (result == DialogResult.OK)      {
                var fileName = save.FileName;
                var wl = CreateAthleteItem();
                XmlSerializer xser = new XmlSerializer(typeof(weightlift));
                var fileStream = File.Create(fileName);
                xser.Serialize(fileStream, wl);
                fileStream.Close();
            }
        }
        // Создание экземпляра класса weightlift
        private weightlift CreateAthleteItem()        {
            weightlift wl = new weightlift();
            wl.Athletes = new List<Athlete>();
            foreach (Athlete ath in listBox_output.Items)            {
                wl.Athletes.Add(ath);
            }
            return wl;
        }

        // Выход по Ctrl+Q / MenuItem
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)        {
            var res = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)            {
                Environment.Exit(0);
            }
            else return;
        }

        // О программе
        private void copyrightsToolStripMenuItem_Click(object sender, EventArgs e)        {
            about aboutForm = new about();
            aboutForm.ShowDialog();
        }

        // Подсчёт суммы
        private void numericUpDown_snatch_ValueChanged(object sender, EventArgs e)        {
            int sum = (int)numericUpDown_clean_jerk.Value + (int)numericUpDown_snatch.Value;
            label_summ.Text = sum.ToString();
        }

        // Подсчёт суммы
        private void numericUpDown_clean_jerk_ValueChanged(object sender, EventArgs e)        {
            int sum = (int)numericUpDown_clean_jerk.Value + (int)numericUpDown_snatch.Value;
            label_summ.Text = sum.ToString();
        }

        // Справка
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)        {
            MessageBox.Show("Справка находится в разработке!", "Внимание", MessageBoxButtons.OK);
        }

        // Отчёт
        private void report_button_Click(object sender, EventArgs e)        {
            var wr = new WL_report();
            weightlift wl = CreateAthleteItem();
            wr.DataSource = new BindingSource() {DataSource = wl};
            wr.ShowPreview();
        }
    }
}