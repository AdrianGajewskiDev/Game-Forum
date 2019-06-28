using GameForum.Models;
using System.Collections.Generic;

namespace GameForum.ViewModels.Forum
{
    public class ForumTopicViewModel
    {
        public string ForumTitle { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}
