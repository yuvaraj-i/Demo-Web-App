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

            var student1 = new StudentModel() { FirstName = "Yuvaraj", Id = 1, Email = "yuvaraj@gmail.com" };
            var student2 = new StudentModel() { FirstName = "Raj", Id = 2, Email = "raj@gmail.com" };
            StudentModel student3 = new() { FirstName = "Ram", Id = 3, Email = "ram@gmail.com" };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            return students;

        }

        public IActionResult Registration(StudentModel student)
        {
            if(ModelState.IsValid) {
                return Redirect("/student/list");
            }

            Console.WriteLine(student.Id);

            return View();
        }




    }
}
