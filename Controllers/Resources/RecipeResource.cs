using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarSales2.Controllers.Resources
{
    public class RecipeResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }

        public ICollection<IngredientResource> Ingredients { get; set; }

        public RecipeResource()
        {
            Ingredients = new Collection<IngredientResource>();
        }
    }
}
