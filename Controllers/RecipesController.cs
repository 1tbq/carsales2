using AutoMapper;
using CarSales2.Controllers.Resources;
using CarSales2.Models;
using CarSales2.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarSales2.Controllers
{
    public class RecipesController:Controller
    {
        RecipeDbContext context;
        IMapper mapper;
        public RecipesController(RecipeDbContext context,IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/recipes")]
        public async Task<IEnumerable<RecipeResource>> GetRecipes()
        {
            var recipes = await context.Recipes.Include(m => m.Ingredients).ToListAsync();

            return mapper.Map<List<Recipe>, List<RecipeResource>>(recipes);

        }
    }
}
