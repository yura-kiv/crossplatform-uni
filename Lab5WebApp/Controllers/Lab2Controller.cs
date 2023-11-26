using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5WebApp.Models;
using Lab5CL;

namespace Lab5WebApp.Controllers
{
    [Authorize]
    public class Lab2Controller : Controller
    {
        public IActionResult Lab2()
        {
            var model = new LabDataModel();
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public string Lab2(LabDataModel model)
        {
            try
            {
                string inputPath = model.Input;
                string outputPath = model.Output;
                var lab2 = new Lab2();
                string res = lab2.Run(inputPath, outputPath);
                return res;
            }
            catch (Exception e)
            {
                return "Error to run Lab1 POST command....";
            }
        }
    }
}
