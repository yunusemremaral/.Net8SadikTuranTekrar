using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.ViewComponents
{
    public class NewPost:ViewComponent
    {
        private IPostRepository _postrepository;

        public NewPost(IPostRepository postrepository)
        {
            _postrepository = postrepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _postrepository
                                .Posts
                                .OrderByDescending(p => p.PublishedOn)
                                .Take(5)
                                .ToListAsync()
            );
        }
    }
}
