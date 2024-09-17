using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TristanPrelim.Models;

namespace TristanPrelim.Pages
{
    public class IndexModel : PageModel
    {
        public ShoppingCart Cart { get; set; } = new ShoppingCart();

        [BindProperty]
        public string ProductName { get; set; }

        [BindProperty]
        public decimal ProductPrice { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                var product = new Product(ProductName, ProductPrice);
                Cart.AddItem(product);

                
            }
        }
    }
}
