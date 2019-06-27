using GameForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameForum.ViewModels.Forum
{
    public class ForumIndexViewModel
    {
        public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
