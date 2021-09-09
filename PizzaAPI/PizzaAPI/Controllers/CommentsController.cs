using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Models;
using PizzaAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaAPI.Helpers;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentsRepository _repository;

        public CommentsController(ICommentsRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comments>>> GetPizzas()
        {
            var pizzas = await _repository.GetAll();
            return Ok(pizzas);
        }

        [HttpPost]
        public void AddSuggestedPizza(Comments comments)
        {
            var upperComment = comments.Comment;
            comments.Comment = upperComment.UppercaseFirst();
            comments.TimeAdded = DateTime.Now.ToString("M/dd/yy HH:mm:ss");
            if (comments.Initials == string.Empty)
            {
                comments.Initials = "Gal Anonim :)";
            }
            _repository.AddNewComment(comments);
        }
    }
}