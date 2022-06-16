using System.Collections.Generic;
using WebCoreLab.Models.DBEntity;

namespace WebCoreLab.Mock
{
    public class MockData
    {
        public static Dictionary<string, dynamic> DataList = new Dictionary<string, dynamic>()
        {
            {
                typeof(Product).Name,
                new List<Product>
                {
                    new Product { Id = 1, Name = "熊熊0號", Price = 100, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__0B.png" },
                    new Product { Id = 2, Name = "熊熊1號", Price = 200, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__1B.png" },
                    new Product { Id = 3, Name = "熊熊2號", Price = 300, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__2B.png" },
                    new Product { Id = 4, Name = "熊熊3號", Price = 400, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__3B.png" },
                    new Product { Id = 5, Name = "熊熊4號", Price = 500, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__4B.png" },
                    new Product { Id = 6, Name = "熊熊5號", Price = 600, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__6B.png" },
                    new Product { Id = 7, Name = "熊熊6號", Price = 700, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__7B.png" },
                    new Product { Id = 8, Name = "熊熊7號", Price = 800, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__8B.png" },
                    new Product { Id = 9, Name = "熊熊8號", Price = 900, Description = "熊好吃", Image = "https://raw.githubusercontent.com/ChouJustice/ImageRepository/main/__10B.png" }
                }
            },
            //...如果有其他表再往後加上
        };
    }
}
