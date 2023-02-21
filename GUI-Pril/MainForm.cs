using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Pril
{/*Работу выполнили Миронов и Звягин*/
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /*Запрет на ввод всех символов кроме цифр*/
        private void RowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        /*Инициализация заполнения массива*/
        private void InizialButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (RandomСheck.Checked == true)
            {
                arrayGrid.Columns.Clear();
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    arrayGrid.Columns.Add(j.ToString(), j.ToString());
                }
                for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
                {
                    arrayGrid.Rows.Add();
                }

                Random random = new Random();
                for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
                {
                    for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                    {

                        arrayGrid.Rows[i].Cells[j].Value = random.Next(0, 100);
                    }
                }
            }
            else
            {
                arrayGrid.Columns.Clear();
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    arrayGrid.Columns.Add(j.ToString(), j.ToString());
                }
                for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
                {
                    arrayGrid.Rows.Add();
                }
                for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
                {
                    for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                    {

                        arrayGrid.Rows[i].Cells[j].Value = " ";
                    }
                }
            }
            
        }
        /*Нахождение максимального значения массива*/
        private void MaxButton_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
            {
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    if (max < Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value))
                    {
                        max = Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value);
                    }
                }

            }
            MaxVulueTextBox.Text = Convert.ToString(max);
        }
        /*Нахождение минимального значения массива*/
        private void MinButton_Click(object sender, EventArgs e)
        {
            int min = int.MaxValue;
            for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
            {
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    if (min > Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value))
                    {
                        min = Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value);
                    }
                }

            }
            MinVulueTextBox.Text = Convert.ToString(min);
        }
        /*Нахождение среднего арифметического значения массива*/
        private void MidButton_MouseClick(object sender, MouseEventArgs e)
        {
            int mid = 0;
            for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
            {
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    mid += Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value);
                }
            }
            mid /= Convert.ToInt32((RowsTextBox.Text)) + Convert.ToInt32((ColumnsTextBox.Text));
            MidleVulueTextBox.Text = Convert.ToString(mid);
        }
        /*Нахождение суммы элементов массива*/
        private void SumButton_MouseClick(object sender, MouseEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < int.Parse(RowsTextBox.Text); i++)
            {
                for (int j = 0; j < int.Parse(ColumnsTextBox.Text); j++)
                {
                    sum += Convert.ToInt32(arrayGrid.Rows[i].Cells[j].Value);
                }
            }
            SumVulueTextBox.Text = Convert.ToString(sum);
        }
        /*Переключение текста массива на голубой*/
        private void BlurBGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BlurBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Blue;
            }
        }
        /*Переключение текста массива на зеленый*/
        private void GreenBGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Green;
            }
        }
        /*Переключение текста массива на черный*/
        private void BlackBGRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BlackBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        /*Переключение текста массива на белый*/
        private void WhiteBGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WhiteBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.White;
            }
        }
        /*Изменение фона массива на чёрный*/
        private void BGColorBlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BGColorBlackRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.BackColor = Color.Black;
            }
        }
        /*Изменение фона массива на серый*/
        private void BGColorGreyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BGColorGreyRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.BackColor = Color.Gray;
            }
        }
        /*Изменение фона массива на белый*/
        private void BGColorWhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BGColorWhiteRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.BackColor = Color.White;
            }
        }
        /*Изменение темы интерфейса массива не работает*/
        private void DarkRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DarkRadioButton.Checked)
            {
                this.InsertTabControl.ForeColor = Color.White;
                this.SettingColoreTextArray.ForeColor = Color.White;
                this.BgColor.ForeColor = Color.White;
                this.Interface.ForeColor = Color.White;
                this.FirstTabPage.BackColor = Color.Black;
                this.SecondTabPage.BackColor = Color.Black;
                this.SettingPage.BackColor = Color.Black;
                this.CreatorPage.BackColor = Color.Black;
            }
        }

        private void WhiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.InsertTabControl.ForeColor = Color.Black;
            this.SettingColoreTextArray.ForeColor = Color.Black;
            this.BgColor.ForeColor = Color.Black;
            this.Interface.ForeColor = Color.Black;
            this.FirstTabPage.BackColor = Color.White;
            this.SecondTabPage.BackColor = Color.White;
            this.SettingPage.BackColor = Color.White;
            this.CreatorPage.BackColor = Color.White;
        }
    }
}
