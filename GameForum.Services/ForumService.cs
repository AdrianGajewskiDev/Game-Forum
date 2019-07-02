using GameForum.Data;
using GameForum.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace GameForum.Services
{
    public class ForumService : IForum
    {
        private readonly ApplicationDbContext _dbContext;

         public ForumService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public IEnumerable<Forum> GetAll()
        {
            return _dbContext.Forums;
        }

        public Forum GetById(int id)
        {
            return _dbContext.Forums.Where(x => x.ID == id).FirstOrDefault();
        }
    }
}
