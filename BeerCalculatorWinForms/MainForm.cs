using BeerCalculatorClassLibrary;
using BeerCalculatorClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeerCalculatorWinForms
{

    public partial class MainForm : Form
    {
        private Grain _grain1;
        private Grain _grain2;
        private Batch _batch;
        private Grain _grainExtract;


        public MainForm()
        {
            InitializeComponent();
            _grain1 = new Grain(); 
            _grain2 = new Grain();
            _batch = new Batch();
            _grainExtract = new Grain();

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ColorLabel.Text = "      ";
            BatchSizeTextBox.DataBindings.Add("Text", _batch, "Gallons", true, DataSourceUpdateMode.OnPropertyChanged);

            PoundsTextBox1.DataBindings.Add("Text", _grain1, "Pounds", true, DataSourceUpdateMode.OnPropertyChanged);
            GravityTextBox1.DataBindings.Add("Text", _grain1, "GravityPoints", true, DataSourceUpdateMode.OnPropertyChanged);
            SRMTextBox1.DataBindings.Add("Text", _grain1, "SRMPoints", true, DataSourceUpdateMode.OnPropertyChanged);

            PoundsTextBox2.DataBindings.Add("Text", _grain2, "Pounds", true, DataSourceUpdateMode.OnPropertyChanged);
            GravityTextBox2.DataBindings.Add("Text", _grain2, "GravityPoints", true, DataSourceUpdateMode.OnPropertyChanged);
            SRMTextBox2.DataBindings.Add("Text", _grain2, "SRMPoints", true, DataSourceUpdateMode.OnPropertyChanged);

            ExtractPoundsTextBox.DataBindings.Add("Text", _grainExtract, "Pounds", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractGravityTextBox.DataBindings.Add("Text", _grainExtract, "GravityPoints", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractSRMTextBox.DataBindings.Add("Text", _grainExtract, "SRMPoints", true, DataSourceUpdateMode.OnPropertyChanged);
           
            DbComboBox.DisplayMember = "Name";
            DbComboBox.ValueMember = "ID";
            var extracts = SqliteDataAccess.LoadExtracts();
            extracts.Insert(0, new MaltExtract { ID = -1, Name = "-- Select Malt Extract --" });
            DbComboBox.DataSource = extracts;
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            _batch.Recipe.Ingredients.Clear();
            _batch.Recipe.Ingredients.Add(_grain1);
            _batch.Recipe.Ingredients.Add(_grain2);
            _batch.Recipe.Ingredients.Add(_grainExtract);

            if (_batch.IsValid())
            {
                errorProvider.Clear();
                EstimatedOGTextBox.Text = _batch.Gravity.ToString();
                EstimatedColorTextBox.Text = _batch.SRM.ToString();
                ColorLabel.BackColor = _batch.Color;
            }
            else
            {
                errorProvider.SetError(CalculateButton, "Invalid data entered");
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

        private void DbComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DbComboBox.SelectedIndex > -1)
            {
                var maltExtract = DbComboBox.Items[DbComboBox.SelectedIndex] as MaltExtract;
                ExtractGravityTextBox.Text = maltExtract.GravityPoints.ToString();
                ExtractSRMTextBox.Text = maltExtract.SRMPoints.ToString();
            }
        }
    }
}
