using Eticaret.Core.Entities;

namespace ETicaret.WebUI.Models
{
    public class ProductDetailViewModel
    {
        public Product? Product { get; set; }
        public IEnumerable<Product>? RelatedProducts { get; set; }

    }
}
