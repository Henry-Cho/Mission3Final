using IS413Mission3Final.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mission3.Controllers
{
    public class BlahController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult form ()
        {
            return View();
        }

        resultModel result = new resultModel();

        [HttpPost]
        public IActionResult form (formModel model)
        {
            if (ModelState.IsValid)
            {
                double homework = model.homework * 0.55;
                double groupProject = model.gp * 0.05;
                double quiz = model.quiz * 0.1;
                double exam = model.exam * 0.2;
                double intex = model.intex * 0.1;

                double total = homework + groupProject + quiz + exam + intex;

                total = Math.Round((Double)total, 2);

                string letterGrade = "";

                if (total >= 94)
                {
                    letterGrade = "A";
                }
                else if (total >= 90)
                {
                    letterGrade = "A-";
                }
                else if (total >= 87)
                {
                    letterGrade = "B+";
                }
                else if (total >= 84)
                {
                    letterGrade = "B";
                }
                else if (total >= 80)
                {
                    letterGrade = "B-";
                }
                else if (total >= 77)
                {
                    letterGrade = "C+";
                }
                else if (total >= 74)
                {
                    letterGrade = "C";
                }
                else if (total >= 70)
                {
                    letterGrade = "C-";
                }
                else if (total >= 67)
                {
                    letterGrade = "D+";
                }
                else if (total >= 64)
                {
                    letterGrade = "D";
                }
                else if (total >= 60)
                {
                    letterGrade = "D-";
                }
                else
                {
                    letterGrade = "E";
                }

                result.total_pct = total;
                result.letter_grade = letterGrade;

                ViewBag.Total_Percentage = result.total_pct;
                ViewBag.Letter_Grade = result.letter_grade;

            }
            return View();
        }
    }
}
