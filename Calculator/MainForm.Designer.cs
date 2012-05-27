namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.operandLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.HexRadioButton = new System.Windows.Forms.RadioButton();
            this.DecRadioButton = new System.Windows.Forms.RadioButton();
            this.binRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.lastSymbolButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.inverseDivButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.memClearButton = new System.Windows.Forms.Button();
            this.saveMemoryButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.sqrtDegButton = new System.Windows.Forms.Button();
            this.degreeButton = new System.Windows.Forms.Button();
            this.lgButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.aButton = new System.Windows.Forms.Button();
            this.bButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.dButton = new System.Windows.Forms.Button();
            this.eButton = new System.Windows.Forms.Button();
            this.fButton = new System.Windows.Forms.Button();
            this.initialValueTextBox = new System.Windows.Forms.TextBox();
            this.initValueLabel = new System.Windows.Forms.Label();
            this.convertedValueTextBox = new System.Windows.Forms.TextBox();
            this.romanResultLabel = new System.Windows.Forms.Label();
            this.romanViewGroupBox = new System.Windows.Forms.GroupBox();
            this.romanClearButton = new System.Windows.Forms.Button();
            this.romanConvertButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.romanViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.operandLabel);
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // operandLabel
            // 
            this.operandLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.operandLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operandLabel.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandLabel.Location = new System.Drawing.Point(3, 8);
            this.operandLabel.Name = "operandLabel";
            this.operandLabel.Size = new System.Drawing.Size(409, 23);
            this.operandLabel.TabIndex = 22;
            this.operandLabel.Text = "0";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resultLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(3, 31);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(409, 23);
            this.resultLabel.TabIndex = 21;
            this.resultLabel.Text = "0";
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneButton.Location = new System.Drawing.Point(185, 341);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(43, 43);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoButton.Location = new System.Drawing.Point(235, 341);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(43, 43);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeButton.Location = new System.Drawing.Point(285, 341);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(43, 43);
            this.threeButton.TabIndex = 4;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourButton.Location = new System.Drawing.Point(185, 292);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(43, 43);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveButton.Location = new System.Drawing.Point(235, 292);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(43, 43);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixButton.Location = new System.Drawing.Point(285, 292);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(43, 43);
            this.sixButton.TabIndex = 7;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenButton.Location = new System.Drawing.Point(185, 243);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(43, 43);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightButton.Location = new System.Drawing.Point(235, 243);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(43, 43);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineButton.Location = new System.Drawing.Point(285, 243);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(43, 43);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroButton.Location = new System.Drawing.Point(185, 390);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(93, 43);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(284, 390);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(43, 43);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusButton.Location = new System.Drawing.Point(335, 243);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(43, 43);
            this.plusButton.TabIndex = 13;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.substractButton.Location = new System.Drawing.Point(335, 292);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(43, 43);
            this.substractButton.TabIndex = 14;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplyButton.Location = new System.Drawing.Point(335, 341);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(43, 43);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideButton.Location = new System.Drawing.Point(335, 390);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(43, 43);
            this.divideButton.TabIndex = 16;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // HexRadioButton
            // 
            this.HexRadioButton.AutoSize = true;
            this.HexRadioButton.Location = new System.Drawing.Point(9, 10);
            this.HexRadioButton.Name = "HexRadioButton";
            this.HexRadioButton.Size = new System.Drawing.Size(47, 17);
            this.HexRadioButton.TabIndex = 17;
            this.HexRadioButton.TabStop = true;
            this.HexRadioButton.Text = "HEX";
            this.HexRadioButton.UseVisualStyleBackColor = true;
            this.HexRadioButton.CheckedChanged += new System.EventHandler(this.HexRadioButton_CheckedChanged);
            // 
            // DecRadioButton
            // 
            this.DecRadioButton.AutoSize = true;
            this.DecRadioButton.Location = new System.Drawing.Point(61, 10);
            this.DecRadioButton.Name = "DecRadioButton";
            this.DecRadioButton.Size = new System.Drawing.Size(47, 17);
            this.DecRadioButton.TabIndex = 18;
            this.DecRadioButton.TabStop = true;
            this.DecRadioButton.Text = "DEC";
            this.DecRadioButton.UseVisualStyleBackColor = true;
            this.DecRadioButton.CheckedChanged += new System.EventHandler(this.DecRadioButton_CheckedChanged);
            // 
            // binRadioButton
            // 
            this.binRadioButton.AutoSize = true;
            this.binRadioButton.Location = new System.Drawing.Point(114, 10);
            this.binRadioButton.Name = "binRadioButton";
            this.binRadioButton.Size = new System.Drawing.Size(43, 17);
            this.binRadioButton.TabIndex = 19;
            this.binRadioButton.TabStop = true;
            this.binRadioButton.Text = "BIN";
            this.binRadioButton.UseVisualStyleBackColor = true;
            this.binRadioButton.CheckedChanged += new System.EventHandler(this.binRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.binRadioButton);
            this.groupBox2.Controls.Add(this.DecRadioButton);
            this.groupBox2.Controls.Add(this.HexRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 31);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.Location = new System.Drawing.Point(285, 194);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(43, 43);
            this.button18.TabIndex = 22;
            this.button18.Text = "M+";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button19.Location = new System.Drawing.Point(334, 194);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(43, 43);
            this.button19.TabIndex = 23;
            this.button19.Text = "M-";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button20.Location = new System.Drawing.Point(384, 194);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(43, 43);
            this.button20.TabIndex = 24;
            this.button20.Text = "MR";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // lastSymbolButton
            // 
            this.lastSymbolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastSymbolButton.Location = new System.Drawing.Point(384, 243);
            this.lastSymbolButton.Name = "lastSymbolButton";
            this.lastSymbolButton.Size = new System.Drawing.Size(43, 43);
            this.lastSymbolButton.TabIndex = 25;
            this.lastSymbolButton.Text = "←";
            this.lastSymbolButton.UseVisualStyleBackColor = true;
            this.lastSymbolButton.Click += new System.EventHandler(this.lastSymbolButton_Click);
            // 
            // factButton
            // 
            this.factButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factButton.Location = new System.Drawing.Point(111, 292);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(43, 43);
            this.factButton.TabIndex = 27;
            this.factButton.Text = "n!";
            this.factButton.UseVisualStyleBackColor = true;
            this.factButton.Click += new System.EventHandler(this.factButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareButton.Location = new System.Drawing.Point(12, 194);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(43, 43);
            this.squareButton.TabIndex = 28;
            this.squareButton.Text = "x²";
            this.squareButton.UseVisualStyleBackColor = true;
            // 
            // inverseDivButton
            // 
            this.inverseDivButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inverseDivButton.Location = new System.Drawing.Point(111, 243);
            this.inverseDivButton.Name = "inverseDivButton";
            this.inverseDivButton.Size = new System.Drawing.Size(43, 43);
            this.inverseDivButton.TabIndex = 29;
            this.inverseDivButton.Text = "1/x";
            this.inverseDivButton.UseVisualStyleBackColor = true;
            this.inverseDivButton.Click += new System.EventHandler(this.inverseDivButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalsButton.Location = new System.Drawing.Point(384, 292);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(43, 141);
            this.equalsButton.TabIndex = 30;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // memClearButton
            // 
            this.memClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memClearButton.Location = new System.Drawing.Point(185, 194);
            this.memClearButton.Name = "memClearButton";
            this.memClearButton.Size = new System.Drawing.Size(43, 43);
            this.memClearButton.TabIndex = 31;
            this.memClearButton.Text = "MC";
            this.memClearButton.UseVisualStyleBackColor = true;
            this.memClearButton.Click += new System.EventHandler(this.memClearButton_Click);
            // 
            // saveMemoryButton
            // 
            this.saveMemoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveMemoryButton.Location = new System.Drawing.Point(235, 194);
            this.saveMemoryButton.Name = "saveMemoryButton";
            this.saveMemoryButton.Size = new System.Drawing.Size(43, 43);
            this.saveMemoryButton.TabIndex = 32;
            this.saveMemoryButton.Text = "MS";
            this.saveMemoryButton.UseVisualStyleBackColor = true;
            this.saveMemoryButton.Click += new System.EventHandler(this.saveMemoryButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtButton.Location = new System.Drawing.Point(12, 243);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(43, 43);
            this.sqrtButton.TabIndex = 33;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = true;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // sqrtDegButton
            // 
            this.sqrtDegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrtDegButton.Location = new System.Drawing.Point(62, 243);
            this.sqrtDegButton.Name = "sqrtDegButton";
            this.sqrtDegButton.Size = new System.Drawing.Size(43, 43);
            this.sqrtDegButton.TabIndex = 34;
            this.sqrtDegButton.Text = "ⁿ√x";
            this.sqrtDegButton.UseVisualStyleBackColor = true;
            // 
            // degreeButton
            // 
            this.degreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeButton.Location = new System.Drawing.Point(62, 194);
            this.degreeButton.Name = "degreeButton";
            this.degreeButton.Size = new System.Drawing.Size(43, 43);
            this.degreeButton.TabIndex = 38;
            this.degreeButton.Text = "xⁿ";
            this.degreeButton.UseVisualStyleBackColor = true;
            // 
            // lgButton
            // 
            this.lgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lgButton.Location = new System.Drawing.Point(12, 292);
            this.lgButton.Name = "lgButton";
            this.lgButton.Size = new System.Drawing.Size(43, 43);
            this.lgButton.TabIndex = 39;
            this.lgButton.Text = "lg";
            this.lgButton.UseVisualStyleBackColor = true;
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusMinusButton.Location = new System.Drawing.Point(111, 194);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Size = new System.Drawing.Size(43, 43);
            this.plusMinusButton.TabIndex = 41;
            this.plusMinusButton.Text = "±";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            // 
            // aButton
            // 
            this.aButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aButton.Location = new System.Drawing.Point(12, 341);
            this.aButton.Name = "aButton";
            this.aButton.Size = new System.Drawing.Size(43, 43);
            this.aButton.TabIndex = 44;
            this.aButton.Text = "A";
            this.aButton.UseVisualStyleBackColor = true;
            this.aButton.Click += new System.EventHandler(this.aButton_Click);
            // 
            // bButton
            // 
            this.bButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bButton.Location = new System.Drawing.Point(61, 341);
            this.bButton.Name = "bButton";
            this.bButton.Size = new System.Drawing.Size(43, 43);
            this.bButton.TabIndex = 45;
            this.bButton.Text = "B";
            this.bButton.UseVisualStyleBackColor = true;
            this.bButton.Click += new System.EventHandler(this.bButton_Click);
            // 
            // cButton
            // 
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cButton.Location = new System.Drawing.Point(110, 341);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(43, 43);
            this.cButton.TabIndex = 46;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // dButton
            // 
            this.dButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dButton.Location = new System.Drawing.Point(12, 390);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(43, 43);
            this.dButton.TabIndex = 47;
            this.dButton.Text = "D";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // eButton
            // 
            this.eButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eButton.Location = new System.Drawing.Point(61, 390);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(43, 43);
            this.eButton.TabIndex = 48;
            this.eButton.Text = "E";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // fButton
            // 
            this.fButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fButton.Location = new System.Drawing.Point(111, 390);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(43, 43);
            this.fButton.TabIndex = 49;
            this.fButton.Text = "F";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.fButton_Click);
            // 
            // initialValueTextBox
            // 
            this.initialValueTextBox.Location = new System.Drawing.Point(8, 37);
            this.initialValueTextBox.Name = "initialValueTextBox";
            this.initialValueTextBox.Size = new System.Drawing.Size(57, 20);
            this.initialValueTextBox.TabIndex = 50;
            // 
            // initValueLabel
            // 
            this.initValueLabel.AutoSize = true;
            this.initValueLabel.Location = new System.Drawing.Point(7, 21);
            this.initValueLabel.Name = "initValueLabel";
            this.initValueLabel.Size = new System.Drawing.Size(60, 13);
            this.initValueLabel.TabIndex = 51;
            this.initValueLabel.Text = "Initial value";
            // 
            // convertedValueTextBox
            // 
            this.convertedValueTextBox.Location = new System.Drawing.Point(80, 37);
            this.convertedValueTextBox.Name = "convertedValueTextBox";
            this.convertedValueTextBox.ReadOnly = true;
            this.convertedValueTextBox.Size = new System.Drawing.Size(80, 20);
            this.convertedValueTextBox.TabIndex = 52;
            // 
            // romanResultLabel
            // 
            this.romanResultLabel.AutoSize = true;
            this.romanResultLabel.Location = new System.Drawing.Point(77, 22);
            this.romanResultLabel.Name = "romanResultLabel";
            this.romanResultLabel.Size = new System.Drawing.Size(85, 13);
            this.romanResultLabel.TabIndex = 53;
            this.romanResultLabel.Text = "Converted value";
            // 
            // romanViewGroupBox
            // 
            this.romanViewGroupBox.Controls.Add(this.romanClearButton);
            this.romanViewGroupBox.Controls.Add(this.romanConvertButton);
            this.romanViewGroupBox.Controls.Add(this.convertedValueTextBox);
            this.romanViewGroupBox.Controls.Add(this.initialValueTextBox);
            this.romanViewGroupBox.Controls.Add(this.romanResultLabel);
            this.romanViewGroupBox.Controls.Add(this.initValueLabel);
            this.romanViewGroupBox.Location = new System.Drawing.Point(180, 106);
            this.romanViewGroupBox.Name = "romanViewGroupBox";
            this.romanViewGroupBox.Size = new System.Drawing.Size(247, 73);
            this.romanViewGroupBox.TabIndex = 55;
            this.romanViewGroupBox.TabStop = false;
            this.romanViewGroupBox.Text = "Roman view";
            // 
            // romanClearButton
            // 
            this.romanClearButton.Location = new System.Drawing.Point(168, 41);
            this.romanClearButton.Name = "romanClearButton";
            this.romanClearButton.Size = new System.Drawing.Size(70, 23);
            this.romanClearButton.TabIndex = 55;
            this.romanClearButton.Text = "Clear";
            this.romanClearButton.UseVisualStyleBackColor = true;
            this.romanClearButton.Click += new System.EventHandler(this.romanClearButton_Click);
            // 
            // romanConvertButton
            // 
            this.romanConvertButton.Location = new System.Drawing.Point(168, 16);
            this.romanConvertButton.Name = "romanConvertButton";
            this.romanConvertButton.Size = new System.Drawing.Size(70, 23);
            this.romanConvertButton.TabIndex = 54;
            this.romanConvertButton.Text = "Convert";
            this.romanConvertButton.UseVisualStyleBackColor = true;
            this.romanConvertButton.Click += new System.EventHandler(this.romanConvertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 442);
            this.Controls.Add(this.romanViewGroupBox);
            this.Controls.Add(this.fButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.bButton);
            this.Controls.Add(this.aButton);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.lgButton);
            this.Controls.Add(this.degreeButton);
            this.Controls.Add(this.sqrtDegButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.saveMemoryButton);
            this.Controls.Add(this.memClearButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.inverseDivButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.factButton);
            this.Controls.Add(this.lastSymbolButton);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.romanViewGroupBox.ResumeLayout(false);
            this.romanViewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label operandLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.RadioButton HexRadioButton;
        private System.Windows.Forms.RadioButton DecRadioButton;
        private System.Windows.Forms.RadioButton binRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button lastSymbolButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button inverseDivButton;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button memClearButton;
        private System.Windows.Forms.Button saveMemoryButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button sqrtDegButton;
        private System.Windows.Forms.Button degreeButton;
        private System.Windows.Forms.Button lgButton;
        private System.Windows.Forms.Button plusMinusButton;
        private System.Windows.Forms.Button aButton;
        private System.Windows.Forms.Button bButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.TextBox initialValueTextBox;
        private System.Windows.Forms.Label initValueLabel;
        private System.Windows.Forms.TextBox convertedValueTextBox;
        private System.Windows.Forms.Label romanResultLabel;
        private System.Windows.Forms.GroupBox romanViewGroupBox;
        private System.Windows.Forms.Button romanConvertButton;
        private System.Windows.Forms.Button romanClearButton;
    }
}

