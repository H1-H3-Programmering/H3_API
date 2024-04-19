using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepo repo;

        public CountryController(ICountryRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Country> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(Country country)
        {
            repo.Create(country);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, Country updatedCountry)
        {
            var country = repo.UpdateById(id, updatedCountry);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var country = repo.DeleteById(id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }
    }
}
