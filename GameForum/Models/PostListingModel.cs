using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.Models
{
    public class PostListingModel
    {
        public int ID { get; set; }
        public int ForumID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime Created { get; set; }
    }
}
