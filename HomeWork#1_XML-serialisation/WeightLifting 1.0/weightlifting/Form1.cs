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

namespace weightlifting{
    public partial class Form1 : Form    {
        public Form1()        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)        {
            if (textBox_fname.TextLength < 2 || textBox_lname.TextLength < 2)            {
                var res = MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            var athletes = new Athletes            {
                first_name = textBox_fname.Text,
                last_name = textBox_lname.Text,
                country = textBox_country.Text,
                snatch = (int)numericUpDown_snatch.Value,
                clean_jerk = (int)numericUpDown_clean_jerk.Value,
            };

            athletes.summary_res = athletes.snatch + athletes.clean_jerk;

            if (radioButton_gmen.Checked)
                athletes.gender = "Муж.";
            else
                athletes.gender = "Жен.";

            listBox_output.Items.Add(athletes);

            textBox_fname.Text = null;
            textBox_lname.Text = null;
            textBox_country.Text = null;
            numericUpDown_snatch.Value = 0;
            numericUpDown_clean_jerk.Value = 0;
        }

        private void del_button_Click(object sender, EventArgs e)        {
            listBox_output.Items.Remove(listBox_output.SelectedItem);
        }

        private void clear_button_Click(object sender, EventArgs e)        {
            listBox_output.Items.Clear();
        }

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
                foreach (var Athletes in l_ath.Athlete)     {
                    listBox_output.Items.Add(Athletes);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)        {
            SaveFileDialog save = new SaveFileDialog() { Filter = "Протокол соревнований|*.xml" };
            var result = save.ShowDialog(this);
            if (result == DialogResult.OK)      {
                var fileName = save.FileName;
                weightlift wl = new weightlift();
                wl.Athlete = new List<Athletes>();
                foreach (Athletes ath in listBox_output.Items)     {
                    wl.Athlete.Add(ath);
                }
                XmlSerializer xser = new XmlSerializer(typeof(weightlift));
                var fileStream = File.Create(fileName);
                xser.Serialize(fileStream, wl);
                fileStream.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)        {
            var res = MessageBox.Show("Вы уверены что хотите выйти?", "Выход", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else return;
        }
    }
}
