namespace BeerCalculatorWinForms
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
            this.components = new System.ComponentModel.Container();
            this.PoundsTextBox1 = new System.Windows.Forms.TextBox();
            this.GravityTextBox1 = new System.Windows.Forms.TextBox();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.gravityLabel = new System.Windows.Forms.Label();
            this.SRMTextBox1 = new System.Windows.Forms.TextBox();
            this.srmLabel = new System.Windows.Forms.Label();
            this.grain1Label = new System.Windows.Forms.Label();
            this.grain2Label = new System.Windows.Forms.Label();
            this.PoundsTextBox2 = new System.Windows.Forms.TextBox();
            this.SRMTextBox2 = new System.Windows.Forms.TextBox();
            this.GravityTextBox2 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.estimatedOGLabel = new System.Windows.Forms.Label();
            this.EstimatedColorTextBox = new System.Windows.Forms.TextBox();
            this.EstimatedOGTextBox = new System.Windows.Forms.TextBox();
            this.estimatedColorLabel = new System.Windows.Forms.Label();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.BatchSizeTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ColorLabel = new System.Windows.Forms.Label();
            this.DbComboBox1 = new System.Windows.Forms.ComboBox();
            this.ExtractPoundsTextBox1 = new System.Windows.Forms.TextBox();
            this.ExtractSRMTextBox1 = new System.Windows.Forms.TextBox();
            this.ExtractGravityTextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ExtractPoundsTextBox2 = new System.Windows.Forms.TextBox();
            this.ExtractGravityTextBox2 = new System.Windows.Forms.TextBox();
            this.ExtractSRMTextBox2 = new System.Windows.Forms.TextBox();
            this.DbComboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PoundsTextBox1
            // 
            this.PoundsTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PoundsTextBox1.Location = new System.Drawing.Point(97, 304);
            this.PoundsTextBox1.Name = "PoundsTextBox1";
            this.PoundsTextBox1.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox1.TabIndex = 0;
            this.PoundsTextBox1.Text = "0.0";
            this.PoundsTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // GravityTextBox1
            // 
            this.GravityTextBox1.Location = new System.Drawing.Point(208, 304);
            this.GravityTextBox1.Name = "GravityTextBox1";
            this.GravityTextBox1.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox1.TabIndex = 1;
            this.GravityTextBox1.Text = "0";
            this.GravityTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(109, 269);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(56, 17);
            this.poundsLabel.TabIndex = 7;
            this.poundsLabel.Text = "Pounds";
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(205, 269);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(96, 17);
            this.gravityLabel.TabIndex = 10;
            this.gravityLabel.Text = "Gravity Points";
            // 
            // SRMTextBox1
            // 
            this.SRMTextBox1.Location = new System.Drawing.Point(323, 304);
            this.SRMTextBox1.Name = "SRMTextBox1";
            this.SRMTextBox1.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox1.TabIndex = 2;
            this.SRMTextBox1.Text = "0";
            this.SRMTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // srmLabel
            // 
            this.srmLabel.AutoSize = true;
            this.srmLabel.Location = new System.Drawing.Point(329, 269);
            this.srmLabel.Name = "srmLabel";
            this.srmLabel.Size = new System.Drawing.Size(66, 17);
            this.srmLabel.TabIndex = 11;
            this.srmLabel.Text = "Lovibond";
            // 
            // grain1Label
            // 
            this.grain1Label.AutoSize = true;
            this.grain1Label.Location = new System.Drawing.Point(12, 304);
            this.grain1Label.Name = "grain1Label";
            this.grain1Label.Size = new System.Drawing.Size(55, 17);
            this.grain1Label.TabIndex = 8;
            this.grain1Label.Text = "Grain 1";
            // 
            // grain2Label
            // 
            this.grain2Label.AutoSize = true;
            this.grain2Label.Location = new System.Drawing.Point(12, 346);
            this.grain2Label.Name = "grain2Label";
            this.grain2Label.Size = new System.Drawing.Size(55, 17);
            this.grain2Label.TabIndex = 9;
            this.grain2Label.Text = "Grain 2";
            // 
            // PoundsTextBox2
            // 
            this.PoundsTextBox2.Location = new System.Drawing.Point(97, 341);
            this.PoundsTextBox2.Name = "PoundsTextBox2";
            this.PoundsTextBox2.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox2.TabIndex = 3;
            this.PoundsTextBox2.Text = "0.0";
            this.PoundsTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // SRMTextBox2
            // 
            this.SRMTextBox2.Location = new System.Drawing.Point(323, 341);
            this.SRMTextBox2.Name = "SRMTextBox2";
            this.SRMTextBox2.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox2.TabIndex = 5;
            this.SRMTextBox2.Text = "0";
            this.SRMTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // GravityTextBox2
            // 
            this.GravityTextBox2.Location = new System.Drawing.Point(208, 341);
            this.GravityTextBox2.Name = "GravityTextBox2";
            this.GravityTextBox2.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox2.TabIndex = 4;
            this.GravityTextBox2.Text = "0";
            this.GravityTextBox2.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 393);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 40);
            this.CalculateButton.TabIndex = 13;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButtonClick);
            // 
            // estimatedOGLabel
            // 
            this.estimatedOGLabel.AutoSize = true;
            this.estimatedOGLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedOGLabel.Location = new System.Drawing.Point(155, 373);
            this.estimatedOGLabel.Name = "estimatedOGLabel";
            this.estimatedOGLabel.Size = new System.Drawing.Size(108, 17);
            this.estimatedOGLabel.TabIndex = 14;
            this.estimatedOGLabel.Text = "Estimated OG";
            // 
            // EstimatedColorTextBox
            // 
            this.EstimatedColorTextBox.Location = new System.Drawing.Point(305, 402);
            this.EstimatedColorTextBox.Multiline = true;
            this.EstimatedColorTextBox.Name = "EstimatedColorTextBox";
            this.EstimatedColorTextBox.ReadOnly = true;
            this.EstimatedColorTextBox.Size = new System.Drawing.Size(64, 22);
            this.EstimatedColorTextBox.TabIndex = 15;
            this.EstimatedColorTextBox.Text = "0";
            // 
            // EstimatedOGTextBox
            // 
            this.EstimatedOGTextBox.Location = new System.Drawing.Point(158, 402);
            this.EstimatedOGTextBox.Name = "EstimatedOGTextBox";
            this.EstimatedOGTextBox.ReadOnly = true;
            this.EstimatedOGTextBox.Size = new System.Drawing.Size(100, 22);
            this.EstimatedOGTextBox.TabIndex = 16;
            this.EstimatedOGTextBox.Text = "0.00";
            // 
            // estimatedColorLabel
            // 
            this.estimatedColorLabel.AutoSize = true;
            this.estimatedColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedColorLabel.Location = new System.Drawing.Point(289, 373);
            this.estimatedColorLabel.Name = "estimatedColorLabel";
            this.estimatedColorLabel.Size = new System.Drawing.Size(172, 17);
            this.estimatedColorLabel.TabIndex = 17;
            this.estimatedColorLabel.Text = "Estimated Color (SRM)";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batchSizeLabel.Location = new System.Drawing.Point(490, 18);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(124, 17);
            this.batchSizeLabel.TabIndex = 18;
            this.batchSizeLabel.Text = "Batch Size (gal)";
            // 
            // BatchSizeTextBox
            // 
            this.BatchSizeTextBox.Location = new System.Drawing.Point(522, 58);
            this.BatchSizeTextBox.Name = "BatchSizeTextBox";
            this.BatchSizeTextBox.Size = new System.Drawing.Size(58, 22);
            this.BatchSizeTextBox.TabIndex = 6;
            this.BatchSizeTextBox.Text = "1";
            this.BatchSizeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnNumericTextBoxValidating);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 450;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ColorLabel
            // 
            this.ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorLabel.Location = new System.Drawing.Point(375, 402);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(61, 22);
            this.ColorLabel.TabIndex = 19;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DbComboBox1
            // 
            this.DbComboBox1.FormattingEnabled = true;
            this.DbComboBox1.Location = new System.Drawing.Point(29, 36);
            this.DbComboBox1.Name = "DbComboBox1";
            this.DbComboBox1.Size = new System.Drawing.Size(225, 24);
            this.DbComboBox1.TabIndex = 20;
            this.DbComboBox1.SelectedIndexChanged += new System.EventHandler(this.DbComboBox_SelectedIndexChanged);
            // 
            // ExtractPoundsTextBox1
            // 
            this.ExtractPoundsTextBox1.Location = new System.Drawing.Point(97, 83);
            this.ExtractPoundsTextBox1.Name = "ExtractPoundsTextBox1";
            this.ExtractPoundsTextBox1.Size = new System.Drawing.Size(98, 22);
            this.ExtractPoundsTextBox1.TabIndex = 21;
            this.ExtractPoundsTextBox1.Text = "0";
            // 
            // ExtractSRMTextBox1
            // 
            this.ExtractSRMTextBox1.Location = new System.Drawing.Point(307, 83);
            this.ExtractSRMTextBox1.Name = "ExtractSRMTextBox1";
            this.ExtractSRMTextBox1.Size = new System.Drawing.Size(100, 22);
            this.ExtractSRMTextBox1.TabIndex = 22;
            this.ExtractSRMTextBox1.Text = "0";
            // 
            // ExtractGravityTextBox1
            // 
            this.ExtractGravityTextBox1.Location = new System.Drawing.Point(201, 83);
            this.ExtractGravityTextBox1.Name = "ExtractGravityTextBox1";
            this.ExtractGravityTextBox1.Size = new System.Drawing.Size(100, 22);
            this.ExtractGravityTextBox1.TabIndex = 23;
            this.ExtractGravityTextBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Malt Extract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Pounds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gravity Points";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Lovibond";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Extract 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Extract 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Additional Grains";
            // 
            // ExtractPoundsTextBox2
            // 
            this.ExtractPoundsTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExtractPoundsTextBox2.Location = new System.Drawing.Point(97, 178);
            this.ExtractPoundsTextBox2.Name = "ExtractPoundsTextBox2";
            this.ExtractPoundsTextBox2.Size = new System.Drawing.Size(100, 22);
            this.ExtractPoundsTextBox2.TabIndex = 31;
            this.ExtractPoundsTextBox2.Text = "0.0";
            // 
            // ExtractGravityTextBox2
            // 
            this.ExtractGravityTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExtractGravityTextBox2.Location = new System.Drawing.Point(201, 178);
            this.ExtractGravityTextBox2.Name = "ExtractGravityTextBox2";
            this.ExtractGravityTextBox2.Size = new System.Drawing.Size(100, 22);
            this.ExtractGravityTextBox2.TabIndex = 32;
            this.ExtractGravityTextBox2.Text = "0.0";
            // 
            // ExtractSRMTextBox2
            // 
            this.ExtractSRMTextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExtractSRMTextBox2.Location = new System.Drawing.Point(307, 178);
            this.ExtractSRMTextBox2.Name = "ExtractSRMTextBox2";
            this.ExtractSRMTextBox2.Size = new System.Drawing.Size(98, 22);
            this.ExtractSRMTextBox2.TabIndex = 33;
            this.ExtractSRMTextBox2.Text = "0.0";
            // 
            // DbComboBox2
            // 
            this.DbComboBox2.FormattingEnabled = true;
            this.DbComboBox2.Location = new System.Drawing.Point(28, 127);
            this.DbComboBox2.Name = "DbComboBox2";
            this.DbComboBox2.Size = new System.Drawing.Size(225, 24);
            this.DbComboBox2.TabIndex = 34;
            this.DbComboBox2.SelectedIndexChanged += new System.EventHandler(this.DbComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Pounds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Gravity Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(320, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Lovibond";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DbComboBox2);
            this.Controls.Add(this.ExtractSRMTextBox2);
            this.Controls.Add(this.ExtractGravityTextBox2);
            this.Controls.Add(this.ExtractPoundsTextBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtractGravityTextBox1);
            this.Controls.Add(this.ExtractSRMTextBox1);
            this.Controls.Add(this.ExtractPoundsTextBox1);
            this.Controls.Add(this.DbComboBox1);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.BatchSizeTextBox);
            this.Controls.Add(this.batchSizeLabel);
            this.Controls.Add(this.estimatedColorLabel);
            this.Controls.Add(this.EstimatedOGTextBox);
            this.Controls.Add(this.EstimatedColorTextBox);
            this.Controls.Add(this.estimatedOGLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.GravityTextBox2);
            this.Controls.Add(this.SRMTextBox2);
            this.Controls.Add(this.PoundsTextBox2);
            this.Controls.Add(this.grain2Label);
            this.Controls.Add(this.grain1Label);
            this.Controls.Add(this.srmLabel);
            this.Controls.Add(this.SRMTextBox1);
            this.Controls.Add(this.gravityLabel);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.GravityTextBox1);
            this.Controls.Add(this.PoundsTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Brewing Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PoundsTextBox1;
        private System.Windows.Forms.TextBox GravityTextBox1;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label gravityLabel;
        private System.Windows.Forms.TextBox SRMTextBox1;
        private System.Windows.Forms.Label srmLabel;
        private System.Windows.Forms.Label grain1Label;
        private System.Windows.Forms.Label grain2Label;
        private System.Windows.Forms.TextBox PoundsTextBox2;
        private System.Windows.Forms.TextBox SRMTextBox2;
        private System.Windows.Forms.TextBox GravityTextBox2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label estimatedOGLabel;
        private System.Windows.Forms.TextBox EstimatedColorTextBox;
        private System.Windows.Forms.TextBox EstimatedOGTextBox;
        private System.Windows.Forms.Label estimatedColorLabel;
        private System.Windows.Forms.Label batchSizeLabel;
        private System.Windows.Forms.TextBox BatchSizeTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.ComboBox DbComboBox1;
        private System.Windows.Forms.TextBox ExtractPoundsTextBox1;
        private System.Windows.Forms.TextBox ExtractGravityTextBox1;
        private System.Windows.Forms.TextBox ExtractSRMTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExtractSRMTextBox2;
        private System.Windows.Forms.TextBox ExtractGravityTextBox2;
        private System.Windows.Forms.TextBox ExtractPoundsTextBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DbComboBox2;
    }
}

