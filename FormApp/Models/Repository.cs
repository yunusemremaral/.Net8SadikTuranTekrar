namespace FormApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _productList = new();
        private static readonly List<Category> _categories = new();

        static  Repository()
        {
            _categories.Add()
        }
        

        public static List<Product> Products
        {
            get
            {
                return _productList;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}
