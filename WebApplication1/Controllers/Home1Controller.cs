using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Home1Controller : Controller
    {
          public IActionResult Index()
          {
              return View();
          }


        /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
         public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/

       /* public string Index()
        {
            return "This is my <b>default</b> action...";
        }


        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
       */
    }



}
