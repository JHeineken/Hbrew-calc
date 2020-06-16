using BeerCalculatorWinForms;
using System;

namespace BeerCalculatorClassLibrary
{
    public static class Calculations
    {

        public static double GetGrav(Grain g1, Grain g2, double gal)
        {
            var g1Grav = g1.Pounds * g1.GravityPoints;
            var g2Grav = g2.Pounds * g2.GravityPoints;
            var totalGrav = (g1Grav + g2Grav) / gal;

            return totalGrav;
        }
        public static double GetColor(Grain g1, Grain g2, double gal)
        {

            var g1Color = g1.Pounds * g1.SRMPoints;
            var g2Color = g2.Pounds * g2.SRMPoints;
            var totalColor = (g1Color + g2Color) / gal;

            //https://brewgr.com/calculations/srm-beer-color - Morey equation reference
            if (totalColor > 8)
            {
                totalColor = totalColor * .69 * 1.49;
            }

            return totalColor;
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
