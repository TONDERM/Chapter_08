using System.Collections.Generic;

namespace GuitarShop.Models
{
    public class ProductListViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public object products { get; internal set; }
        public string SelectedCategory { get; set; }
        public string CheckActiveCategory(string category) => category == SelectedCategory ? "active" : "";
    }
}
