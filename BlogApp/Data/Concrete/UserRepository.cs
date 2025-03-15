using BlogApp.Data.Abstract;
using BlogApp.Data.Db;
using BlogApp.Entity;

namespace BlogApp.Data.Concrete
{
    public class UserRepository:IUserRepository
    {
        private BlogContext _context;
        public UserRepository(BlogContext context)
        {
            _context = context;
        }
        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
