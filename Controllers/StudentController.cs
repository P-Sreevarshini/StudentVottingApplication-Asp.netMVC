using Dotnet_M1_A2.DatabaseContext;
using Dotnet_M1_A2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_M1_A2.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context; //variable to communicate with db
        }

        public IActionResult Index()
        {
            var students = _context.studentTbl.ToList(); // Fetching only student details
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        //create student
        [HttpPost]
        public IActionResult Create(Student model)
        {
            //add data to the database
            _context.studentTbl.Add(model);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index)); //redirecting to index view after adding 
        }
    }
}
