using BeerCalculatorWinForms;
using System.Drawing;
using System.Linq;

namespace BeerCalculatorClassLibrary.Models
{
    public class Batch
    {
        public Batch()
        {
            Recipe = new Recipe();
        }

        public Recipe Recipe { get; set; }
        public double Gallons { get; set; }

        public double Gravity
        {
            get { return this.GetGravity(); }
        }
        public double SRM
        {
            get { return this.GetSRM(); }
        }
        public Color Color
        {
            get { return this.SRM.GetColor(); }
        }
    }
    public static class BatchExtensions
    {
        public static bool IsValid(this Batch batch)
        {
            if (batch.Gallons < 1)
            {
                return false;
            }

            foreach (var grain in batch.Recipe.Ingredients.OfType<Grain>())
            {
                if (grain.GravityPoints <= 0 || grain.SRMPoints <= 0 || grain.Pounds <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
