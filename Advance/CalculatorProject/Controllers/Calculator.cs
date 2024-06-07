using Microsoft.AspNetCore.Mvc;

namespace CalculatorProject.Controllers
{
    public class Calculator : Controller
    {
        public IActionResult Add(int no1,int no2)

        {
            int answer = no1 + no2;
            ViewData["no1"] = no1;
            ViewData["no2"] = no2;
            ViewData["answer"] = answer;

            return View();
        }
    }
}
