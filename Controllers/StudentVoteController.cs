using Dotnet_M1_A2.DatabaseContext;
using Dotnet_M1_A2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_M1_A2.Controllers
{
    public class StudentVoteController : Controller
    {

        private readonly AppDbContext _context;

        public StudentVoteController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create([Bind(Prefix = "id")] int id)
        {
            var nomineesForPosition = _context.positionTbl.Where(p => p.PositionID == id).Select(p => new
            {
                PositionId = p.PositionID,
                Nominees = new List<string> { p.Nominee1, p.Nominee2, p.Nominee3, p.Nominee4 }
            })
                .FirstOrDefault();

            if (nomineesForPosition != null)
            {
                var allNominees = nomineesForPosition.Nominees.Distinct().ToList();
                var nominees = allNominees.Select(n => new SelectListItem { Value = n, Text = n });
                ViewBag.Nominees = nominees;
                ViewBag.PositionID = nomineesForPosition.PositionId;
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        
        [HttpPost]
        public IActionResult Create(Vote model, int id)
        {
        //   var  IsValidStudentId=_context.studentTbl.Any(s => s.StudentID == model.StudentID);
        //     if (!IsValidStudentId)
        //     {
        //         TempData["InvalidMessage"] = "Invalid Student ID.";

        //         return RedirectToAction("Index");
        //     }


            var isAlreadyVoted = _context.voteTbl.Any(x => x.StudentID == model.StudentID && x.PositionID == id);
              if (isAlreadyVoted)
              {

                TempData["FailureMessage"] = "Student ID is already voted for this position.";

                return RedirectToAction("Index");
            }
            else
            {

                model.PositionID = id;

                model.Date_Time = DateTime.Now;

                _context.voteTbl.Add(model);

                _context.SaveChanges();

               // TempData["SuccessMessage"] = "Thanks for voting !!!";



                return View("Index");


            }





        }
    }
} 
