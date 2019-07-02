using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.Models
{
    public class NewReplyModel
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string ForumTitle { get; set; }
        public string Title { get; set; }
        public string Content { get; set;}
        public DateTime Created { get; set; }
    }
}
