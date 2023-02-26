using LaptopStore.Models;

namespace LaptopStore.ViewModels
{
    public class ProductAndModelsVM
    {
        public List<Products> Products { get; set; }
        public List<ProductModels> ProductModels { get; set; }

        public ProductAndModelsVM()
        {
            ProductModels = new List<ProductModels>()
            {
                new ProductModels()
                {
                    Id = 1,
                    ProductModel = "Thinkpad",
                },
                  new ProductModels()
                {
                    Id = 2,
                    ProductModel = "Acer",
                },
                    new ProductModels()
                {
                    Id = 3,
                    ProductModel = "MSI",
                },
                      new ProductModels()
                {
                    Id = 4,
                    ProductModel = "Lenovo",
                },
            };

            Products = new List<Products>()
            {
                new Products()
                {
                    ImgSrc = "https://www.lenovo.com/medias/lenovo-laptop-thinkpad-l450-side-back-7.jpg?context=bWFzdGVyfGltYWdlc3wzNDYyMnxpbWFnZS9qcGVnfGltYWdlcy9oZTMvaDAzLzkxNjIyODkwMjA5NTguanBnfGZhMWI3MmY4OTk2YTUxNGVkNDNiMjI3NjgxZTk1YzBhN2U0YjFiMzEwNzBmNzM2MDAyNmRiZmI4M2IzMjEyNmU",
                    Id = 1,
                    Name = "Lenovo Thinkpad",
                    Price = 10000,
                },
                new Products()
                {
                    ImgSrc = "https://i.dell.com/is/image/DellContent//content/dam/ss2/product-images/dell-client-products/notebooks/latitude-notebooks/14-3420/media-gallery/peripherals_laptop_latitude_3420nt_gallery_1.psd?fmt=pjpg&pscan=auto&scl=1&wid=3319&hei=2405&qlt=100,1&resMode=sharp2&size=3319,2405&chrss=full&imwidth=5000",
                    Id = 2,
                    Name = "Dell for ofice",
                    Price = 999,
                },
                new Products()
                {
                    ImgSrc = "https://dlcdnwebimgs.asus.com/gain/1184b48b-1b10-462f-a4c1-d43852a64163/",
                    Id = 3,
                    Name = "Asus DD12",
                    Price = 1200,
                },
                new Products()
                {
                    ImgSrc = "https://bestel.az/storage/22194/conversions/media-libraryap1txw-lg.jpg",
                    Id = 4,
                    Name = "Lenovo RTW",
                    Price = 2559,
                },
                new Products()
                {
                    ImgSrc = "https://www.denofgeek.com/wp-content/uploads/2020/07/MSI-laptops.jpg?fit=1200%2C675",
                    Id = 5,
                    Name = "MSI 12 pro",
                    Price = 2110,
                },
                new Products()
                {
                    ImgSrc = "https://www.asus.com/media/Odin/Websites/global/ProductLine/20200824120814.jpg",
                    Id = 6,
                    Name = "Asus Xs Max",
                    Price = 1000,
                },

            };
        }
    }
}
