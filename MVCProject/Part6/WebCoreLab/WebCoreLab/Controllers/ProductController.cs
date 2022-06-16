using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebCoreLab.Models.ViewModel.Product;
using WebCoreLab.Service;

namespace WebCoreLab.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;

        public ProductController()
        {
            _productService = new ProductService();
        }

        public IActionResult List()
        {
            // 呼叫 Service 存取資料
            var products = _productService.GetProductList();


            // 組成 View 看到的模型
            var firstProduct = products.First();
            var result = new ProductListViewModel 
            {
                //左側較大的商品，取商品資料的第一個商品
                MainProduct = new ProductListViewModel.ProductData
                {
                    Id = firstProduct.Id,
                    Name = firstProduct.Name,
                    Description = firstProduct.Description,
                    Image = firstProduct.Image
                },
                //右側較小的商品，取第1個之外的剩下8個商品
                SideProductList = products.Skip(1).Take(8).Select(p => new ProductListViewModel.ProductData
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Image = p.Image
                })
            };

            return View(result);
        }

        public IActionResult Detail(int id)
        {
            // 呼叫 Service 存取資料
            var product = _productService.GetProduct(id);

            // 組成 View 看到的模型
            var result = new ProductDetailViewModel
            {
                Product = new ProductDetailViewModel.ProductData
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Description = product.Description,
                    Image = product.Image
                }
            };

            return View(result);
        }
    }
}
