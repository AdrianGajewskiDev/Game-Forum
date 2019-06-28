using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameForum.Data;
using GameForum.Data.Models;

namespace GameForum.Services
{
    public class PostService : IPost
    {
        private readonly ApplicationDbContext _dbContext;

        public PostService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public async Task AddPost(Post post)
        {
            _dbContext.Posts.Add(post);

            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<Post> GetAll()
        {
            return _dbContext.Posts;
        }

        public IEnumerable<Post> GetAllByForumID(int id)
        {
            return _dbContext.Posts.Where(x => x.ForumID == id);
        }

        public Post GetByID(int id)
        {
            return GetAll().Where(x => x.ID == id).FirstOrDefault();
        }
    }
}
