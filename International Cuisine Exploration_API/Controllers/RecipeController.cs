using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeRepo repo;

        public RecipeController(IRecipeRepo repo)
        {
            this.repo = repo;
        }



        //get: api/<samuraicontroller>
        [HttpGet] // this is a dataannotation / attribute
        public List<Recipe> GetAll()
        {
            // If I want to DEBUG
            return repo.GetAll();
        }

        [HttpGet]
        List<Ingredient> GetIngredientsForRecipe(int recipeId)
        {
            return repo.GetIngredientsForRecipe(recipeId);
        }

        // Create: api/<SamuraiController>
        [HttpPost]
        public void Create(Recipe recipe)
        {
            repo.Create(recipe);

        }

        [HttpPut("{id}")]
        public Recipe UpdateById(int id, Recipe updatedRecipe)
        {
            return repo.UpdateById(id, updatedRecipe);
        }

        [HttpDelete("{id}")]
        public Recipe DeleteById(int id)
        {
            return repo.DeleteById(id);
        }
    }
}
