using AutoMapper;
using CarSales2.Controllers.Resources;
using CarSales2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSales2.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //if the the propteries of the Model and 
            //modelResource match we dont we just need to do like below
            CreateMap<Recipe, RecipeResource>();
            CreateMap<Ingredient, IngredientResource>();
        }
    }
}
