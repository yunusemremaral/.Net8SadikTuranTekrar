using BlogApp.Data.Abstract;
using BlogApp.Data.Db;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete
{
    public class TagRepository:ITagRepository
    {
        private BlogContext _context;
        public TagRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<Tag> Tags => _context.Tags;

        public void CreateTag(Tag Tag)
        {
            _context.Tags.Add(Tag);
            _context.SaveChanges();
        }
    }
}
