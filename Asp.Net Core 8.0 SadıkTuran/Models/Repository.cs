namespace Asp.Net_Core_8._0_SadıkTuran.Models
{
    public class Repository
    {
        private static readonly List<Course> Courses = new List<Course>();

        static Repository()
        {
            Courses = new List<Course>()
            {
                new Course(){Id=1,Title="kurs1"},
                new Course(){Id=2,Title="kurs2"}
            };
        }
        public static List<Course> Cours
        {
            get
            {
                return Courses;
            }
        }
        public static Course GetByIdCourse(int id)
        {
            return Courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
