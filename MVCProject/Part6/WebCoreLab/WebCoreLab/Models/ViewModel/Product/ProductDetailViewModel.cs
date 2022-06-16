namespace WebCoreLab.Models.ViewModel.Product
{
    public class ProductDetailViewModel
    {
        public ProductData Product { get; set; }

        public class ProductData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }
            public string Image { get; set; }
        }
    }
}
