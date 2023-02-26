using LaptopStore.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class JustModelsController: Controller
    {
        public ProductAndModelsVM proMode;

        public ViewResult ProductModels()
        {
            ProductAndModelsVM proMode = new();
            return View(proMode);
        }
    }
}
