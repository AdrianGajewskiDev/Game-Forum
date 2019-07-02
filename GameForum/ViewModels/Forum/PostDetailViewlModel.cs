using GameForum.Data.Models;
using GameForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.ViewModels.Forum
{
    public class PostDetailViewlModel
    {
        public int ID { get; set; }
        public int ForumID { get; set; }
        public string Title { get; set; }
        public string Content { get; set;}
        public string AuthorName { get; set; }
        public IEnumerable<PostReplyModel> Replies { get; set; }
        public DateTime Created { get; set; }
    }
}
