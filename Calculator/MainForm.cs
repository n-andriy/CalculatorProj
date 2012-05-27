using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private bool _isFirst = true;
        private string _operationType;
        private string _historyText; // action history in format: 2+3=5;3*6=18;
        private string _firstOperand;
        private string _secondOperand;

        public MainForm()
        {
            InitializeComponent();
            DecRadioButton.Checked = true;
        }

        private void DisplayNumber(string number)
        {
            if (_isFirst)
            {
                operandLabel.Text = number;
                _historyText += number;
                _isFirst = false;
                return;
            }

            operandLabel.Text += number;
            _historyText += number;
        }

        private void ChangeOperationType(string type)
        {
            _operationType = type;
            
            // Reading the first operand
            _firstOperand = operandLabel.Text;
            
            operandLabel.Text += String.Format(" {0} ", type);
            _historyText += String.Format(" {0} ", type);
        }

        #region Number and letter buttons click handlers
        private void zeroButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("0");
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("9");
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("A");
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("B");
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("C");
        }

        private void dButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("D");
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("E");
        }

        private void fButton_Click(object sender, EventArgs e)
        {
            DisplayNumber("F");
        }
        #endregion

        private void plusButton_Click(object sender, EventArgs e)
        {
            ChangeOperationType("+");
        }

        private void substractButton_Click(object sender, EventArgs e)
        {
            ChangeOperationType("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            ChangeOperationType("*");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            ChangeOperationType("/");
        }

        private void factButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = MathCalcLibrary.Factorial(int.Parse(operandLabel.Text)).ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "0";
            operandLabel.Text = "0";
            _isFirst = true;
            _historyText = "";
        }

        private void binRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binRadioButton.Checked)
            {
                // Converting resultLabel value to bin
                resultLabel.Text = MathCalcLibrary.ConvertValueToBin(resultLabel.Text);

                MathCalcLibrary.calcMode = CalcMode.BinCalculation;

                twoButton.Enabled = false;
                threeButton.Enabled = false;
                fourButton.Enabled = false;
                fiveButton.Enabled = false;
                sixButton.Enabled = false;
                sevenButton.Enabled = false;
                eightButton.Enabled = false;
                nineButton.Enabled = false;
                factButton.Enabled = false;
                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                eButton.Enabled = false;
                fButton.Enabled = false;
            }
        }

        private void memClearButton_Click(object sender, EventArgs e)
        {
            //_memoryCell = "";
        }

        private void saveMemoryButton_Click(object sender, EventArgs e)
        {
            
        }

        private void lastSymbolButton_Click(object sender, EventArgs e)
        {
            var removeResult = MathCalcLibrary.RemoveLastSymbol(operandLabel.Text);
            if (removeResult != "")
            {
                operandLabel.Text = removeResult;
            }
        }

        private void SetVisibleOfElements()
        {
            twoButton.Enabled = true;
            threeButton.Enabled = true;
            fourButton.Enabled = true;
            fiveButton.Enabled = true;
            sixButton.Enabled = true;
            sevenButton.Enabled = true;
            eightButton.Enabled = true;
            nineButton.Enabled = true;
            factButton.Enabled = true;
        }

        private void DecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DecRadioButton.Checked)
            {
                // Converting resultLabel value to dec
                resultLabel.Text = MathCalcLibrary.ConvertValueToDec(resultLabel.Text);

                MathCalcLibrary.calcMode = CalcMode.DecCalculation;
                SetVisibleOfElements();
                aButton.Enabled = false;
                bButton.Enabled = false;
                cButton.Enabled = false;
                dButton.Enabled = false;
                eButton.Enabled = false;
                fButton.Enabled = false;
            }
        }

        private void HexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HexRadioButton.Checked)
            {
                // Converting resultLabel value to hex
                resultLabel.Text = MathCalcLibrary.ConvertValueToHex(resultLabel.Text);

                MathCalcLibrary.calcMode = CalcMode.HexCalculation;
                SetVisibleOfElements();
                aButton.Enabled = true;
                bButton.Enabled = true;
                cButton.Enabled = true;
                dButton.Enabled = true;
                eButton.Enabled = true;
                fButton.Enabled = true;
            }
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = MathCalcLibrary.GetSqrt(double.Parse(operandLabel.Text)).ToString();
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            // Reading the second operand
            _secondOperand = operandLabel.Text.Substring(operandLabel.Text.LastIndexOf(' ') + 1);
           
            // Choosing operation type
            switch (_operationType)
            {
                case "+":
                    resultLabel.Text = MathCalcLibrary.Sum(_firstOperand, _secondOperand);
                    _historyText += "=" + resultLabel.Text + ";";
                    break;
                
                case "-":
                    resultLabel.Text = MathCalcLibrary.Substract(_firstOperand, _secondOperand);
                    _historyText += "=" + resultLabel.Text + ";";
                    break;
                
                case "/":
                    try
                    {
                        resultLabel.Text = MathCalcLibrary.Dividing(_firstOperand, _secondOperand);
                        _historyText += "=" + resultLabel.Text + ";";
                    }
                    catch(DivideByZeroException)
                    {
                        MessageBox.Show("Attempted divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        operandLabel.Text = "0";
                    }

                    break;
                
                case "*":
                    resultLabel.Text = MathCalcLibrary.Multiplication(_firstOperand, _secondOperand);
                    _historyText += "=" + resultLabel.Text + ";";
                    break;
            }

            _isFirst = true;
        }

        private void inverseDivButton_Click(object sender, EventArgs e)
        {
            try
            {
                resultLabel.Text = MathCalcLibrary.InverseDivide(double.Parse(operandLabel.Text)).ToString();
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Attempted divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                operandLabel.Text = "0";
            }
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HistoryForm(_historyText).ShowDialog();
        }      

        private void romanConvertButton_Click(object sender, EventArgs e)
        {
            // checking an empty value
            if (String.IsNullOrEmpty(initialValueTextBox.Text))
            {
                MessageBox.Show("You must enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initialValueTextBox.Focus();
                return;
            }

            // checking only digits value
            var regex = new Regex("^[0-9]+$");
            if (!regex.IsMatch(initialValueTextBox.Text))
            {
                MessageBox.Show("You must enter only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                initialValueTextBox.Text = "";
                initialValueTextBox.Focus();
                return;
            }

            convertedValueTextBox.Text = MathCalcLibrary.ConvertIntToRoman(int.Parse(initialValueTextBox.Text));
        }

        private void romanClearButton_Click(object sender, EventArgs e)
        {
            initialValueTextBox.Text = "";
            convertedValueTextBox.Text = "";
            initialValueTextBox.Focus();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
    }
}
