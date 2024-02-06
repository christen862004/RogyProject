using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult All()
        {
            //call model
            StudentBL studentBL = new StudentBL();
            List<Student> stdModel= studentBL.GetAll();
            //send 
            return View("ShowAll",stdModel);//Model==>List<Student>
        }
    }
}
