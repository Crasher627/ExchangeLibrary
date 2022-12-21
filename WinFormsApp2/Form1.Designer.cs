
namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.latestRates = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pairConvertBtn = new System.Windows.Forms.Button();
            this.numToConvert = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTargetCurr = new System.Windows.Forms.ComboBox();
            this.comboBoxBaseCurr = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.convertedAmount = new System.Windows.Forms.TextBox();
            this.convRate = new System.Windows.Forms.TextBox();
            this.targetCurrTxt = new System.Windows.Forms.TextBox();
            this.baseCurrTxt = new System.Windows.Forms.TextBox();
            this.timeNextUpd = new System.Windows.Forms.TextBox();
            this.timeLastUpd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.latestAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonToGetLatestRates = new System.Windows.Forms.Button();
            this.comboBoxCurrencies = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.targetCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nextUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baseCodeTxt = new System.Windows.Forms.TextBox();
            this.lastUpdated = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.historicalRates = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.histAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonHistorical = new System.Windows.Forms.Button();
            this.comboBoxHistorical = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.currencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.selectedDate = new System.Windows.Forms.TextBox();
            this.baseHistCurr = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.latestRates.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToConvert)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latestAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.historicalRates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // latestRates
            // 
            this.latestRates.Controls.Add(this.tabPage1);
            this.latestRates.Controls.Add(this.tabPage2);
            this.latestRates.Controls.Add(this.historicalRates);
            this.latestRates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.latestRates.Location = new System.Drawing.Point(0, 0);
            this.latestRates.Name = "latestRates";
            this.latestRates.SelectedIndex = 0;
            this.latestRates.Size = new System.Drawing.Size(832, 475);
            this.latestRates.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pair Rates";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.pairConvertBtn);
            this.splitContainer3.Panel1.Controls.Add(this.numToConvert);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxTargetCurr);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxBaseCurr);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label11);
            this.splitContainer3.Panel2.Controls.Add(this.label10);
            this.splitContainer3.Panel2.Controls.Add(this.label9);
            this.splitContainer3.Panel2.Controls.Add(this.label8);
            this.splitContainer3.Panel2.Controls.Add(this.label7);
            this.splitContainer3.Panel2.Controls.Add(this.label6);
            this.splitContainer3.Panel2.Controls.Add(this.convertedAmount);
            this.splitContainer3.Panel2.Controls.Add(this.convRate);
            this.splitContainer3.Panel2.Controls.Add(this.targetCurrTxt);
            this.splitContainer3.Panel2.Controls.Add(this.baseCurrTxt);
            this.splitContainer3.Panel2.Controls.Add(this.timeNextUpd);
            this.splitContainer3.Panel2.Controls.Add(this.timeLastUpd);
            this.splitContainer3.Size = new System.Drawing.Size(818, 441);
            this.splitContainer3.SplitterDistance = 272;
            this.splitContainer3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Target currency";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Base currency";
            // 
            // pairConvertBtn
            // 
            this.pairConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pairConvertBtn.Location = new System.Drawing.Point(54, 194);
            this.pairConvertBtn.Name = "pairConvertBtn";
            this.pairConvertBtn.Size = new System.Drawing.Size(154, 23);
            this.pairConvertBtn.TabIndex = 3;
            this.pairConvertBtn.Text = "Convert value";
            this.pairConvertBtn.UseVisualStyleBackColor = true;
            this.pairConvertBtn.Click += new System.EventHandler(this.pairConvertBtn_Click);
            // 
            // numToConvert
            // 
            this.numToConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numToConvert.DecimalPlaces = 2;
            this.numToConvert.Location = new System.Drawing.Point(6, 132);
            this.numToConvert.Name = "numToConvert";
            this.numToConvert.Size = new System.Drawing.Size(120, 23);
            this.numToConvert.TabIndex = 2;
            // 
            // comboBoxTargetCurr
            // 
            this.comboBoxTargetCurr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTargetCurr.FormattingEnabled = true;
            this.comboBoxTargetCurr.Location = new System.Drawing.Point(5, 69);
            this.comboBoxTargetCurr.Name = "comboBoxTargetCurr";
            this.comboBoxTargetCurr.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTargetCurr.TabIndex = 1;
            // 
            // comboBoxBaseCurr
            // 
            this.comboBoxBaseCurr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBaseCurr.FormattingEnabled = true;
            this.comboBoxBaseCurr.Location = new System.Drawing.Point(5, 21);
            this.comboBoxBaseCurr.Name = "comboBoxBaseCurr";
            this.comboBoxBaseCurr.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBaseCurr.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 337);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Converted amount";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Conversion rate";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Target currency";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Base currency";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Time of next update";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Time last updated";
            // 
            // convertedAmount
            // 
            this.convertedAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertedAmount.Location = new System.Drawing.Point(22, 358);
            this.convertedAmount.Name = "convertedAmount";
            this.convertedAmount.ReadOnly = true;
            this.convertedAmount.Size = new System.Drawing.Size(100, 23);
            this.convertedAmount.TabIndex = 5;
            // 
            // convRate
            // 
            this.convRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convRate.Location = new System.Drawing.Point(22, 293);
            this.convRate.Name = "convRate";
            this.convRate.ReadOnly = true;
            this.convRate.Size = new System.Drawing.Size(100, 23);
            this.convRate.TabIndex = 4;
            // 
            // targetCurrTxt
            // 
            this.targetCurrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetCurrTxt.Location = new System.Drawing.Point(22, 227);
            this.targetCurrTxt.Name = "targetCurrTxt";
            this.targetCurrTxt.ReadOnly = true;
            this.targetCurrTxt.Size = new System.Drawing.Size(100, 23);
            this.targetCurrTxt.TabIndex = 3;
            // 
            // baseCurrTxt
            // 
            this.baseCurrTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseCurrTxt.Location = new System.Drawing.Point(22, 176);
            this.baseCurrTxt.Name = "baseCurrTxt";
            this.baseCurrTxt.ReadOnly = true;
            this.baseCurrTxt.Size = new System.Drawing.Size(100, 23);
            this.baseCurrTxt.TabIndex = 2;
            // 
            // timeNextUpd
            // 
            this.timeNextUpd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNextUpd.Location = new System.Drawing.Point(22, 100);
            this.timeNextUpd.Name = "timeNextUpd";
            this.timeNextUpd.ReadOnly = true;
            this.timeNextUpd.Size = new System.Drawing.Size(302, 23);
            this.timeNextUpd.TabIndex = 1;
            // 
            // timeLastUpd
            // 
            this.timeLastUpd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLastUpd.Location = new System.Drawing.Point(22, 40);
            this.timeLastUpd.Name = "timeLastUpd";
            this.timeLastUpd.ReadOnly = true;
            this.timeLastUpd.Size = new System.Drawing.Size(302, 23);
            this.timeLastUpd.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Latest Rates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.latestAmount);
            this.splitContainer1.Panel1.Controls.Add(this.buttonToGetLatestRates);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCurrencies);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(818, 441);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(91, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Select currency";
            // 
            // latestAmount
            // 
            this.latestAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latestAmount.DecimalPlaces = 2;
            this.latestAmount.Location = new System.Drawing.Point(73, 127);
            this.latestAmount.Name = "latestAmount";
            this.latestAmount.Size = new System.Drawing.Size(120, 23);
            this.latestAmount.TabIndex = 30;
            // 
            // buttonToGetLatestRates
            // 
            this.buttonToGetLatestRates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToGetLatestRates.Location = new System.Drawing.Point(59, 64);
            this.buttonToGetLatestRates.Name = "buttonToGetLatestRates";
            this.buttonToGetLatestRates.Size = new System.Drawing.Size(146, 23);
            this.buttonToGetLatestRates.TabIndex = 29;
            this.buttonToGetLatestRates.Text = "Get latest rates";
            this.buttonToGetLatestRates.UseVisualStyleBackColor = true;
            this.buttonToGetLatestRates.Click += new System.EventHandler(this.buttonToGetLatestRates_Click_1);
            // 
            // comboBoxCurrencies
            // 
            this.comboBoxCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCurrencies.Enabled = false;
            this.comboBoxCurrencies.FormattingEnabled = true;
            this.comboBoxCurrencies.Location = new System.Drawing.Point(73, 35);
            this.comboBoxCurrencies.Name = "comboBoxCurrencies";
            this.comboBoxCurrencies.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCurrencies.TabIndex = 26;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.nextUpdate);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.baseCodeTxt);
            this.splitContainer2.Panel2.Controls.Add(this.lastUpdated);
            this.splitContainer2.Panel2.Controls.Add(this.lbl1);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(542, 441);
            this.splitContainer2.SplitterDistance = 180;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetCurrency,
            this.conversionRate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(542, 180);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // targetCurrency
            // 
            this.targetCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetCurrency.DataPropertyName = "key";
            this.targetCurrency.HeaderText = "Target Currency";
            this.targetCurrency.Name = "targetCurrency";
            this.targetCurrency.ReadOnly = true;
            // 
            // conversionRate
            // 
            this.conversionRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.conversionRate.DataPropertyName = "value";
            this.conversionRate.HeaderText = "Conversion Rate";
            this.conversionRate.Name = "conversionRate";
            this.conversionRate.ReadOnly = true;
            // 
            // nextUpdate
            // 
            this.nextUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextUpdate.Location = new System.Drawing.Point(135, 144);
            this.nextUpdate.Name = "nextUpdate";
            this.nextUpdate.ReadOnly = true;
            this.nextUpdate.Size = new System.Drawing.Size(274, 23);
            this.nextUpdate.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Base currency code";
            // 
            // baseCodeTxt
            // 
            this.baseCodeTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseCodeTxt.Location = new System.Drawing.Point(203, 27);
            this.baseCodeTxt.Name = "baseCodeTxt";
            this.baseCodeTxt.ReadOnly = true;
            this.baseCodeTxt.Size = new System.Drawing.Size(145, 23);
            this.baseCodeTxt.TabIndex = 33;
            // 
            // lastUpdated
            // 
            this.lastUpdated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastUpdated.Location = new System.Drawing.Point(135, 85);
            this.lastUpdated.Name = "lastUpdated";
            this.lastUpdated.ReadOnly = true;
            this.lastUpdated.Size = new System.Drawing.Size(274, 23);
            this.lastUpdated.TabIndex = 27;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(227, 67);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(101, 15);
            this.lbl1.TabIndex = 28;
            this.lbl1.Text = "Time last updated";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Time of next update";
            // 
            // historicalRates
            // 
            this.historicalRates.Controls.Add(this.splitContainer4);
            this.historicalRates.Location = new System.Drawing.Point(4, 24);
            this.historicalRates.Name = "historicalRates";
            this.historicalRates.Padding = new System.Windows.Forms.Padding(3);
            this.historicalRates.Size = new System.Drawing.Size(824, 447);
            this.historicalRates.TabIndex = 2;
            this.historicalRates.Text = "Historical Rates";
            this.historicalRates.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label18);
            this.splitContainer4.Panel1.Controls.Add(this.label17);
            this.splitContainer4.Panel1.Controls.Add(this.label16);
            this.splitContainer4.Panel1.Controls.Add(this.histAmount);
            this.splitContainer4.Panel1.Controls.Add(this.buttonHistorical);
            this.splitContainer4.Panel1.Controls.Add(this.comboBoxHistorical);
            this.splitContainer4.Panel1.Controls.Add(this.dateTimePicker1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(818, 441);
            this.splitContainer4.SplitterDistance = 272;
            this.splitContainer4.TabIndex = 0;
            // 
            // histAmount
            // 
            this.histAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histAmount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.histAmount.DecimalPlaces = 2;
            this.histAmount.Location = new System.Drawing.Point(0, 193);
            this.histAmount.Name = "histAmount";
            this.histAmount.Size = new System.Drawing.Size(120, 23);
            this.histAmount.TabIndex = 3;
            // 
            // buttonHistorical
            // 
            this.buttonHistorical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHistorical.Location = new System.Drawing.Point(3, 125);
            this.buttonHistorical.Name = "buttonHistorical";
            this.buttonHistorical.Size = new System.Drawing.Size(150, 23);
            this.buttonHistorical.TabIndex = 2;
            this.buttonHistorical.Text = "Get Historical Rates";
            this.buttonHistorical.UseVisualStyleBackColor = true;
            this.buttonHistorical.Click += new System.EventHandler(this.buttonHistorical_Click);
            // 
            // comboBoxHistorical
            // 
            this.comboBoxHistorical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxHistorical.FormattingEnabled = true;
            this.comboBoxHistorical.Location = new System.Drawing.Point(0, 96);
            this.comboBoxHistorical.Name = "comboBoxHistorical";
            this.comboBoxHistorical.Size = new System.Drawing.Size(121, 23);
            this.comboBoxHistorical.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 29);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.label13);
            this.splitContainer5.Panel2.Controls.Add(this.selectedDate);
            this.splitContainer5.Panel2.Controls.Add(this.baseHistCurr);
            this.splitContainer5.Panel2.Controls.Add(this.label12);
            this.splitContainer5.Size = new System.Drawing.Size(542, 441);
            this.splitContainer5.SplitterDistance = 180;
            this.splitContainer5.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyCode,
            this.valueRate});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(542, 180);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // currencyCode
            // 
            this.currencyCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currencyCode.DataPropertyName = "key";
            this.currencyCode.HeaderText = "Currency code";
            this.currencyCode.Name = "currencyCode";
            this.currencyCode.ReadOnly = true;
            // 
            // valueRate
            // 
            this.valueRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueRate.DataPropertyName = "value";
            this.valueRate.HeaderText = "Conversion rate";
            this.valueRate.Name = "valueRate";
            this.valueRate.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Date";
            // 
            // selectedDate
            // 
            this.selectedDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedDate.Location = new System.Drawing.Point(14, 103);
            this.selectedDate.Name = "selectedDate";
            this.selectedDate.ReadOnly = true;
            this.selectedDate.Size = new System.Drawing.Size(244, 23);
            this.selectedDate.TabIndex = 2;
            // 
            // baseHistCurr
            // 
            this.baseHistCurr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseHistCurr.Location = new System.Drawing.Point(14, 35);
            this.baseHistCurr.Name = "baseHistCurr";
            this.baseHistCurr.ReadOnly = true;
            this.baseHistCurr.Size = new System.Drawing.Size(94, 23);
            this.baseHistCurr.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Base currency";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Select date";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Select currency";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 6;
            this.label18.Text = "Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 475);
            this.Controls.Add(this.latestRates);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.latestRates.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numToConvert)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.latestAmount)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.historicalRates.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.histAmount)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl latestRates;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonToGetLatestRates;
        private System.Windows.Forms.ComboBox comboBoxCurrencies;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nextUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox baseCodeTxt;
        private System.Windows.Forms.TextBox lastUpdated;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pairConvertBtn;
        private System.Windows.Forms.NumericUpDown numToConvert;
        private System.Windows.Forms.ComboBox comboBoxTargetCurr;
        private System.Windows.Forms.ComboBox comboBoxBaseCurr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox convertedAmount;
        private System.Windows.Forms.TextBox convRate;
        private System.Windows.Forms.TextBox targetCurrTxt;
        private System.Windows.Forms.TextBox baseCurrTxt;
        private System.Windows.Forms.TextBox timeNextUpd;
        private System.Windows.Forms.TextBox timeLastUpd;
        private System.Windows.Forms.NumericUpDown latestAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversionRate;
        private System.Windows.Forms.TabPage historicalRates;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button buttonHistorical;
        private System.Windows.Forms.ComboBox comboBoxHistorical;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueRate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox selectedDate;
        private System.Windows.Forms.TextBox baseHistCurr;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown histAmount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}

