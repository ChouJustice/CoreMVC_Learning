using System.Collections.Generic;

namespace WebCoreLab.Models.ViewModel.Product
{
    public class ProductListViewModel
    {
        public ProductData MainProduct { get; set; }
        public IEnumerable<ProductData> SideProductList { get; set; }

        public class ProductData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
    }
}
