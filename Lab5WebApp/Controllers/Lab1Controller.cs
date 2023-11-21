using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5WebApp.Models;
using Lab5CL;

namespace Lab5WebApp.Controllers
{
    [Authorize]
    public class Lab1Controller : Controller
    {
        public IActionResult Lab1()
        {
            var model = new LabDataModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Lab1(LabDataModel model)
        {
            try
            {
                string inputPath = model.Input;
                string outputPath = model.Output;
                var lab1 = new Lab1();
                lab1.Run(inputPath, outputPath);
                return View(model);
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
    }
}
