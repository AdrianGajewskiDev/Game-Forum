using System;
using System.Collections.Generic;
using System.Text;

namespace GameForum.Data.Models
{
    public class Post
    {
        public int ID { get; set; }
        public int ForumID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<PostReply> PostReplies { get; set; }
    }
}
