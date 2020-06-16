using BeerCalculatorClassLibrary;
using System;
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
        private Grain g1;
        private Grain g2;

        public MainForm()
        {
            InitializeComponent();
          g1 = new Grain();
          g2 = new Grain();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            ColorLabel.Text = "      ";

            PoundsTextBox1.DataBindings.Add("Text", g1, "Pounds");
            GravityTextBox1.DataBindings.Add("Text", g1, "GravityPoints");
            SRMTextBox1.DataBindings.Add("Text", g1, "SRMPoints");

            PoundsTextBox2.DataBindings.Add("Text", g2, "Pounds");
            GravityTextBox2.DataBindings.Add("Text", g2, "GravityPoints");
            SRMTextBox2.DataBindings.Add("Text", g2, "SRMPoints");

        }

        private void CalculateButtonClick(object sender, EventArgs e)
        {

            var gal = Convert.ToDouble(BatchSizeTextBox.Text);

            var srmResult = Calculations.GetColor(g1, g2, gal);
            var gravResult = Calculations.GetGrav(g1, g2, gal);


            gravResult = Calculations.ConvertFormat(gravResult);

            EstimatedOGTextBox.Text = Convert.ToString(gravResult);
            EstimatedColorTextBox.Text = Convert.ToString(srmResult);

        }

        private void TextBoxChange(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (double.TryParse(box.Text, out _))
            {
                errorProvider.Clear();
            }
            else
            {
               
                box.Text = string.Empty;
                errorProvider.SetError(box, "Calculator only accepts numbers 0 through 9");

            }

        }
    }
}
