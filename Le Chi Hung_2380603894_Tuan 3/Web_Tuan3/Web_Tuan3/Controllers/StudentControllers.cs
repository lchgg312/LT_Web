using Microsoft.AspNetCore.Mvc;
using Web_Tuan3.Models;

namespace Web_Tuan3.Controllers
{
    public class StudentController : Controller
    {
        private static List<StudentModel> listStudents = new List<StudentModel>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowKQ(StudentModel student)
        {
            listStudents.Add(student);

            int countSameMajor = listStudents.Count(s => s.ChuyenNganh == student.ChuyenNganh);
            ViewBag.Count = countSameMajor;

            return View(student);
        }

        public IActionResult List()
        {
            return View(listStudents);
        }
    }
}

