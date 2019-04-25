using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galois_fields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte a = Convert.ToByte(textBoxA.Text);
            byte b = Convert.ToByte(textBoxB.Text);
            if (operationGF == "addition")
            {
                label3.Text = "a + b =";
                labelResult.Text = Convert.ToString(operationAdd(a, b));
                pictureBox1.Image = Properties.Resources.imgAdd;
                enableVisibleAdditionLables();
                operationAdditionExpand();
            }
            if (operationGF == "subtraction")
            {
                label3.Text = "a - b =";
                labelResult.Text = Convert.ToString(operationSub(a, b));
                disableVisibleAdditionLables();
                pictureBox1.Image = null;
                // ПОКА ПРОСТО УБИРАЕТ КАРТИНКУ, ЗАМЕНИТЬ НА ДРУГУЮ
            }
            if (operationGF == "multiplication")
            {
                label3.Text = "a * b =";
            }
            if (operationGF == "division")
            {
                label3.Text = "a / b =";
            }
        }

        private static byte operationAdd(byte a, byte b)
        {
            byte resAdd = (byte)(a ^ b);
            return resAdd;
            //ADD
        }

        private static byte operationSub(byte a, byte b)
        {
            byte resAdd = (byte)(a ^ b);
            return resAdd;
            //SUB
        }

        string operationGF = "addition";
        private void radioButtonApp_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "addition";
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "subtraction";
        }

        private void radioButtonMul_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "multiplication";
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "division";
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            checkTextBox_Byte(textBoxA);
            enableButtonOperation();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            checkTextBox_Byte(textBoxB);
            enableButtonOperation();
        }

        private void checkTextBox_Byte(TextBox textBoxTemp)
        {
            if (textBoxTemp.Text.All(char.IsDigit) == false)
            {
                textBoxTemp.Text = "";
            }
            else
            {
                if (textBoxTemp.Text != "") {
                    short bTemp = Convert.ToInt16(textBoxTemp.Text);
                    if ((bTemp < 0) | (bTemp > 255))
                    {
                        textBoxTemp.Text = "";
                    }
                }
            }
        }

        private void enableButtonOperation()
        {
            if ((textBoxA.Text != "") & (textBoxB.Text != ""))
            {
                buttonResult.Enabled = true;
            }
            else
            {
                buttonResult.Enabled = false;
            }
        }

        private void enableVisibleAdditionLables()
        {
            labelA1.Visible = true;
            labelA2.Visible = true;
            labelA3.Visible = true;
            labelA4.Visible = true;
            labelA5.Visible = true;
            labelA6.Visible = true;
            labelA7.Visible = true;
            labelA8.Visible = true;
            labelA9.Visible = true;
            labelA10.Visible = true;
            //
        }
        private void disableVisibleAdditionLables()
        {
            labelA1.Visible = false;
            labelA2.Visible = false;
            labelA3.Visible = false;
            labelA4.Visible = false;
            labelA5.Visible = false;
            labelA6.Visible = false;
            labelA7.Visible = false;
            labelA8.Visible = false;
            labelA9.Visible = false;
            labelA10.Visible = false;
            //
        }

        private void operationAdditionExpand()
        {
            labelA1.Text = textBoxA.Text;
            labelA2.Text = textBoxB.Text;
            labelA3.Text = Convert.ToString(Convert.ToByte(labelA1.Text), 2).PadLeft(8, '0');
            labelA4.Text = Convert.ToString(Convert.ToByte(labelA2.Text), 2).PadLeft(8, '0');
            labelA5.Text = labelA3.Text;
            labelA6.Text = labelA4.Text;
            labelA7.Text = Convert.ToString(Convert.ToByte(labelResult.Text), 2).PadLeft(8, '0');
            labelA8.Text = labelA7.Text;
            labelA9.Text = labelResult.Text;
            labelA10.Text = labelResult.Text;
        }

    }
}
