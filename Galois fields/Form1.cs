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
                labelResult.Text = Convert.ToString(operationAdd(a, b));
            }
            if (operationGF == "subtraction")
            {
                labelResult.Text = Convert.ToString(operationSub(a, b));
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
            label3.Text = "a + b =";
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "subtraction";
            label3.Text = "a - b =";
        }

        private void radioButtonMul_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "multiplication";
            label3.Text = "a * b =";
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "division";
            label3.Text = "a / b =";
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

    }
}
