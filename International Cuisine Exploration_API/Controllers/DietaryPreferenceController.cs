using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DietaryPreferenceController : ControllerBase
    {
        private readonly IDietaryPreferenceRepo repo;

        public DietaryPreferenceController(IDietaryPreferenceRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<DietaryPreference> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(DietaryPreference dietaryPreference)
        {
            repo.Create(dietaryPreference);
        }
    }
}
