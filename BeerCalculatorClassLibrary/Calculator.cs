using BeerCalculatorClassLibrary.Models;
using BeerCalculatorWinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace BeerCalculatorClassLibrary
{
    public static class Calculator
    {
        public static double GetGravity(this Batch batch)
        { 
            var grains = batch.Recipe.Ingredients.OfType<Grain>();
            var gravity = grains.Select(grain => grain.Pounds * grain.GravityPoints).Sum() / batch.Gallons;
            return gravity.ConvertGravity();
        }

        public static double GetSRM(this Batch batch)
        {
            var grains = batch.Recipe.Ingredients.OfType<Grain>();
            var srm = grains.Select(grain => grain.Pounds * grain.SRMPoints).Sum() / batch.Gallons;
            return srm.ApplyMoreyEquation();
        }
        public static Color GetColor(this double srm)
        {
            srm = Math.Round(srm);
            var SRMtoRGB = File.ReadLines(@".\Resources\SRMtoRGB.csv")
                .Select(line => line.Split(','))
                .ToDictionary(
                    line => Convert.ToDouble(line[0]),
                    line => Color.FromArgb(Convert.ToInt32(line[1]), Convert.ToInt32(line[2]), Convert.ToInt32(line[3]))
                );

            var MinSRM = SRMtoRGB.Keys.Min();
            var MaxSRM = SRMtoRGB.Keys.Max();

            if (srm < Constants.MinSRM) { srm = Constants.MinSRM; }
            if (srm > Constants.MaxSRM) { srm = Constants.MaxSRM; }

            return SRMtoRGB[srm];
        }
        public static double ConvertGravity(this double gravity)
        {
            return Math.Round((gravity * .001 + 1), 3);
        }
        public static double ApplyMoreyEquation(this double srm)
        {
            //https://brewgr.com/calculations/srm-beer-color - Morey equation reference
            if (srm > 8)
            {
                srm *= Constants.MoreyCoefficient;
            }

            return Math.Round(srm, 1);

        }
    }
}
