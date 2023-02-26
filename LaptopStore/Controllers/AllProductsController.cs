using LaptopStore.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace LaptopStore.Controllers
{
    public class AllProductsController:Controller
    {
        public ProductAndModelsVM proMode;

        public ViewResult ProAndMode()
        {
            ProductAndModelsVM proMode = new();
            return View(proMode);
        }
    }
}
