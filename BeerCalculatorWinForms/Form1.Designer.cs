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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PoundsTextBox1
            // 
            this.PoundsTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PoundsTextBox1.Location = new System.Drawing.Point(123, 48);
            this.PoundsTextBox1.Name = "PoundsTextBox1";
            this.PoundsTextBox1.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox1.TabIndex = 0;
            this.PoundsTextBox1.Text = "0.0";
            this.PoundsTextBox1.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // GravityTextBox1
            // 
            this.GravityTextBox1.Location = new System.Drawing.Point(229, 47);
            this.GravityTextBox1.Name = "GravityTextBox1";
            this.GravityTextBox1.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox1.TabIndex = 1;
            this.GravityTextBox1.Text = "0";
            this.GravityTextBox1.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // poundsLabel
            // 
            this.poundsLabel.AutoSize = true;
            this.poundsLabel.Location = new System.Drawing.Point(142, 18);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(56, 17);
            this.poundsLabel.TabIndex = 7;
            this.poundsLabel.Text = "Pounds";
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(233, 18);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(96, 17);
            this.gravityLabel.TabIndex = 10;
            this.gravityLabel.Text = "Gravity Points";
            // 
            // SRMTextBox1
            // 
            this.SRMTextBox1.Location = new System.Drawing.Point(335, 47);
            this.SRMTextBox1.Name = "SRMTextBox1";
            this.SRMTextBox1.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox1.TabIndex = 2;
            this.SRMTextBox1.Text = "0";
            this.SRMTextBox1.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // srmLabel
            // 
            this.srmLabel.AutoSize = true;
            this.srmLabel.Location = new System.Drawing.Point(352, 18);
            this.srmLabel.Name = "srmLabel";
            this.srmLabel.Size = new System.Drawing.Size(66, 17);
            this.srmLabel.TabIndex = 11;
            this.srmLabel.Text = "Lovibond";
            // 
            // grain1Label
            // 
            this.grain1Label.AutoSize = true;
            this.grain1Label.Location = new System.Drawing.Point(31, 53);
            this.grain1Label.Name = "grain1Label";
            this.grain1Label.Size = new System.Drawing.Size(55, 17);
            this.grain1Label.TabIndex = 8;
            this.grain1Label.Text = "Grain 1";
            // 
            // grain2Label
            // 
            this.grain2Label.AutoSize = true;
            this.grain2Label.Location = new System.Drawing.Point(31, 96);
            this.grain2Label.Name = "grain2Label";
            this.grain2Label.Size = new System.Drawing.Size(55, 17);
            this.grain2Label.TabIndex = 9;
            this.grain2Label.Text = "Grain 2";
            // 
            // PoundsTextBox2
            // 
            this.PoundsTextBox2.Location = new System.Drawing.Point(123, 91);
            this.PoundsTextBox2.Name = "PoundsTextBox2";
            this.PoundsTextBox2.Size = new System.Drawing.Size(100, 22);
            this.PoundsTextBox2.TabIndex = 3;
            this.PoundsTextBox2.Text = "0.0";
            this.PoundsTextBox2.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // SRMTextBox2
            // 
            this.SRMTextBox2.Location = new System.Drawing.Point(335, 91);
            this.SRMTextBox2.Name = "SRMTextBox2";
            this.SRMTextBox2.Size = new System.Drawing.Size(100, 22);
            this.SRMTextBox2.TabIndex = 5;
            this.SRMTextBox2.Text = "0";
            this.SRMTextBox2.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // GravityTextBox2
            // 
            this.GravityTextBox2.Location = new System.Drawing.Point(229, 91);
            this.GravityTextBox2.Name = "GravityTextBox2";
            this.GravityTextBox2.Size = new System.Drawing.Size(100, 22);
            this.GravityTextBox2.TabIndex = 4;
            this.GravityTextBox2.Text = "0";
            this.GravityTextBox2.TextChanged += new System.EventHandler(this.TextBoxChange);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 299);
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
            this.estimatedOGLabel.Location = new System.Drawing.Point(173, 299);
            this.estimatedOGLabel.Name = "estimatedOGLabel";
            this.estimatedOGLabel.Size = new System.Drawing.Size(96, 17);
            this.estimatedOGLabel.TabIndex = 14;
            this.estimatedOGLabel.Text = "Estimated OG";
            // 
            // EstimatedColorTextBox
            // 
            this.EstimatedColorTextBox.Location = new System.Drawing.Point(302, 345);
            this.EstimatedColorTextBox.Multiline = true;
            this.EstimatedColorTextBox.Name = "EstimatedColorTextBox";
            this.EstimatedColorTextBox.ReadOnly = true;
            this.EstimatedColorTextBox.Size = new System.Drawing.Size(116, 22);
            this.EstimatedColorTextBox.TabIndex = 15;
            this.EstimatedColorTextBox.Text = "0";
            // 
            // EstimatedOGTextBox
            // 
            this.EstimatedOGTextBox.Location = new System.Drawing.Point(169, 345);
            this.EstimatedOGTextBox.Name = "EstimatedOGTextBox";
            this.EstimatedOGTextBox.ReadOnly = true;
            this.EstimatedOGTextBox.Size = new System.Drawing.Size(100, 22);
            this.EstimatedOGTextBox.TabIndex = 16;
            this.EstimatedOGTextBox.Text = "0.00";
            // 
            // estimatedColorLabel
            // 
            this.estimatedColorLabel.AutoSize = true;
            this.estimatedColorLabel.Location = new System.Drawing.Point(298, 299);
            this.estimatedColorLabel.Name = "estimatedColorLabel";
            this.estimatedColorLabel.Size = new System.Drawing.Size(151, 17);
            this.estimatedColorLabel.TabIndex = 17;
            this.estimatedColorLabel.Text = "Estimated Color (SRM)";
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(510, 18);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(108, 17);
            this.batchSizeLabel.TabIndex = 18;
            this.batchSizeLabel.Text = "Batch Size (gal)";
            // 
            // BatchSizeTextBox
            // 
            this.BatchSizeTextBox.Location = new System.Drawing.Point(534, 47);
            this.BatchSizeTextBox.Name = "BatchSizeTextBox";
            this.BatchSizeTextBox.Size = new System.Drawing.Size(58, 22);
            this.BatchSizeTextBox.TabIndex = 6;
            this.BatchSizeTextBox.Text = "1";
            this.BatchSizeTextBox.TextChanged += new System.EventHandler(this.TextBoxChange);
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
            this.ColorLabel.Location = new System.Drawing.Point(321, 370);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(69, 39);
            this.ColorLabel.TabIndex = 19;
            this.ColorLabel.Text = "Color";
            this.ColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 450);
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
    }
}

