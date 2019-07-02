using System;
using System.Collections.Generic;
using System.Text;

namespace GameForum.Data.Models
{
    public class PostReply
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
    }
}
