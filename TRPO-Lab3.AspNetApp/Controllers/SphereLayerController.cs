using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.AspNetApp.Models;
using TRPO_Lab3.Lib;

namespace TRPO_Lab3.AspNetApp.Controllers
{
    public class SphereLayerController : Controller
    {
        // GET: SphereLayerController
        public ActionResult Index(double radius1, double radius2, double height)
        {
            double volume = SphereLayer.FindVolume(radius1, radius2, height);
            var model = new SphereLayerViewModel();
            model.Radius1 = radius1;
            model.Radius2 = radius2;
            model.Height = height;
            model.Volume = volume.ToString();
            return View(model);
        }

        // POST: SphereLayerController
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(double radius1, double radius2, double height, IFormCollection collection)
        {
            try
            {
                double volume = SphereLayer.FindVolume(radius1, radius2, height);
                var model = new SphereLayerViewModel();
                model.Radius1 = radius1;
                model.Radius2 = radius2;
                model.Height = height;
                model.Volume = volume.ToString();
                return RedirectToAction(nameof(Index), model);
            }
            catch
            {
                return View();
            }
        }
    }
}
