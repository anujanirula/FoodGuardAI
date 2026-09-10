using Microsoft.AspNetCore.Mvc;

namespace FoodGuardAI.Web.Controllers;

public class FoodController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Analyze(IFormFile image)
    {
        if (image == null)
        {
            ViewBag.Error = "Please select an image.";
            return View("Index");
        }

        return Content($"Image uploaded successfully: {image.FileName}");
    }
}
