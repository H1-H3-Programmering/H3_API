using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserHistoryController : ControllerBase
    {
        private readonly IUserHistoryRepo repo;

        public UserHistoryController(IUserHistoryRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<UserHistory> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(UserHistory userHistory)
        {
            repo.Create(userHistory);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, UserHistory updatedUserHistory)
        {
            var userHistory = repo.UpdateById(id, updatedUserHistory);
            if (userHistory == null)
            {
                return NotFound();
            }
            return Ok(userHistory);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var userHistory = repo.DeleteById(id);
            if (userHistory == null)
            {
                return NotFound();
            }
            return Ok(userHistory);
        }
    }
}
