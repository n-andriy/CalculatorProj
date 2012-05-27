using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private bool _isFirst = true;
        //private bool _isSecond = false;
        private string _operationType;
        private string _memoryCell;
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
                _isFirst = false;
                return;
            }

            //if (_isSecond)
            //{
            //    secondOperandLabel.Text = number;
            //    _isSecond = false;
            //    return;
            //}

            operandLabel.Text += number;
        }

        private void ChangeOperationType(string type)
        {
            _operationType = type;
            
            // Reading the first operand
            _firstOperand = operandLabel.Text;
            
            operandLabel.Text += String.Format(" {0} ", type);
        }

        #region Button click handlers
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
            //_isSecond = false;
        }

        private void binRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (binRadioButton.Checked)
            {
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
            _memoryCell = "";
        }

        private void saveMemoryButton_Click(object sender, EventArgs e)
        {
            
        }

        private void lastSymbolButton_Click(object sender, EventArgs e)
        {

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
            aButton.Enabled = true;
            bButton.Enabled = true;
            cButton.Enabled = true;
            dButton.Enabled = true;
            eButton.Enabled = true;
            fButton.Enabled = true;
        }

        private void DecRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DecRadioButton.Checked)
            {
                MathCalcLibrary.calcMode = CalcMode.DecCalculation;
                SetVisibleOfElements();
            }
        }

        private void HexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HexRadioButton.Checked)
            {
                MathCalcLibrary.calcMode = CalcMode.HexCalculation;
                SetVisibleOfElements();
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
                    break;
                case "-":
                    //resultLabel.Text = MathCalcLibrary.Substract(_firstOperand, _secondOperand).ToString();
                    break;
                case "/":
                    break;
                case "*":
                    break;
            }

            _isFirst = true;

            // Saving results to history

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
            //new HistoryForm().Show();
        }
    }
}
