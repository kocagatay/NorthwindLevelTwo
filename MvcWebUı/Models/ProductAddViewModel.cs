using Entities.Concrete;

namespace MvcWebUI.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; set; }

        public Product Product { get; set; }
    }
}
