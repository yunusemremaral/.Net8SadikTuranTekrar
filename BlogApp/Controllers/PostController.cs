using BlogApp.Data.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Controllers
{
    public class PostController : Controller
    {
        private readonly BlogContext _blogContext;

        public PostController(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public async Task<IActionResult> Index()
        {
           var blogs= _blogContext.Posts.ToListAsync();
            return View(blogs);
        }
    }
}
