using Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //MEthod:Action
        //1)Public 
        //2)cant overload
        //3)Cant be static 
        //Home/Method
        public string Method1()
        {
            return "Hello";
        }
        //home/ShowContent
        public ContentResult ShowContent()
        {
            //Declare 
            ContentResult result = new ContentResult();
            //setValue
            result.Content = "Hello";
            //return
            return result;
        }
        public ViewResult showView()
        {
            //logic
            ViewResult result = new ViewResult();
            result.ViewName = "Rogy";
            return result;
        }
////private ViewResult GreateView(string viewnaame)
////        {
////            ViewResult result = new ViewResult();
////            result.ViewName = "viewnaame";
////            return result;
////        }
//Home/showmix
        public IActionResult ShowMix(int id,int age,string name)
        
        {
            if (id % 2 == 0)
            {
                return View("Rogy");
            }
            else
            {
                return Content("hello");
            }
        }

        //action
        /*
         1)Content==>ContentRrsult
         2)View ====>ViewResuilt
         3)Json ====>
         4)NotFound
         5)Javascript
         6) File
        .....
         */



        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
