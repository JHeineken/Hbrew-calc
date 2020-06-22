using System.Collections.Generic;

namespace BeerCalculatorClassLibrary.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public IList<Ingredient> Ingredients { get; set; }
    }
}