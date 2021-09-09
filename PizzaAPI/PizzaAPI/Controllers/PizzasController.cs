using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.DTOS;
using PizzaAPI.Models;
using PizzaAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using PizzaAPI.Helpers;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPizzaRepositorie _pizzaRepositorie;

        public PizzasController(IMapper mapper, IPizzaRepositorie pizzaRepositorie)
        {
            _mapper = mapper;
            _pizzaRepositorie = pizzaRepositorie;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PizzaModel>>> GetPizzas()
        {
            var pizzas = await _pizzaRepositorie.GetAll();
            var pizzasToReturn = _mapper.Map<IEnumerable<PizzaOverwiewDto>>(pizzas);
            return Ok(pizzasToReturn);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaDescriptionDto>> GetPizza(int id)
        {
            var pizza = await _pizzaRepositorie.GetById(id);
            return _mapper.Map<PizzaDescriptionDto>(pizza);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PizzaModel>> CountLikes(PizzaDescriptionDto pizza)
        {
            return await _pizzaRepositorie.AddLikesOrDislikes(pizza);
        }

        [HttpPost]
        public void AddSuggestedPizza(SuggestedPizzaModel suggestedPizza)
        {
            var upperName = suggestedPizza.Name;
            suggestedPizza.Name = upperName.UppercaseFirst();
            var upperDescription = suggestedPizza.Description;
            suggestedPizza.Description = upperDescription.UppercaseFirst();
            var upperIngridients = suggestedPizza.Ingridients;
            suggestedPizza.Ingridients = upperIngridients.UppercaseFirst();
            _pizzaRepositorie.AddNewPizza(suggestedPizza);
        }
    }
}