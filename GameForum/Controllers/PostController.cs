using System;
using System.Collections.Generic;
using System.Linq;
using GameForum.Data;
using GameForum.Data.Models;
using GameForum.Models;
using GameForum.ViewModels.Forum;
using Microsoft.AspNetCore.Mvc;

namespace GameForum.Controllers
{
    public class PostController : Controller
    {
        private readonly IPost _postService;

        public PostController(IPost post)
        {
            _postService = post;
        }

        public IActionResult Index(int id)
        {
            var post = _postService.GetByID(id);

            IEnumerable<PostReplyModel> postReplies;

            if (post.PostReplies != null)
            {
                postReplies = BuildPostReplyModel(post.PostReplies);
            }
            else
            {
                postReplies = new List<PostReplyModel>();
            }

            var model = new PostDetailViewlModel
            {
                AuthorName = post.AuthorName,
                Content = post.Content,
                Created = post.Created,
                Title = post.Title,
                ID = post.ID,
                ForumID = post.ForumID,
                Replies = postReplies
            };

            return View(model);

        }

        private IEnumerable<PostReplyModel> BuildPostReplyModel(IEnumerable<PostReply> postReplies)
        {
            return postReplies.Select(post => new PostReplyModel
            {
                AuthorName = post.Author,
                Content = post.Content,
                Created  = post.Created,
                ID = post.ID,
                PostID = post.PostID
            });
        }
    }
}