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

        public IActionResult form ()
        {
            return View();
        }
    }
}
