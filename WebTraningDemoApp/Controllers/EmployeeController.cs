using Microsoft.AspNetCore.Mvc;

namespace WebTraningDemoApp.Controllers
{
    [Route("[Controller]")]
    public class EmployeeController : Controller
    {
        [Route("yuvaraj")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            //ViewData["id"] = id;
            return View();
        }
    }
}
