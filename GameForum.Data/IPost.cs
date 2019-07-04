using GameForum.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameForum.Data
{
    public interface IPost
    {
        Post GetByID(int id);
        IEnumerable<Post> GetBySearchQuery(string searchQuery, int id);
        IEnumerable<Post> GetBySearchQuery(string searchQuery);
        IEnumerable<PostReply> GetPostRepliesByPostID(int postID);
        IEnumerable<Post> GetAllByForumID(int id);
        IEnumerable<Post> GetAll();

        Task AddPost(Post post);
        Task AddReply(PostReply postReply);
    }
}
