using Microsoft.AspNetCore.Mvc;
using System;

namespace cd_c_timeDisplay
{

    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            DateTime date1 = DateTime.Now;
            ViewBag.date1 = date1;
            return View();
        }

        
    }

}
