﻿using BeerCalculatorClassLibrary;
using BeerCalculatorClassLibrary.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BeerCalculatorWinForms
{
    /*Upcoming implementations:
    -Search function
    -Combobox (?) w/ database of grain types -- data binding
    -Visual representation for user of ComboBox / search selection  -- of all grains to be calculated
    -add/remove grains feature to compliment above point
    */

    public partial class MainForm : Form
    {
        private Grain _grain1;
        private Grain _grain2;
        private Batch _batch;

        public MainForm()
        {
            InitializeComponent();
            _grain1 = new Grain(); 
            _grain2 = new Grain();
            _batch = new Batch();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ColorLabel.Text = "      ";
            BatchSizeTextBox.DataBindings.Add("Text", _batch, "Gallons");

            PoundsTextBox1.DataBindings.Add("Text", _grain1, "Pounds");
            GravityTextBox1.DataBindings.Add("Text", _grain1, "GravityPoints");
            SRMTextBox1.DataBindings.Add("Text", _grain1, "SRMPoints");

            PoundsTextBox2.DataBindings.Add("Text", _grain2, "Pounds");
            GravityTextBox2.DataBindings.Add("Text", _grain2, "GravityPoints");
            SRMTextBox2.DataBindings.Add("Text", _grain2, "SRMPoints");

        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            _batch.Recipe.Ingredients.Clear();
            _batch.Recipe.Ingredients.Add(_grain1);
            _batch.Recipe.Ingredients.Add(_grain2);

            if (_batch.IsValid())
            {

                EstimatedOGTextBox.Text = _batch.Gravity.ToString();
                EstimatedColorTextBox.Text = _batch.SRM.ToString();
                ColorLabel.BackColor = _batch.Color;
            }
            else
            {
                //TODO
            }
        }

        private void OnNumericTextBoxValidating(object sender, CancelEventArgs e)
        {
            var box = sender as TextBox;
            if (double.TryParse(box.Text, out _))
            {
                errorProvider.Clear();
                e.Cancel = false;
            }
            else
            {
                box.Text = string.Empty;
                errorProvider.SetError(box, "This field only accepts whole numbers and decimals");
                e.Cancel = true;
            }

        }
    }
}
