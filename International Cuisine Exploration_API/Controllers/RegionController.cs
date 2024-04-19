using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepo repo;

        public RegionController(IRegionRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Regions> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(Regions region)
        {
            repo.Create(region);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, Regions updatedRegion)
        {
            var region = repo.UpdateById(id, updatedRegion);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var region = repo.DeleteById(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }
    }
}
