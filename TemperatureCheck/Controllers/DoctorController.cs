using Microsoft.AspNetCore.Mvc;
using TemperatureCheck.Models;

namespace TemperatureCheck.Controllers
{
    public class DoctorController : Controller
    {
        [HttpPost]
        [Route("FeverCheck")]
        public IActionResult CheckTemperature(TemperatureModelMV model)
        {
            if (!model.Temperature.HasValue)
            {
                TempData["ErrorMessage"] = "Please enter your temperature.";
                return RedirectToAction("Index", "Home");
            }

            var diagnosis = model.GetDiagnosis();
            return View("TemperatureDiagnose", diagnosis);
        }

        [HttpPost]
        public IActionResult TemperatureDiagnose()
        {
            return View();
        }
    }
}
