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
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RowsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
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

        private void MaxVulueTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

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

        private void BlurBGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BlurBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Blue;
            }
        }

        private void GreenBGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GreenBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Green;
            }
        }

        private void BlackBGRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (BlackBGRadioButton.Checked)
            {
                this.arrayGrid.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
