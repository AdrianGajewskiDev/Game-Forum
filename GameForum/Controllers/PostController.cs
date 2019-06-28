﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        private readonly IForum _forumService;

        public PostController(IPost post, IForum forum)
        {
            _postService = post;
            _forumService = forum;
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

        public IActionResult Create(int id)
        {
            var forum = _forumService.GetById(id);

            var model = new NewPostModel
            {
                ForumID = forum.ID,
                ForumName = forum.Title
                
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddPost(NewPostModel model)
        {
            var post = CreatePost(model);

            await _postService.AddPost(post);

            return RedirectToAction("Index", "Home", post.ID);
        }

        private Post CreatePost(NewPostModel post)
        {
            return new Post
            {
                AuthorName = "User",
                Content = post.Content,
                Created = DateTime.UtcNow,
                ForumID = post.ForumID,
                PostReplies = post.PostReplies,
                Title = post.Title

            };
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