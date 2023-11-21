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

        [HttpPost]
        public IActionResult Lab2(LabDataModel model)
        {
            try
            {
                string inputPath = model.Input;
                string outputPath = model.Output;
                var Lab2 = new Lab2();
                Lab2.Run(inputPath, outputPath);
                return View(model);
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
    }
}
