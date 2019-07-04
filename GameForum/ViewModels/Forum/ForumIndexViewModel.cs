using GameForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.ViewModels.Forum
{
    public class ForumIndexViewModel
    {
        public string SearchQuery { get; set; }
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
