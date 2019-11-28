using System;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     // index
        public ViewResult Survey()
        {
            return View();
        }

        [HttpPost("/results")]
        public IActionResult Submission(User newUser)
        {
            return View("Results", newUser);
        }

        // if the user types an unknown address it gets redirected to index
        [HttpGet]
        [Route("{Path}")]
        public RedirectToActionResult Unknown(string Path)
        {
            Console.WriteLine(Path);
            return RedirectToAction("Index");
        }
    }
}