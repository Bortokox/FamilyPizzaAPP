using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.DTOS;
using PizzaAPI.Models;
using PizzaAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuggestedPizzasController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPizzaRepositorie _pizzaRepositorie;

        public SuggestedPizzasController(IMapper mapper, IPizzaRepositorie pizzaRepositorie)
        {
            _mapper = mapper;
            _pizzaRepositorie = pizzaRepositorie;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuggestedPizzaModel>>> GetSuggestedPizzas()
        {
            var suggestedPizzas = await _pizzaRepositorie.GetAllSuggestedPizzas();
            var pizzaToSend = _mapper.Map<IEnumerable<SuggestedPizzasDto>>(suggestedPizzas);
            return Ok(pizzaToSend);
        }
    }
}