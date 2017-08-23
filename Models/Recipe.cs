using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CarSales2.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        public ICollection<Ingredient>Ingredients { get; set; }

        public Recipe()
        {
            Ingredients = new Collection<Ingredient>();
        }
    }
}
