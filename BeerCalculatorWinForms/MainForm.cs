using BeerCalculatorClassLibrary;
using BeerCalculatorClassLibrary.Models;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BeerCalculatorWinForms
{

    public partial class MainForm : Form
    {
        private Grain _grain1;
        private Grain _grain2;
        private Batch _batch;
        private Grain _grainExtract1;
        private Grain _grainExtract2;


        public MainForm()
        {
            InitializeComponent();
            _grain1 = new Grain(); 
            _grain2 = new Grain();
            _batch = new Batch();
            _grainExtract1 = new Grain();
            _grainExtract2 = new Grain();

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

            ExtractPoundsTextBox1.DataBindings.Add("Text", _grainExtract1, "Pounds", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractGravityTextBox1.DataBindings.Add("Text", _grainExtract1, "GravityPoints", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractSRMTextBox1.DataBindings.Add("Text", _grainExtract1, "SRMPoints", true, DataSourceUpdateMode.OnPropertyChanged);

            ExtractPoundsTextBox2.DataBindings.Add("Text", _grainExtract2, "Pounds", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractGravityTextBox2.DataBindings.Add("Text", _grainExtract2, "GravityPoints", true, DataSourceUpdateMode.OnPropertyChanged);
            ExtractSRMTextBox2.DataBindings.Add("Text", _grainExtract2, "SRMPoints", true, DataSourceUpdateMode.OnPropertyChanged);

            DbComboBox1.DisplayMember = "Name";
            DbComboBox1.ValueMember = "ID";
            var extracts = SqliteDataAccess.LoadExtracts();
            extracts.Insert(0, new MaltExtract { ID = -1, Name = "-- Select Malt Extract --" });
            DbComboBox1.DataSource = extracts;

            DbComboBox2.DisplayMember = "Name";
            DbComboBox2.ValueMember = "ID";
            var extracts2 = SqliteDataAccess.LoadExtracts();
            extracts2.Insert(0, new MaltExtract { ID = -1, Name = "-- Select Malt Extract --" });
            DbComboBox2.DataSource = extracts2;
        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {
            _batch.Recipe.Ingredients.Clear();
            _batch.Recipe.Ingredients.Add(_grain1);
            _batch.Recipe.Ingredients.Add(_grain2);
            _batch.Recipe.Ingredients.Add(_grainExtract1);
            _batch.Recipe.Ingredients.Add(_grainExtract2);

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
            if (DbComboBox1.SelectedIndex > -1)
            {
                var maltExtract = DbComboBox1.Items[DbComboBox1.SelectedIndex] as MaltExtract;
                ExtractGravityTextBox1.Text = maltExtract.GravityPoints.ToString();
                ExtractSRMTextBox1.Text = maltExtract.SRMPoints.ToString();
            }
            if (DbComboBox2.SelectedIndex > -1)
            {
                var maltExtract2 = DbComboBox2.Items[DbComboBox2.SelectedIndex] as MaltExtract;
                ExtractGravityTextBox2.Text = maltExtract2.GravityPoints.ToString();
                ExtractSRMTextBox2.Text = maltExtract2.SRMPoints.ToString();
            }
        }
    }
}
