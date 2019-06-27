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

        public HomeController(IForum forum)
        {
            _forumService = forum;
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
