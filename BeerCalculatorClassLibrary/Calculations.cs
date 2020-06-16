using BeerCalculatorWinForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace BeerCalculatorClassLibrary
{
    public static class Calculations
    {

        public static Color GetColor(Int32 srm)
        {
            var SRMtoRGB = File.ReadLines(@"Resources\SRMtoRGB.csv")
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
        public static double GetGrav(Grain g1, Grain g2, double gal)
        {
            var g1Grav = g1.Pounds * g1.GravityPoints;
            var g2Grav = g2.Pounds * g2.GravityPoints;
            var totalGrav = (g1Grav + g2Grav) / gal;

            return totalGrav;
        }
        public static double GetSRM(Grain g1, Grain g2, double gal)
        {

            var g1TotalSRM = g1.Pounds * g1.SRMPoints;
            var g2TotalSRM = g2.Pounds * g2.SRMPoints;
            var totalSRM = (g1TotalSRM + g2TotalSRM) / gal;

            //https://brewgr.com/calculations/srm-beer-color - Morey equation reference
            if (totalSRM > 8)
            {
                totalSRM = totalSRM * .69 * 1.49;
            }

            return totalSRM;
        }
        public static double ConvertFormat(double gravResult)
        {
            //1.0xx format
            gravResult = gravResult * .001 + 1;
            gravResult = Math.Round(gravResult, 3);
            return gravResult;
        }


    }
}
