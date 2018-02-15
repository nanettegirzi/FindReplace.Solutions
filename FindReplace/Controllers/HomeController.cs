using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FindReplace.Models;

namespace FindReplace.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/replaceword")]
        public ActionResult ReplaceWord()
        {
            string userWord = Request.Form["word"];
            string replaceThis = Request.Form["replace"];
            string userSentence = Request.Form["sentence"];

            FindAndReplace newFindAndReplace = new FindAndReplace(userSentence, replaceThis, userWord);
            return View("Index", newFindAndReplace);
        }

    }
}
