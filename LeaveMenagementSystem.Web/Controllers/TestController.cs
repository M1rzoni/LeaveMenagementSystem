using LeaveMenagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveMenagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student if MVC Mastery",
                DateOfBirth = new DateTime(1954,12,01)
                
            };
            return View(data);
        }
    }
}
