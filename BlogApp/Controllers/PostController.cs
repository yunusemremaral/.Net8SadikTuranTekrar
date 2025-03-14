using BlogApp.Data.Abstract;
using BlogApp.Data.Db;
using BlogApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ITagRepository _tagRepository;

        public PostController(IPostRepository postRepository, ITagRepository tagRepository)
        {
            _postRepository = postRepository;
            _tagRepository = tagRepository;
        }

        public async Task<IActionResult> Index()
        {


            return View(new PostsViewModel2
            {
                Tags = await _tagRepository.Tags.ToListAsync(),
                Posts = await _postRepository.Posts.ToListAsync()
            });
        }
    }
}
