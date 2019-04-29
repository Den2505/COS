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
        protected override void OnPaint(PaintEventArgs e)
        {
            //Перегруженная функция , выполняется каждый раз, когда обновляется форма примерно раз в секунду, поэтому снизу q==0, чтобы выполнилось 1 раз
            base.OnPaint(e);
            if (!_addLabCheck)
            {
                addLabelsToMas();
            }
        }

        private string _operationGF = "addition";
        private List<Label> _labelAddSubMas = new List<Label>();
        private bool _addLabCheck = false;

        private void button1_Click(object sender, EventArgs e)
        {
            byte a = Convert.ToByte(textBoxA.Text);
            byte b = Convert.ToByte(textBoxB.Text);
            if (_operationGF == "addition")
            {
                label3.Text = "a + b = " + Convert.ToString(operationAdd(a, b));
                labelResult.Text = Convert.ToString(operationAdd(a, b));
                //  pictureBox1.Image = Properties.Resources.imgAdd;

                //  disableVisibleSubtractionLables();
                //офф
                enableVisibleAdditionAndSubstractionLables();
                operationAdditionExpand();
            }
            if (_operationGF == "subtraction")
            {
                label3.Text = "a - b = " + Convert.ToString(operationSub(a, b));
                labelResult.Text = Convert.ToString(operationSub(a, b));
                //  pictureBox1.Image = Properties.Resources.imgSub;

                enableVisibleAdditionAndSubstractionLables();
                //  disableVisibleAdditionLables();
                //офф
                //  enableVisibleSubtractionLables();
                operationSubtractionExpand();
            }
            if (_operationGF == "multiplication")
            {

                genExpTable();
                genLogTable();
                labelResult.Text = Convert.ToString(operationMul(a, b));
                label3.Text = "a * b = " + Convert.ToString(operationMul(a, b));
                pictureBox1.Image = null;

                disableVisibleAdditionAndSubstractionLables();
                //   disableVisibleSubtractionLables();
                //фон
            }
            if (_operationGF == "division")
            {
                label3.Text = "a / b =";
                labelResult.Text = null;
                pictureBox1.Image = null;

                disableVisibleAdditionAndSubstractionLables();
                //  disableVisibleSubtractionLables();
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
        private static byte[] _exponentialsT = new byte[256];
        private static byte[] _logarithmsT = new byte[256];
        static int _genPolynomial = 0x11D;
        private static byte mul_table(byte at, byte bt)
        {
            byte resultMul = 0;
            byte temp;
            while (at != 0)
            {
                if ((at & 1) != 0)
                {
                    resultMul = (byte)(resultMul ^ bt);
                }
                temp = (byte)(bt & 0x80);
                bt = (byte)(bt << 1);
                if (temp != 0)
                {
                    bt = (byte)(bt ^ (_genPolynomial & 0xff));
                }
                at = (byte)(at >> 1);
            }
            return resultMul;
        }

        private void genExpTable()
        {
            byte temp = (byte)0x01;
            for (int i = 0; i < 256; i++)
            {
                _exponentialsT[i] = temp;
                temp = mul_table(temp, (byte)0x02);
            }
        }

        private void genLogTable()
        {
            for (int i = 0; i < 255; i++)
            {
                _logarithmsT[_exponentialsT[i]] = (byte)i;
            }
        }
        //

        private static byte operationMul(byte a, byte b)
        {
            byte resMul = 0;
            if ((a != 0) & (b != 0))
            {
                byte temp = (byte)((_logarithmsT[a] + _logarithmsT[b]) % 255);
                resMul = _exponentialsT[temp];
            }
            return resMul;
            //MUL
        }


        private void radioButtonApp_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imgAdd;
            _operationGF = "addition";
            genPolynomialBox.Enabled = false;

            label3.Text = null;
            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imgSub;
            _operationGF = "subtraction";
            genPolynomialBox.Enabled = false;

            label3.Text = null;
            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
        }

        private void radioButtonMul_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            _operationGF = "multiplication";
            genPolynomialBox.Enabled = true;

            label3.Text = null;
            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            _operationGF = "division";
            genPolynomialBox.Enabled = true;

            label3.Text = null;
            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
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
                if (textBoxTemp.Text != "")
                {
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


        private void addLabelsToMas()
        {
            _addLabCheck = true;
            _labelAddSubMas.Add(labelA1);
            _labelAddSubMas.Add(labelA2);
            _labelAddSubMas.Add(labelA3);
            _labelAddSubMas.Add(labelA4);
            _labelAddSubMas.Add(labelA5);
            _labelAddSubMas.Add(labelA6);
            _labelAddSubMas.Add(labelA7);
            _labelAddSubMas.Add(labelA8);
            _labelAddSubMas.Add(labelA9);
            _labelAddSubMas.Add(labelA10);
        }

        //
        private void enableVisibleAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Visible = true;
            }

            //labelA1.Visible = true;
            //labelA2.Visible = true;
            //labelA3.Visible = true;
            //labelA4.Visible = true;
            //labelA5.Visible = true;
            //labelA6.Visible = true;
            //labelA7.Visible = true;
            //labelA8.Visible = true;
            //labelA9.Visible = true;
            //labelA10.Visible = true;
            //
        }
        private void disableVisibleAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Visible = false;
            }

            //labelA1.Visible = false;
            //labelA2.Visible = false;
            //labelA3.Visible = false;
            //labelA4.Visible = false;
            //labelA5.Visible = false;
            //labelA6.Visible = false;
            //labelA7.Visible = false;
            //labelA8.Visible = false;
            //labelA9.Visible = false;
            //labelA10.Visible = false;
            //
        }

        private void clearAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Text = null;
            }
        }

        //private void enableVisibleSubtractionLables()
        //{
        //    labelS1.Visible = true;
        //    labelS2.Visible = true;
        //    labelS3.Visible = true;
        //    labelS4.Visible = true;
        //    labelS5.Visible = true;
        //    labelS6.Visible = true;
        //    labelS7.Visible = true;
        //    labelS8.Visible = true;
        //    labelS9.Visible = true;
        //    labelS10.Visible = true;
        //    //
        //}
        //private void disableVisibleSubtractionLables()
        //{
        //    labelS1.Visible = false;
        //    labelS2.Visible = false;
        //    labelS3.Visible = false;
        //    labelS4.Visible = false;
        //    labelS5.Visible = false;
        //    labelS6.Visible = false;
        //    labelS7.Visible = false;
        //    labelS8.Visible = false;
        //    labelS9.Visible = false;
        //    labelS10.Visible = false;
        //    //
        //}

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

        private void genPolynomial_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (genPolynomialBox.Text)
            {
                case "x^8+x^4+x^3+x^2+1":
                    _genPolynomial = 0x11D;
                    break;
                case "x^8+x^5+x^3+x+1":
                    _genPolynomial = 0x12B;
                    break;
                case "x^8+x^5+x^3+x^2+1":
                    _genPolynomial = 0x12D;
                    break;
                case "x^8+x^6+x^3+x^2+1":
                    _genPolynomial = 0x14D;
                    break;
                case "x^8+x^6+x^4+x^3+x^2+x+1":
                    _genPolynomial = 0x15F;
                    break;
                case "x^8+x^6+x^5+x+1":
                    _genPolynomial = 0x163;
                    break;
                case "x^8+x^6+x^5+x^2+1":
                    _genPolynomial = 0x165;
                    break;
                case "x^8+x^6+x^5+x^3+1":
                    _genPolynomial = 0x169;
                    break;
                case "x^8+x^6+x^5+x^4+1":
                    _genPolynomial = 0x171;
                    break;
                case "x^8+x^7+x^2+x+1":
                    _genPolynomial = 0x187;
                    break;
                case "x^8+x^7+x^3+x^2+1":
                    _genPolynomial = 0x18D;
                    break;
                case "x^8+x^7+x^5+x^3+1":
                    _genPolynomial = 0x1A9;
                    break;
                case "x^8+x^7+x^6+x+1":
                    _genPolynomial = 0x1C3;
                    break;
                case "x^8+x^7+x^6+x^3+x^2+x+1":
                    _genPolynomial = 0x1CF;
                    break;
                case "x^8+x^7+x^6+x^5+x^2+x+1":
                    _genPolynomial = 0x1E7;
                    break;
                case "x^8+x^7+x^6+x^5+x^4+x^2+1":
                    _genPolynomial = 0x1F5;
                    break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelS1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelA4_Click(object sender, EventArgs e)
        {

        }

        private void labelA6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
