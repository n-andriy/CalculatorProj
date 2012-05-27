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
    public partial class HistoryForm : Form
    {
        public HistoryForm(string historyStr)
        {
            InitializeComponent();
            
            if (String.IsNullOrEmpty(historyStr))
            {
                return;
            }

            var calcActions = historyStr.Split(';');

            for (int i = 0; i < calcActions.Length - 1; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i + 1),
                                       calcActions[i].Substring(0, calcActions[i].LastIndexOf('=')), // action (before sign '=')
                                       calcActions[i].Substring(calcActions[i].IndexOf('=') + 1));   // result (after sign '=')
            }
        }
    }
}
