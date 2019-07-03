using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.Models
{
    public class NewForumModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Created { get; set; }
    }
}
