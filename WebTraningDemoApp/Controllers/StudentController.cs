using Microsoft.AspNetCore.Mvc;
using WebTraningDemoApp.Models;

namespace WebTraningDemoApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult List()
        {
            return View(GetStudentsDetails());
        }

        private List<StudentModel> GetStudentsDetails()
        {
            List<StudentModel> students = new List<StudentModel>();

            var student1 = new StudentModel() { Name = "Yuvaraj", Id = 1, Email = "yuvaraj@gmail.com", Level = "studing" };
            var student2 = new StudentModel() { Name = "Raj", Id = 2, Email = "raj@gmail.com", Level = "Graduate" };
            StudentModel student3 = new StudentModel() { Name = "Ram", Id = 3, Email = "ram@gmail.com", Level = "studing" };

            students.Add(student1);
            students.Add(student2);
            //students.Add(student1);
            students.Add(student3);

            return students;

        }

    }
}
