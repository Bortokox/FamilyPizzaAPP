using Microsoft.EntityFrameworkCore;
using PizzaAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaAPI.Repositories
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly DataContext _context;

        public CommentsRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Comments> AddNewComment(Comments comment)
        {
            var result = await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<Comments>> GetAll()
        {
            return await _context.Comments.ToListAsync();
        }
    }
}