using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepo repo;

        public LanguageController(ILanguageRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Language> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(Language language)
        {
            repo.Create(language);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, Language updatedLanguage)
        {
            var language = repo.UpdateById(id, updatedLanguage);
            if (language == null)
            {
                return NotFound();
            }
            return Ok(language);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var language = repo.DeleteById(id);
            if (language == null)
            {
                return NotFound();
            }
            return Ok(language);
        }
    }
}
