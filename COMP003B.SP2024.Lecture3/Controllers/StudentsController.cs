// TODO: reference Models namespace
using COMP003B.SP2024.Lecture3.Models;
using Microsoft.AspNetCore.Mvc;


namespace COMP003B.SP2024.Lecture3.Controllers
{
    public class StudentsController : Controller
    {
        private static List<Student> _students = new List<Student>();

        // GET: Students
        public IActionResult Index()
        {
            return View(_students);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            // TODO: add model state validation
           if (ModelState.IsValid)
            {
                // TODO: check if student already exists
                if (!_students.Any(s => s.Id == student.Id))
                {
                    // TODO: add student to list
                    _students.Add(student);
                }

                // TODO: redirect back to index
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}
