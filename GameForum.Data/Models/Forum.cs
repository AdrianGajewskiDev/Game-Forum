using System;
using System.Collections.Generic;
using System.Text;

namespace GameForum.Data.Models
{
    public class Forum
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    
        public IEnumerable<Post> Posts { get; set; }
    }
}
