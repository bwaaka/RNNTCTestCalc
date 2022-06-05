using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using FTPMGCalc;
using Newtonsoft.Json;
using System.Drawing;

namespace RNtestCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string pattern = @"^-?([0-9]\d*(\.\d+)?)$";
        string groundType;
        string saltType;
        int dsal = Int16.MinValue;
        double itot = Double.MinValue;
        double wtot = Double.MinValue;
        double wm = Double.MinValue;
        BindingList<FTPMGData> Lc = new BindingList<FTPMGData>();

        private void Inicalize()
        {
            comboBoxTG.SelectedIndex = 1;
            comboBoxZG.SelectedIndex = 1;
            numericUpDown1.Value = 0;
            dsal = (int)numericUpDown1.Value;
            textBoxItot.Text = "0";
            textBoxWm.Text = "0";
            textBoxWtot.Text = "0";
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            AddData();
        }
        private void toolStripButtonCalculate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            AddData();
        }
        private void AddData()
        {
            try
            {
                Lc.Add(new FTPMGData(groundType, saltType, dsal, itot, wtot, wm));
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            RefreshDS();
            //Inicalize();
        }

        private void RefreshDS()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = Lc;
            dataGridView.Columns[7].DefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);
        }

        private void comboBoxTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            groundType = comboBoxTG.SelectedItem.ToString();
        }

        private void comboBoxZG_SelectedIndexChanged(object sender, EventArgs e)
        {
            saltType = comboBoxZG.SelectedItem.ToString();
        }


        #region validation
        private bool ValidateInput()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                return true;
            }
            return false;
        }

        private void textBoxItot_Validating(object sender, CancelEventArgs e)
        {
            string input = textBoxItot.Text.Replace(',', '.');
            if (string.IsNullOrWhiteSpace(textBoxItot.Text))
            {
                e.Cancel = true;
                textBoxItot.Focus();
                errorProvider.SetError(textBoxItot, "Степень засоленности должна быть определена");
            }
            if (!Regex.IsMatch(input, pattern))
            {
                e.Cancel = true;
                textBoxItot.Focus();
                errorProvider.SetError(textBoxItot, "Степень засоленности должна быть число");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxItot, "");
            }
        }

        private void textBoxItot_Validated(object sender, EventArgs e)
        {
            string input = textBoxItot.Text.Replace('.', ',');
            itot = Convert.ToDouble(input);
        }

        private void textBoxWtot_Validating(object sender, CancelEventArgs e)
        {
            string input = textBoxWtot.Text.Replace(',', '.');
            if (string.IsNullOrWhiteSpace(textBoxWtot.Text))
            {
                e.Cancel = true;
                textBoxWtot.Focus();
                errorProvider.SetError(textBoxWtot, "Степень засоленности должна быть определена");
            }
            if (!Regex.IsMatch(input, pattern))
            {
                e.Cancel = true;
                textBoxWtot.Focus();
                errorProvider.SetError(textBoxWtot, "Степень засоленности должна быть число");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxWtot, "");
            }
        }

        private void textBoxWtot_Validated(object sender, EventArgs e)
        {
            string input = textBoxWtot.Text.Replace('.', ',');
            wtot = Convert.ToDouble(input);
        }

        private void textBoxWm_Validating(object sender, CancelEventArgs e)
        {
            string input = textBoxWm.Text.Replace(',', '.');
            if (string.IsNullOrWhiteSpace(textBoxWm.Text))
            {
                e.Cancel = true;
                textBoxWm.Focus();
                errorProvider.SetError(textBoxWm, "Степень засоленности должна быть определена");
            }
            if (!Regex.IsMatch(input, pattern))
            {
                e.Cancel = true;
                textBoxWm.Focus();
                errorProvider.SetError(textBoxWm, "Степень засоленности должна быть число");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxWm, "");
            }
        }

        private void textBoxWm_Validated(object sender, EventArgs e)
        {
            string input = textBoxWm.Text.Replace('.', ',');
            wm = Convert.ToDouble(input);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicalize();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dsal = (int)numericUpDown1.Value;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            groundType = comboBoxTG.SelectedItem.ToString();
            saltType = comboBoxZG.SelectedItem.ToString();
            dsal = (int)numericUpDown1.Value;
            //т.к. настроена валидация проверку впринципе можно и не делать,
            try
            {
                itot = Convert.ToDouble(textBoxItot.Text.Replace('.', ','));
            } catch
            {
                itot = 0;
            }
            try
            {
                wtot = Convert.ToDouble(textBoxWtot.Text.Replace('.', ','));
            }
            catch
            {
                wtot = 0;
            }
            try
            {
                wm = Convert.ToDouble(textBoxWm.Text.Replace('.', ','));
            }
            catch
            {
                wm = 0;
            }
            GData data = new GData(groundType, saltType, dsal, itot, wtot, wm);
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                        sw.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
                }
                catch (Exception e)
                {
                    LogWrite(e.Message);
                    MessageBox.Show(@"Во время выгрузки данных произошла ошибка
                                    /r/n Доп. информация отправлена в лог-файл");
                }
            }
        }

        private void toolStripButtonLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileStream = openFileDialog1.OpenFile();
                    string json = string.Empty;
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        json = reader.ReadToEnd().ToString();
                    }
                    GData lc = JsonConvert.DeserializeObject<GData>(json);
                    comboBoxTG.SelectedIndex = comboBoxTG.FindString(lc.Type);
                    comboBoxZG.SelectedIndex = comboBoxZG.FindString(lc.Salt);
                    numericUpDown1.Value = lc.Dsal;
                    textBoxItot.Text = lc.Itot.ToString();
                    textBoxWtot.Text = lc.Wtot.ToString();
                    textBoxWm.Text = lc.Wm.ToString();

                } catch (Exception e)
                {
                    LogWrite(e.Message);
                    MessageBox.Show("Файл не загружен. \r\n Доп. информация отправлена в лог-файл");
                }
            }
            RefreshDS();
        }

        private void ExportResult()
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                        sw.Write(JsonConvert.SerializeObject(Lc, Formatting.Indented));
                }
                catch (Exception e)
                {
                    LogWrite(e.Message);
                    MessageBox.Show(@"Во время выгрузки данных произошла ошибка
                                      \r\n Доп. информация отправлена в лог-файл");
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Часы:Минуты:Секунды (число месяц_прописью год).
            labelTime.Text = DateTime.Now.ToString("hh:mm:ss (dd MMMM yyyy)");
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportResult();
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            ExportResult();
        }

        public void LogWrite(string logMessage)
        {
            try
            {
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                using (StreamWriter w = File.AppendText(exePath + "\\" + "log.txt"))
                {
                    Log(logMessage, w);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не возможно записать лог в файл " + ex.Message);
            }
        }

        public void Log(string logMessage, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nLog Entry : ");
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  :{0}", logMessage);
                txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не возможно обработать сообщение об ошибке " + ex.Message);
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
               string groundType = (string)dataGridView.CurrentRow.Cells[0].Value;
               string saltType = (string)dataGridView.CurrentRow.Cells[1].Value;
               int dsal = (int)dataGridView.CurrentRow.Cells[2].Value;
               double itot = (double)dataGridView.CurrentRow.Cells[3].Value;
               double wtot = (double)dataGridView.CurrentRow.Cells[4].Value;
               double wm = (double)dataGridView.CurrentRow.Cells[5].Value;
               FTPMGData tmp = new FTPMGData(groundType, saltType, dsal, itot, wtot, wm);
                if (Lc.Contains(tmp))
                    Lc.Remove(tmp);
             }
        }
    }
}
