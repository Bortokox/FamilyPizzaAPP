using PizzaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaAPI.Repositories
{
    public interface ICommentsRepository
    {
        Task<IEnumerable<Comments>> GetAll();

        Task<Comments> AddNewComment(Comments comment);
    }
}