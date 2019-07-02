using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.Models
{
    public class PostReplyModel
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public DateTime Created { get; set; }
    }
}
