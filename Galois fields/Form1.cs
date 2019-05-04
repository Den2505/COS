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
                addLabelsToMasAS();
                addLabelsToMasM();
                genPolynomialBox.SelectedIndex = 0;
            }
        }

        private string _operationGF = "addition";
        private List<Label> _labelAddSubMas = new List<Label>();
        private List<Label> _labelMulMas = new List<Label>();
        private bool _addLabCheck = false;
        private byte _resultOperation;

        private void button1_Click(object sender, EventArgs e)
        {
            byte a = Convert.ToByte(textBoxA.Text);
            byte b = Convert.ToByte(textBoxB.Text);
            if (_operationGF == "addition")
            {
                labelResult.Text = "a + b = " + Convert.ToString(operationAdd(a, b));
                _resultOperation = operationAdd(a, b);

                //офф
                enableVisibleAdditionAndSubstractionLables();
                operationAdditionAndSubstractionExpand();
            }
            if (_operationGF == "subtraction")
            {
                labelResult.Text = "a - b = " + Convert.ToString(operationSub(a, b));
                _resultOperation = operationSub(a, b);

                //офф
                enableVisibleAdditionAndSubstractionLables();
                operationAdditionAndSubstractionExpand();
            }
            if (_operationGF == "multiplication")
            {
                genExpTable();
                genLogTable();
                labelResult.Text = "a * b = " + Convert.ToString(operationMul(a, b));
                _resultOperation = operationMul(a, b);

                //офф
                enableVisibleMultiplicationLables();
                operationMultiplicationExpand();

            }
            if (_operationGF == "division")
            {
                genExpTable();
                genLogTable();
                labelResult.Text = "a / b = " + Convert.ToString(operationDiv(a, b));

                //офф

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

        private static byte operationDiv(byte a, byte b)
        {
            byte resDiv = 0;
            if (b != 0)
            {
                byte temp = (byte)((255 + _logarithmsT[a] - _logarithmsT[b]) % 255);
                resDiv = _exponentialsT[temp];
            }
            return resDiv;
            //DIV
        }

        private void radioButtonApp_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imgAdd;
            _operationGF = "addition";
            genPolynomialBox.Enabled = false;

            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
            disableVisibleMultiplicationLables();
        }

        private void radioButtonSub_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imgSub;
            _operationGF = "subtraction";
            genPolynomialBox.Enabled = false;

            labelResult.Text = null;
            clearAdditionAndSubstractionLables();
            disableVisibleMultiplicationLables();
        }

        private void radioButtonMul_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.imgMul;
            _operationGF = "multiplication";
            genPolynomialBox.Enabled = true;

            labelResult.Text = null;
            disableVisibleAdditionAndSubstractionLables();
        }

        private void radioButtonDiv_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            _operationGF = "division";
            genPolynomialBox.Enabled = true;

            labelResult.Text = null;
            disableVisibleAdditionAndSubstractionLables();
            disableVisibleMultiplicationLables();
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


        private void addLabelsToMasAS()
        {
            _addLabCheck = true;
            _labelAddSubMas.Add(labelAS1);
            _labelAddSubMas.Add(labelAS2);
            _labelAddSubMas.Add(labelAS3);
            _labelAddSubMas.Add(labelAS4);
            _labelAddSubMas.Add(labelAS5);
            _labelAddSubMas.Add(labelAS6);
            _labelAddSubMas.Add(labelAS7);
            _labelAddSubMas.Add(labelAS8);
            _labelAddSubMas.Add(labelAS9);
            _labelAddSubMas.Add(labelAS10);
        }

        private void addLabelsToMasM()
        {
            _addLabCheck = true;
            _labelMulMas.Add(labelM1);
            _labelMulMas.Add(labelM2);
            _labelMulMas.Add(labelM3);
            _labelMulMas.Add(labelM4);
        }


        //
        private void enableVisibleAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Visible = true;
            }
        }
        private void disableVisibleAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Visible = false;
            }
        }
        private void clearAdditionAndSubstractionLables()
        {
            foreach (Label iLabel in _labelAddSubMas)
            {
                iLabel.Text = null;
            }
        }
        //
        //
        private void enableVisibleMultiplicationLables()
        {
            foreach (Label iLabel in _labelMulMas)
            {
                iLabel.Visible = true;
            }
        }
        private void disableVisibleMultiplicationLables()
        {
            foreach (Label iLabel in _labelMulMas)
            {
                iLabel.Visible = false;
            }
        }
        //

        private void operationAdditionAndSubstractionExpand()
        {
            labelAS1.Text = textBoxA.Text;
            labelAS2.Text = textBoxB.Text;
            labelAS3.Text = Convert.ToString(Convert.ToByte(labelAS1.Text), 2).PadLeft(8, '0');
            labelAS4.Text = Convert.ToString(Convert.ToByte(labelAS2.Text), 2).PadLeft(8, '0');
            labelAS5.Text = labelAS3.Text;
            labelAS6.Text = labelAS4.Text;
            labelAS7.Text = Convert.ToString(_resultOperation, 2).PadLeft(8, '0');
            labelAS8.Text = labelAS7.Text;
            labelAS9.Text = Convert.ToString(_resultOperation);
            labelAS10.Text = Convert.ToString(_resultOperation);
        }

        ///!!!
        private void operationMultiplicationExpand()
        {
            labelM1.Text = textBoxA.Text + " = " + Convert.ToString(integerToPolynomial(Convert.ToByte(textBoxA.Text)));
            labelM2.Text = textBoxB.Text + " = " + Convert.ToString(integerToPolynomial(Convert.ToByte(textBoxB.Text)));
            labelM3.Text = Convert.ToString(integerToPolynomial(Convert.ToByte(textBoxA.Text)) * integerToPolynomial(Convert.ToByte(textBoxB.Text)));
            labelM4.Text = Convert.ToString((new Polynomial()).polynomialReductionFunction(integerToPolynomial(Convert.ToByte(textBoxA.Text)) * integerToPolynomial(Convert.ToByte(textBoxB.Text))));
        }

        private static Polynomial integerToPolynomial(int a)
        {
            string strTemp = Convert.ToString(a, 2);
            var resPol = new double[strTemp.Length];
            for (int i = 0; i < strTemp.Length; i++)
            {
                resPol[i] = Convert.ToByte(strTemp[i] - '0');
            }
            return new Polynomial(resPol);

        }
        ///!!!


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
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal class Polynomial
        {

            public readonly double[] _coefficients;
            private static Polynomial _tempPol;

            public Polynomial(params double[] coefficients)
            {
                _coefficients = coefficients;
            }

            public double this[int n]
            {
                get { return _coefficients[n]; }
                set { _coefficients[n] = value; }
            }

            public int Order
            {
                get { return _coefficients.Length; }
            }

            public override string ToString()
            {
                string resPol = "";
                for (int i = 0; i < _coefficients.Length; i++)
                {
                    if (_coefficients[i] == 1)
                    {
                        resPol += "x^" + Convert.ToString(_coefficients.Length - 1 - i) + "+";
                    }
                    if ((_coefficients[i] != 1) & (_coefficients[i] != 0) & (_coefficients[i] > 0))
                    {
                        resPol += _coefficients[i] + "x^" + Convert.ToString(_coefficients.Length - 1 - i) + "+";
                    }
                }
                resPol = resPol.Remove(resPol.Length - 1);
                resPol = resPol.Replace("x^0", "1");
                // resPol = resPol.Replace("x^1", "x");
                return resPol;
            }

            public double Calculate(double x)
            {
                int n = _coefficients.Length - 1;
                double result = _coefficients[n];
                for (int i = n - 1; i >= 0; i--)
                {
                    result = x * result + _coefficients[i];
                }
                return result;
            }

            public static Polynomial operator +(Polynomial pFirst, Polynomial pSecond)
            {
                int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
                var result = new double[itemsCount];
                for (int i = 0; i < itemsCount; i++)
                {
                    double a = 0;
                    double b = 0;
                    if (i < pFirst._coefficients.Length)
                    {
                        a = pFirst[i];
                    }
                    if (i < pSecond._coefficients.Length)
                    {
                        b = pSecond[i];
                    }
                    result[i] = a + b;
                }
                return new Polynomial(result);
            }

            public static Polynomial operator -(Polynomial pFirst, Polynomial pSecond)
            {
                int itemsCount = Math.Max(pFirst._coefficients.Length, pSecond._coefficients.Length);
                var result = new double[itemsCount];
                for (int i = 0; i < itemsCount; i++)
                {
                    double a = 0;
                    double b = 0;
                    if (i < pFirst._coefficients.Length)
                    {
                        a = pFirst[i];
                    }
                    if (i < pSecond._coefficients.Length)
                    {
                        b = pSecond[i];
                    }
                    result[i] = a - b;
                }
                return new Polynomial(result);
            }

            public static Polynomial operator *(Polynomial pFirst, Polynomial pSecond)
            {
                int itemsCount = pFirst._coefficients.Length + pSecond._coefficients.Length - 1;
                var result = new double[itemsCount];
                for (int i = 0; i < pFirst._coefficients.Length; i++)
                {
                    for (int j = 0; j < pSecond._coefficients.Length; j++)
                    {
                        result[i + j] += pFirst[i] * pSecond[j];
                    }
                }

                _tempPol = new Polynomial(result);
                return new Polynomial(result);
            }


            public Polynomial polynomialReductionFunction(Polynomial unreducedPolynomial)
            {
                double[] tempCoef = new double[unreducedPolynomial._coefficients.Length];
                for (int i = 0; i < unreducedPolynomial._coefficients.Length; i++)
                {
                    tempCoef[i] = unreducedPolynomial[i];
                }

                for (int i = 0; i < tempCoef.Length; i++)
                {
                    if ((tempCoef[i] != 1) && (tempCoef[i] != 0) && (tempCoef[i] % 2 == 1))
                    {
                        tempCoef[i] = 1;
                    }
                    else if ((tempCoef[i] != 1) && (tempCoef[i] != 0) && (tempCoef[i] % 2 == 0))
                    {
                        tempCoef[i] = 0;
                    }
                }

                Polynomial resReductPol = new Polynomial(tempCoef);
                return resReductPol;
            }

        }
    }
}
