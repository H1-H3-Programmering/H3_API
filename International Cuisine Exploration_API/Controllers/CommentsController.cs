using ICE_Repository.Interfaces;
using ICE_Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace International_Cuisine_Exploration_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentRepo repo;

        public CommentController(ICommentRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public List<Comments> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPost]
        public void Create(Comments comment)
        {
            repo.Create(comment);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, Comments updatedComment)
        {
            var comment = repo.UpdateById(id, updatedComment);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var comment = repo.DeleteById(id);
            if (comment == null)
            {
                return NotFound();
            }
            return Ok(comment);
        }
    }
}
