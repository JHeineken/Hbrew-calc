using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerCalculator
{
    public class Grain
    {
        //future interface needed for varying types of grain (mash, steeping)

        public double pounds { get;  set; }
        public double gPoints { get; set; }
        public double srmPoints { get; set; } 

    }

}
