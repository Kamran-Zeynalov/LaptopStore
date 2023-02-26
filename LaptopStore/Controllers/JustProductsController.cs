using LaptopStore.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class JustProductsController : Controller
    {
        public ProductAndModelsVM proMode;

        public ViewResult Products()
        {
            ProductAndModelsVM proMode = new();
            return View(proMode);
        }
    }

}
