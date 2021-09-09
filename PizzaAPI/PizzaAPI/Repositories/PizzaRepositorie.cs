using Microsoft.EntityFrameworkCore;
using PizzaAPI.DTOS;
using PizzaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaAPI.Repositories
{
    public class PizzaRepositorie : IPizzaRepositorie
    {
        private readonly DataContext _context;

        public PizzaRepositorie(DataContext context)
        {
            _context = context;
        }

        public async Task<PizzaModel> AddLikesOrDislikes(PizzaDescriptionDto pizza)
        {
            var pizzaToUpdate = await _context.Pizzas.FirstOrDefaultAsync(e => e.Id == pizza.Id);
            if (pizzaToUpdate != null)
            {
                pizzaToUpdate.Like = pizza.Like;
                pizzaToUpdate.Dislike = pizza.Dislike;

                await _context.SaveChangesAsync();

                return pizzaToUpdate;
            }
            return null;
        }

        public async Task<IEnumerable<PizzaModel>> GetAll()
        {
            return await _context.Pizzas.ToListAsync();
        }

        public async Task<PizzaModel> GetById(int id)
        {
            return await _context.Pizzas.FindAsync(id);
        }

        public async Task<SuggestedPizzaModel> AddNewPizza(SuggestedPizzaModel suggestedPizza)
        {
            var result = await _context.SuggestedPizzas.AddAsync(suggestedPizza);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<SuggestedPizzaModel>> GetAllSuggestedPizzas()
        {
            return await _context.SuggestedPizzas.ToListAsync();
        }
    }
}