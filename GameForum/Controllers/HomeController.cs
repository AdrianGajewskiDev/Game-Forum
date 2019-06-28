using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameForum.Models;
using GameForum.Data;
using GameForum.ViewModels.Forum;

namespace GameForum.Controllers
{
    public class HomeController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;

        public HomeController(IForum forum, IPost post)
        {
            _forumService = forum;
            _postService = post;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll().Select(forum => new ForumListingModel
            {
                Id = forum.ID,
                Title = forum.Title,
                Description = forum.Description,
                Created = forum.Created
            });

            var model = new ForumIndexViewModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);

            var posts = _postService.GetAllByForumID(forum.ID).Select(post => new PostListingModel
            {
                ID = post.ID,
                AuthorName = post.AuthorName,
                Content = post.Content,
                Created = post.Created,
                ForumID = post.ForumID,
                Title = post.Title
            });

            var model = new ForumTopicViewModel
            { 
                Posts = posts,
                ForumTitle = forum.Title,
                ForumID = forum.ID
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
