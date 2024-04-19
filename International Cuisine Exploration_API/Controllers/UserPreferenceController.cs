using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPreferenceController : ControllerBase
    {
        private readonly IUserPreferenceRepo repo;

        public UserPreferenceController(IUserPreferenceRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<UserPreference> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(UserPreference userPreference)
        {
            repo.Create(userPreference);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, UserPreference updatedUserPreference)
        {
            var userPreference = repo.UpdateById(id, updatedUserPreference);
            if (userPreference == null)
            {
                return NotFound();
            }
            return Ok(userPreference);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var userPreference = repo.DeleteById(id);
            if (userPreference == null)
            {
                return NotFound();
            }
            return Ok(userPreference);
        }
    }
}
