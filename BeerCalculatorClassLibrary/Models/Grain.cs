using BeerCalculatorClassLibrary;

namespace BeerCalculatorWinForms
{
    public class Grain : Ingredient
    {
        //future interface needed for varying types of grain (mash, steeping)
        public double GravityPoints { get; set; }
        public double SRMPoints { get; set; }

    }

}
