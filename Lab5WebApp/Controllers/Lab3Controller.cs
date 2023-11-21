using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Lab5WebApp.Models;
using Lab5CL;

namespace Lab5WebApp.Controllers
{
    [Authorize]
    public class Lab3Controller : Controller
    {
        public IActionResult Lab3()
        {
            var model = new LabDataModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Lab3(LabDataModel model)
        {
            try
            {
                string inputPath = model.Input;
                string outputPath = model.Output;
                var Lab3 = new Lab3();
                Lab3.Run(inputPath, outputPath);
                return View(model);
            }
            catch (Exception e)
            {
                return View(model);
            }
        }
    }
}
