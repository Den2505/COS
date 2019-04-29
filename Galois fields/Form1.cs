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
                disableVisibleSubtractionLables();
                //офф
                enableVisibleAdditionLables();
                operationAdditionExpand();
            }
            if (operationGF == "subtraction")
            {
                label3.Text = "a - b =";
                labelResult.Text = Convert.ToString(operationSub(a, b));
                pictureBox1.Image = Properties.Resources.imgSub;
                disableVisibleAdditionLables();
                //офф
                enableVisibleSubtractionLables();
                operationSubtractionExpand();
            }
            if (operationGF == "multiplication")
            {
                label3.Text = "a * b =";
                genExpTable();
                genLogTable();
                labelResult.Text = Convert.ToString(operationMul(a, b));
                pictureBox1.Image = null;
                disableVisibleAdditionLables();
                disableVisibleSubtractionLables();
                //фон
            }
            if (operationGF == "division")
            {
                label3.Text = "a / b =";
                labelResult.Text = null;
                pictureBox1.Image = null;
                disableVisibleAdditionLables();
                disableVisibleSubtractionLables();
                //фон
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
            byte resSub = (byte)(a ^ b);
            return resSub;
            //SUB
        }

        //генерация таблиц
        private static byte[] exponentialsT = new byte[256];
        private static byte[] logarithmsT = new byte[256];
        static int genPolynomial = 0x11D;
        private static byte mul_table(byte at, byte bt)
        {
            byte resultMul = 0;
            byte temp;
            while(at != 0){
                if ((at & 1) != 0){
                    resultMul = (byte)(resultMul ^ bt);
                }
                temp = (byte)(bt & 0x80);
                bt = (byte)(bt << 1);
                if (temp != 0){
                    bt = (byte)(bt ^(genPolynomial & 0xff));
                }
                at = (byte)(at >> 1);
            }
            return resultMul;
        }

        private void genExpTable()
        {
            byte temp = (byte)0x01;
            for(int i=0; i < 256; i++)
            {
                exponentialsT[i] = temp;
                temp = mul_table(temp, (byte)0x02);
            }
        }

        private void genLogTable()
        {
            for(int i=0; i < 255; i++)
            {
                logarithmsT[exponentialsT[i]] = (byte)i;
            }
        }
        //

        private static byte operationMul(byte a, byte b)
        {
            byte resMul = 0;
            if((a != 0)&(b != 0)){
                byte temp = (byte)((logarithmsT[a] + logarithmsT[b]) % 255);
                resMul = exponentialsT[temp];
            }
            return resMul;
            //MUL
        }

        string operationGF = "addition";
        private void radioButtonApp_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "addition";
            genPolynomialBox.Enabled = false;
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "subtraction";
            genPolynomialBox.Enabled = false;
        }

        private void radioButtonMul_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "multiplication";
            genPolynomialBox.Enabled = true;
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            operationGF = "division";
            genPolynomialBox.Enabled = true;
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


        //
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

        private void enableVisibleSubtractionLables()
        {
            labelS1.Visible = true;
            labelS2.Visible = true;
            labelS3.Visible = true;
            labelS4.Visible = true;
            labelS5.Visible = true;
            labelS6.Visible = true;
            labelS7.Visible = true;
            labelS8.Visible = true;
            labelS9.Visible = true;
            labelS10.Visible = true;
            //
        }
        private void disableVisibleSubtractionLables()
        {
            labelS1.Visible = false;
            labelS2.Visible = false;
            labelS3.Visible = false;
            labelS4.Visible = false;
            labelS5.Visible = false;
            labelS6.Visible = false;
            labelS7.Visible = false;
            labelS8.Visible = false;
            labelS9.Visible = false;
            labelS10.Visible = false;
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

        private void operationSubtractionExpand()
        {
            labelS1.Text = textBoxA.Text;
            labelS2.Text = textBoxB.Text;
            labelS3.Text = Convert.ToString(Convert.ToByte(labelS1.Text), 2).PadLeft(8, '0');
            labelS4.Text = Convert.ToString(Convert.ToByte(labelS2.Text), 2).PadLeft(8, '0');
            labelS5.Text = labelS3.Text;
            labelS6.Text = labelS4.Text;
            labelS7.Text = Convert.ToString(Convert.ToByte(labelResult.Text), 2).PadLeft(8, '0');
            labelS8.Text = labelS7.Text;
            labelS9.Text = labelResult.Text;
            labelS10.Text = labelResult.Text;
        }

        private void genPolynomial_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genPolynomialBox.Text)
            {
                case "x^8+x^4+x^3+x^2+1":
                    genPolynomial = 0x11D;
                    break;
                case "x^8+x^5+x^3+x+1":
                    genPolynomial = 0x12B;
                    break;
                case "x^8+x^5+x^3+x^2+1":
                    genPolynomial = 0x12D;
                    break;
                case "x^8+x^6+x^3+x^2+1":
                    genPolynomial = 0x14D;
                    break;
                case "x^8+x^6+x^4+x^3+x^2+x+1":
                    genPolynomial = 0x15F;
                    break;
                case "x^8+x^6+x^5+x+1":
                    genPolynomial = 0x163;
                    break;
                case "x^8+x^6+x^5+x^2+1":
                    genPolynomial = 0x165;
                    break;
                case "x^8+x^6+x^5+x^3+1":
                    genPolynomial = 0x169;
                    break;
                case "x^8+x^6+x^5+x^4+1":
                    genPolynomial = 0x171;
                    break;
                case "x^8+x^7+x^2+x+1":
                    genPolynomial = 0x187;
                    break;
                case "x^8+x^7+x^3+x^2+1":
                    genPolynomial = 0x18D;
                    break;
                case "x^8+x^7+x^5+x^3+1":
                    genPolynomial = 0x1A9;
                    break;
                case "x^8+x^7+x^6+x+1":
                    genPolynomial = 0x1C3;
                    break;
                case "x^8+x^7+x^6+x^3+x^2+x+1":
                    genPolynomial = 0x1CF;
                    break;
                case "x^8+x^7+x^6+x^5+x^2+x+1":
                    genPolynomial = 0x1E7;
                    break;
                case "x^8+x^7+x^6+x^5+x^4+x^2+1":
                    genPolynomial = 0x1F5;
                    break;
            }
        }
    }
}
