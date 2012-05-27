using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public static class CalcLogic
    {
        public static void CheckErrors(TextBox textBox)
        {
            var regExp = new Regex(@"^\s+$");
            if (!regExp.IsMatch(textBox.Text))
            {
                MessageBox.Show("You must enter only digits", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
