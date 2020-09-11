namespace BMI_Calculator
{
    //Devesh Kumar 
    //Student Id 301117993 (Section - 004)
    //Assignment 4
    partial class BMIForm
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
            this.bmiCalculator = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.bmiTextBox = new System.Windows.Forms.TextBox();
            this.recommendationLabel = new System.Windows.Forms.Label();
            this.recommendationTextBox = new System.Windows.Forms.TextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.heightComboBox = new System.Windows.Forms.ComboBox();
            this.weightComboBox = new System.Windows.Forms.ComboBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femalRadioButton = new System.Windows.Forms.RadioButton();
            this.bmiChartGridView = new System.Windows.Forms.DataGridView();
            this.bmiChartLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmiChartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bmiCalculator
            // 
            this.bmiCalculator.AutoSize = true;
            this.bmiCalculator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bmiCalculator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bmiCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiCalculator.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bmiCalculator.Location = new System.Drawing.Point(416, 9);
            this.bmiCalculator.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bmiCalculator.Name = "bmiCalculator";
            this.bmiCalculator.Size = new System.Drawing.Size(185, 31);
            this.bmiCalculator.TabIndex = 18;
            this.bmiCalculator.Text = "BMI Calculator";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(64, 127);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(126, 16);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Enter your weight";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(64, 180);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(128, 16);
            this.heightLabel.TabIndex = 10;
            this.heightLabel.Text = "Enter your height ";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(199, 121);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 2;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(199, 174);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 22);
            this.heightTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(150, 230);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(149, 43);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(34, 354);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(60, 16);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Results";
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(140, 348);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(212, 22);
            this.resultsTextBox.TabIndex = 14;
            this.resultsTextBox.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(169, 445);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(110, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Location = new System.Drawing.Point(60, 308);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(34, 16);
            this.bmiLabel.TabIndex = 11;
            this.bmiLabel.Text = "BMI";
            // 
            // bmiTextBox
            // 
            this.bmiTextBox.Location = new System.Drawing.Point(140, 305);
            this.bmiTextBox.Name = "bmiTextBox";
            this.bmiTextBox.ReadOnly = true;
            this.bmiTextBox.Size = new System.Drawing.Size(212, 22);
            this.bmiTextBox.TabIndex = 12;
            this.bmiTextBox.TabStop = false;
            // 
            // recommendationLabel
            // 
            this.recommendationLabel.AutoSize = true;
            this.recommendationLabel.Location = new System.Drawing.Point(-1, 400);
            this.recommendationLabel.Name = "recommendationLabel";
            this.recommendationLabel.Size = new System.Drawing.Size(121, 16);
            this.recommendationLabel.TabIndex = 15;
            this.recommendationLabel.Text = "Recommedation";
            // 
            // recommendationTextBox
            // 
            this.recommendationTextBox.Location = new System.Drawing.Point(140, 394);
            this.recommendationTextBox.Name = "recommendationTextBox";
            this.recommendationTextBox.ReadOnly = true;
            this.recommendationTextBox.Size = new System.Drawing.Size(316, 22);
            this.recommendationTextBox.TabIndex = 16;
            this.recommendationTextBox.TabStop = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTextBox.Location = new System.Drawing.Point(17, 527);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(439, 21);
            this.infoTextBox.TabIndex = 17;
            this.infoTextBox.TabStop = false;
            this.infoTextBox.Text = "For most adults, an ideal BMI is in the 18.5 to 24.9 range.";
            this.infoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightComboBox
            // 
            this.heightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heightComboBox.FormattingEnabled = true;
            this.heightComboBox.Items.AddRange(new object[] {
            "cm",
            "inch"});
            this.heightComboBox.Location = new System.Drawing.Point(305, 174);
            this.heightComboBox.Name = "heightComboBox";
            this.heightComboBox.Size = new System.Drawing.Size(59, 24);
            this.heightComboBox.TabIndex = 5;
            this.heightComboBox.SelectedIndex = 0;
            // 
            // weightComboBox
            // 
            this.weightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.weightComboBox.FormattingEnabled = true;
            this.weightComboBox.Items.AddRange(new object[] {
            "kg",
            "lb"});
            this.weightComboBox.Location = new System.Drawing.Point(305, 121);
            this.weightComboBox.Name = "weightComboBox";
            this.weightComboBox.Size = new System.Drawing.Size(59, 24);
            this.weightComboBox.TabIndex = 3;
            this.weightComboBox.SelectedIndex = 0;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Location = new System.Drawing.Point(132, 87);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(60, 20);
            this.maleRadioButton.TabIndex = 0;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femalRadioButton
            // 
            this.femalRadioButton.AutoSize = true;
            this.femalRadioButton.Location = new System.Drawing.Point(199, 87);
            this.femalRadioButton.Name = "femalRadioButton";
            this.femalRadioButton.Size = new System.Drawing.Size(78, 20);
            this.femalRadioButton.TabIndex = 1;
            this.femalRadioButton.TabStop = true;
            this.femalRadioButton.Text = "Female";
            this.femalRadioButton.UseVisualStyleBackColor = true;
            // 
            // bmiChartGridView
            // 
            this.bmiChartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bmiChartGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bmiChartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bmiChartGridView.Location = new System.Drawing.Point(518, 179);
            this.bmiChartGridView.Name = "bmiChartGridView";
            this.bmiChartGridView.ReadOnly = true;
            this.bmiChartGridView.Size = new System.Drawing.Size(472, 194);
            this.bmiChartGridView.TabIndex = 8;
            this.bmiChartGridView.TabStop = false;
            // 
            // bmiChartLabel
            // 
            this.bmiChartLabel.AutoSize = true;
            this.bmiChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmiChartLabel.Location = new System.Drawing.Point(735, 126);
            this.bmiChartLabel.Name = "bmiChartLabel";
            this.bmiChartLabel.Size = new System.Drawing.Size(90, 20);
            this.bmiChartLabel.TabIndex = 19;
            this.bmiChartLabel.Text = "BMI Chart";
            // 
            // BMIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 705);
            this.Controls.Add(this.bmiChartLabel);
            this.Controls.Add(this.bmiChartGridView);
            this.Controls.Add(this.femalRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.weightComboBox);
            this.Controls.Add(this.heightComboBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.recommendationTextBox);
            this.Controls.Add(this.recommendationLabel);
            this.Controls.Add(this.bmiTextBox);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.bmiCalculator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(632, 613);
            this.Name = "BMIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            ((System.ComponentModel.ISupportInitialize)(this.bmiChartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bmiCalculator;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.TextBox bmiTextBox;
        private System.Windows.Forms.Label recommendationLabel;
        private System.Windows.Forms.TextBox recommendationTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox heightComboBox;
        private System.Windows.Forms.ComboBox weightComboBox;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femalRadioButton;
        private System.Windows.Forms.DataGridView bmiChartGridView;
        private System.Windows.Forms.Label bmiChartLabel;
    }
}

