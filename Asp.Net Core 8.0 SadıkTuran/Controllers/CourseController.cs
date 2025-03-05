using Asp.Net_Core_8._0_SadıkTuran.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_8._0_SadıkTuran.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult List()
        {
            return View(Repository.Cours);
        }
        public IActionResult List2(int id)
        {

            var secilikurs = Repository.GetByIdCourse(id);

            return View(secilikurs);
           
        }
    }
}
