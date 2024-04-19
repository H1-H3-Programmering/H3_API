using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeTagController : ControllerBase
    {
        private readonly IRecipeTagRepo repo;

        public RecipeTagController(IRecipeTagRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<RecipeTag> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(RecipeTag recipeTag)
        {
            repo.Create(recipeTag);
        }

        [HttpDelete("{recipeId}")]
        public void DeleteByRecipeId(int recipeId)
        {
            repo.DeleteByRecipeId(recipeId);
        }
    }
}
