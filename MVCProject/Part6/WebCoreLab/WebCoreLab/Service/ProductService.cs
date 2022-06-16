using System.Collections.Generic;
using System.Linq;
using WebCoreLab.Models.DBEntity;
using WebCoreLab.Models.DTO.Product;
using WebCoreLab.Repository;

namespace WebCoreLab.Service
{
    public class ProductService
    {
        private readonly MockRepository _mockRepository;

        public ProductService() 
        {
            _mockRepository = new MockRepository();
        }

        public IEnumerable<ProductDTO> GetProductList()
        {
            // 呼叫 Repository 存取資料
            var source = _mockRepository.GetAll<Product>();

            // 組成 DTO 模型
            var result = source.Select(p => new ProductDTO
            {
                Id = p.Id,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                Image = p.Image
            });

            return result;
        }

        public ProductDTO GetProduct(int id)
        {
            // 傳入id時檢查數值有沒有小於0 -> 如果小於0回傳null
            if (id <= 0) return null;

            // 呼叫 Repository 存取資料
            var source = _mockRepository.GetAll<Product>().FirstOrDefault(p => p.Id == id);

            // 找不到這個商品id要怎麼處理 -> 這邊我也回傳null
            if (source == null) return null;

            // 組成 DTO 模型
            var result = new ProductDTO
            {
                Id = source.Id,
                Name = source.Name,
                Price = source.Price,
                Description = source.Description,
                Image = source.Image
            };

            return result;
        }
    }
}
