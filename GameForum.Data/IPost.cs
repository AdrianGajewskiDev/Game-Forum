using GameForum.Data.Models;
using System.Collections.Generic;

namespace GameForum.Data
{
    public interface IPost
    {
        Post GetByID(int id);
        IEnumerable<Post> GetAllByForumID(int id);
        IEnumerable<Post> GetAll();
    }
}
