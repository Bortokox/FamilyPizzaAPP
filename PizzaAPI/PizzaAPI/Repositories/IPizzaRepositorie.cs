using PizzaAPI.DTOS;
using PizzaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaAPI.Repositories
{
    public interface IPizzaRepositorie
    {
        Task<IEnumerable<PizzaModel>> GetAll();

        Task<IEnumerable<SuggestedPizzaModel>> GetAllSuggestedPizzas();

        Task<PizzaModel> GetById(int id);

        Task<PizzaModel> AddLikesOrDislikes(PizzaDescriptionDto pizza);

        Task<SuggestedPizzaModel> AddNewPizza(SuggestedPizzaModel suggestedPizza);
    }
}